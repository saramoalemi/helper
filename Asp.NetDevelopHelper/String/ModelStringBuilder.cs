using Asp.NetDevelopHelper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.String
{
    public class ModelStringBuilder
    {
        private readonly BaseModel data;

        public ModelStringBuilder(BaseModel data)
        {
            this.data = data;
        }

        public string GetModelClass()
        {
            StringBuilder builder = new StringBuilder(
                 $@"
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
{(data.Relations.Count > 0 && data.Relations.Any(x => x.Schema != data.Schema) ? string.Join("", data.Relations.Select(x => $"using ArvinERP.Domain.Models.{x.Schema};\n").Distinct()) : "")}

namespace ArvinERP.Domain.Models.{data.Schema}
{{
    public class {data.Table} {(data.Inherited ? $":ObjectModel<{data.KeyType}>" : "")}
    {{"
                                                        );

            foreach (var item in data.Properties)
            {
                builder.Append($@"{(item.Maxlength != null ? $"\n\t\t[MaxLength({item.Maxlength})]" : "")}{(item.Minlength != null ? $"\n\t\t[MinLength({item.Minlength})]" : "")}                       
        public {item.Type}{(!item.Required ? "?" : "")} {item.Name} {{ get; set; }}");
                if (data.Relations.Where(x=> !x.IsSoftRelation).Any(x => x.ForeignKey == item.Name && x.RelationType != RelationType.Many2Many))
                {
                    var rel = data.Relations.FirstOrDefault(x => x.ForeignKey == item.Name);
                    builder.Append($"\n\t\tpublic virtual {rel.Table} {rel.Table} {{ get; set; }}");
                }                
            }
                data.Relations.Where(x => !x.IsSoftRelation && x.RelationType == RelationType.Many2Many).ToList().ForEach(x =>
                {
                    builder.Append($"\n\t\tpublic virtual ICollection<{x.Table}> {x.Table} {{ get; set; }}");
                });           


            builder.Append($@"
    }}

    public class {data.Table}Configuration : IEntityTypeConfiguration<{data.Table}>
    {{

        public void Configure(EntityTypeBuilder<{data.Table}> builder)
        {{
            builder.ToTable(""{data.Table}"", ""{data.Schema}"");
            {(data.KeyType == null && !data.Properties.Any(x => x.IsKey) ? "builder.HasNoKey();" : "")}
            {(data.Properties.Any(x => x.IsKey) ? "builder.HasKey(x =>" + (data.Properties.Where(x => x.IsKey).Count() > 1 ? $"new {{ {string.Join(", ", data.Properties.Where(x => x.IsKey).Select(x => $"x.{x.Name}"))} }});" : $" x.{data.Properties.FirstOrDefault(x => x.IsKey).Name});") : "")}
            {(data.Inherited ? data.HasYear ? @$"builder.Property(x => x.Year).HasColumnName(""{data.YearName}"");" : "builder.Ignore(x => x.Year);" : "")}");
            foreach (var item in data.UniqueIndexes)
            {
                builder.Append(@$"
            builder.HasIndex(i => {(item.Count > 1 ? $"new {{ {string.Join(",", item.Select(x => $"i.{x}"))}}})" : $"i.{item.FirstOrDefault()})")}
               .HasDatabaseName(""UK_{string.Join('_', item)}"")
               .HasFilter(""[IsDeleted_]= 0"")
               .IsUnique();");
            }
            foreach (var item in data.Properties.Where(x => x.HasIndex))
            {
                builder.Append(@$"
            builder.HasIndex(i => i.{item.Name})
               .HasDatabaseName(""IX_{data.Table}_{item.Name}"");");
            }
            foreach (var item in data.Relations.Where(x=> !x.IsSoftRelation))
            {
                switch (item.RelationType)
                {
                    case RelationType.One2Many:
                        builder.Append(@$"
            builder.HasOne(x => x.{item.Table})
                .WithMany(x => x.{data.Table})                
                .HasForeignKey(x => x.{item.ForeignKey}){(item.PrincipalKey.ToLower() != "id" ? $".HasPrincipalKey(x=> x.{item.PrincipalKey})\n" : "")}                             
                .HasConstraintName(""FK_{item.Table}_{data.Table}""){(item.DeleteBahavior != DeleteBahavior.SetNull ? ".IsRequired()" : "")}               
                .OnDelete(DeleteBehavior.{item.DeleteBahavior});");
                        break;

                    case RelationType.One2One:
                        builder.Append(@$"
            builder.HasOne(x => x.{item.Table})
                .WithOne(x => x.{data.Table})                  
                .HasForeignKey<{data.Table}>(x => x.{item.ForeignKey}){(item.PrincipalKey != "Id" ? $".HasPrincipalKey<{item.Table}>(x=> x.{item.PrincipalKey})\n" : "")}                              
                .HasConstraintName(""FK_{item.Table}_{data.Table}""){(item.DeleteBahavior != DeleteBahavior.SetNull ? ".IsRequired()" : "")}  
                .OnDelete(DeleteBehavior.{item.DeleteBahavior});");
                        break;

                    case RelationType.Many2Many:
                        builder.Append($@"
             builder.HasMany(x => x.{item.Table})
                .WithMany(x => x.{data.Table})
                .UsingEntity<Dictionary<string, object>>(                
                l => l.HasOne<{item.Table}>().WithMany()
                        .HasForeignKey(""{item.Table}_Key"")
                        .HasConstraintName(""FK_{item.Table}_{data.Table}"")
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade),
                r => r.HasOne<{data.Table}>().WithMany()
                        .HasForeignKey(""{data.Table}_Key"")
                        .HasConstraintName(""FK_{data.Table}_{data.Table}"")
                        .IsRequired()
                        .OnDelete(DeleteBehavior.Cascade),
                j =>
                {{
                    j.HasKey(""{item.Table}_Key"", ""{data.Table}_Key"");
                    j.HasIndex(new[] {{ ""{item.Table}_Key"" }}, ""IX_{item.Table}{data.Table}_{item.Table}_{item.PrincipalKey}"");
                    j.ToTable(""{item.Table}{data.Table}"",""{item.Schema}"");
                }});");
                        break;

                    default:
                        break;
                }
            }
            builder.Append($@"
        }}
    }}
}}          ");



            return builder.ToString();

        }
        //قضیه اش کنسله
        public List<string> GetMany2ManyModelClass()
        {
            var result = new List<string>();
            foreach (var item in data.Relations.Where(x => x.RelationType == RelationType.Many2Many))
            {

                StringBuilder builder = new StringBuilder(
                    $@"
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using ArvinERP.Domain.Models.{item.Table};
using ArvinERP.Domain.Models.{data.Table};

namespace ArvinERP.Domain.Models.{data.Schema}
{{
    public class {item.Table}{data.Table}
    {{
        public {data.Properties.FirstOrDefault(x => x.Name == item.ForeignKey).Type} {item.Table}_{item.PrincipalKey} {{ get; set; }}
        public virtual {item.Table} {item.Table} {{ get; set; }}
        public {data.Properties.FirstOrDefault(x => x.Name == item.ForeignKey).Type} {data.Table}_{item.ForeignKey} {{ get; set; }}
        public virtual {data.Table} {data.Table} {{ get; set; }}
    }}

    public class {item.Table}{data.Table}Configuration : IEntityTypeConfiguration<{item.Table}{data.Table}>
    {{

        public void Configure(EntityTypeBuilder<{item.Table}{data.Table}> builder)
        {{
            builder.HasOne(x => x.{item.Table})
                .WithMany(x => x.{item.Table}{data.Table})                
                {(item.PrincipalKey != "Id" ? $".HasPrincipalKey(x=> x.{item.PrincipalKey})\n" : "")}.HasForeignKey(x => x.{item.Table}_{item.PrincipalKey})                             
                .HasConstraintName(""FK_{item.Table}_{data.Table}"")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.{data.Table})
                .WithMany(x => x.{item.Table}{data.Table}) 
                {(item.ForeignKey != "Id" ? $".HasPrincipalKey(x=> x.{item.ForeignKey})\n" : "")}.HasForeignKey(x => x.{data.Table}_{item.ForeignKey})                             
                .HasConstraintName(""FK_{data.Table}_{item.Table}"")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }}
    }}

}}
                   ");
                result.Add(builder.ToString());
            }
            return result;
        }
        public string GetDtoClass()
        {
            StringBuilder builder = new StringBuilder(
                 $@"
using System.ComponentModel.DataAnnotations;

namespace ArvinERP.Domain.DTOs.{data.Schema}
{{
    public class {data.Table}Dto {(data.Inherited ? $":Base.BaseDto<{data.KeyType}>" : "")}
    {{");
            if (data.Inherited && !data.HasYear)
            {
                builder.Append($@"
        [Obsolete]
        public override int Year {{ get; set; }}
            ");
            }

            foreach (var item in data.Properties)
            {
                builder.Append($"\n\t\t[Display(Name = nameof(Resources.{data.Schema}.{data.Table}_{item.Name}), ResourceType = typeof(Resources.{data.Schema}))]\n");
                if (item.Maxlength != null)
                    builder.Append($"\t\t[MaxLength(length: {item.Maxlength}, ErrorMessageResourceName = nameof(Resources.Shared.MaxLengthError), ErrorMessageResourceType = typeof(Resources.Shared))]\n");
                if (item.Minlength != null)
                    builder.Append($"\t\t[MinLength(length: {item.Minlength}, ErrorMessageResourceName = nameof(Resources.Shared.MinLengthError), ErrorMessageResourceType = typeof(Resources.Shared))]\n");
                if (item.Regex != null)
                    builder.Append($"\t\t[RegularExpression(@\"{item.Regex}\", ErrorMessageResourceName = nameof(Resources.Shared.FormatError), ErrorMessageResourceType = typeof(Resources.Shared))]\n");
                if (item.Required)
                    builder.Append($"\t\t[Required(ErrorMessageResourceName = nameof(Resources.Shared.RequiredError), ErrorMessageResourceType = typeof(Resources.Shared))]\n");
                builder.Append($"\t\tpublic {item.Type}{(!item.Required ? "?" : "")} {item.Name} {{ get; set; }}\n");

            }
            builder.Append($@"
            


    }}
}}");
            return builder.ToString();

        }


        public string GetViewModelClass()
        {
            StringBuilder builder = new StringBuilder(
                 $@"
using ArvinERP.Domain.ViewModels.Base;
using System.ComponentModel.DataAnnotations;

namespace ArvinERP.Domain.ViewModels.{data.Schema}
{{
    public class {data.Table}ViewModel {(data.Inherited ? $":BaseViewModel<{data.KeyType}>" : "")}
    {{"
                                                        );
            if (data.Inherited && !data.HasYear)
            {
                builder.Append($@"
        [Obsolete]
        public override int Year {{ get; set; }}
        ");
            }
            foreach (var item in data.Properties)
            {
                builder.Append($"\n\t\t[Display(Name = nameof(Resources.{data.Schema}.{data.Table}_{item.Name}), ResourceType = typeof(Resources.{data.Schema}))]\n");
                builder.Append($"\t\tpublic {item.Type}{(!item.Required ? "?" : "")} {item.Name} {{ get; set; }}");
            }

            builder.Append($@"
    }}
}}");


            return builder.ToString();

        }

        public string GetMappingClass()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($@"
using ArvinERP.Domain.DTOs.{data.Schema};
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Domain.ViewModels.{data.Schema};
using AutoMapper;

namespace ArvinERP.Domain.Mapping.{data.Schema}
{{
    public class {data.Table}MappingProfile :Profile
    {{
        public {data.Table}MappingProfile()
        {{
            CreateMap<{data.Table}, {data.Table}ViewModel>();
            CreateMap<{data.Table}Dto, {data.Table}>().AddTransform<string>(s => string.IsNullOrEmpty(s) ? null : s).ReverseMap();
        }}
    }}
}}
                            ");
            return builder.ToString();
        }


        public string GetIRepository()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($@"
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Infrastructure.Repositories.Base;

namespace ArvinERP.Infrastructure.Interfaces.{data.Schema}
{{
    public interface I{data.Table}Repository {(data.Inherited ? $": IBaseRepository<{data.Table}, {data.KeyType}>" : "")}
    {{
    }}
}}
                            ");
            return builder.ToString();

        }

        public string GetRepository()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($@"
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Infrastructure.Interfaces.{data.Schema};
using ArvinERP.Infrastructure.Repositories.Base;

namespace ArvinERP.Infrastructure.Repositories.{data.Schema}
{{
    public class {data.Table}Repository :{(data.Inherited ? $" BaseRepository<{data.Table}, {data.KeyType}>," : "")} I{data.Table}Repository
    {{

        public {data.Table}Repository(ArvinContext repositoryContext) {(data.Inherited ? ": base(repositoryContext)" : "")}
        {{
        }}
    }}
}}
                            ");
            return builder.ToString();

        }

        public string GetRepositoryWithRelation()
        {
            var princtables = data.Relations.Where(x => x.IsSoftRelation).Select(x => x.Table).Distinct().ToList();
            var pincRepos = princtables.Select(x => $",{x}Repository {x.ToLower()}Repo").ToList();
           var overrides = princtables.Select(p =>             
                $@"
            if({p.ToLower()}Repo.GetQueryable(x=> {string.Join(" && ", data.Relations.Where(x => x.IsSoftRelation && x.Table == p).Select(s => $"x.{s.PrincipalKey}== instance.{s.ForeignKey}"))}).Count()==0)
            {{
                throw new InvalidOperationException(""کد وارد شده برای '{{0}}' صحیح نمی باشد"");
            }}"
            );
            
            StringBuilder builder = new StringBuilder();
            builder.Append($@"
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Infrastructure.Interfaces.{data.Schema};
using ArvinERP.Infrastructure.Repositories.Base;");

            foreach (var item in data.Relations.Where(x => x.IsSoftRelation))
            {
                builder.Append($"\nusing ArvinERP.Infrastructure.Repositories.{item.Schema}");
            }
            builder.Append($@"
namespace ArvinERP.Infrastructure.Repositories.{data.Schema}
{{
    public class {data.Table}Repository :{(data.Inherited ? $" BaseRepository<{data.Table}, {data.KeyType}>," : "")} I{data.Table}Repository
    {{
");
            princtables.ForEach(x => builder.Append($"\t\tprivate readonly {x}Repository {x.ToLower()}Repo;\r\n"));

            builder.Append($@"
        public {data.Table}Repository(ArvinContext repositoryContext {string.Join("", pincRepos)}) {(data.Inherited ? ": base(repositoryContext)" : "")}
        {{");
            princtables.ForEach(x => builder.Append($"\nthis.{x.ToLower()}Repo = {x.ToLower()}Repo;"));

            builder.Append($@"
        }}");
            builder.Append($@"

        protected override Task BeforeCreate({data.Table} instance)
        {{
            {string.Join("", overrides)}
            return base.BeforeCreate(instance);
        }}
        protected override Task BeforeEdit({data.Table} instance)
        {{
            {string.Join("", overrides)}
            return base.BeforeEdit(instance);
        }}
    }}
}}
                            ");
            return builder.ToString();

        }


        public string GetIService()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($@"
using ArvinERP.Application.Services.Base;
using ArvinERP.Domain.DTOs.{data.Schema};
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Domain.ViewModels.{data.Schema};

namespace ArvinERP.Application.Interfaces.{data.Schema}
{{
    public interface I{data.Table}Service {(data.Inherited ? $": IBaseService<{data.Table}, {data.Table}Dto, {data.Table}ViewModel, {data.KeyType}>" : "")}
    {{
    }}
}}
                            ");
            return builder.ToString();

        }


        public string GetService()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($@"
using ArvinERP.Application.Interfaces.{data.Schema};
using ArvinERP.Domain.DTOs.{data.Schema};
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Domain.ViewModels.{data.Schema};
using ArvinERP.Infrastructure.Interfaces.{data.Schema};
using AutoMapper;


namespace ArvinERP.Application.Services.{data.Schema}
{{
    public class {data.Table}Service : {(data.Inherited ? $"Base.BaseService<{data.Table}, {data.Table}Dto, {data.Table}ViewModel, {data.KeyType}>, " : "")}I{data.Table}Service
    {{
        public {data.Table}Service(I{data.Table}Repository repository, IMapper mapper) {(data.Inherited ? ": base(repository, mapper)" : "")}
        {{
            
        }}
    }}
}}
                            ");
            return builder.ToString();

        }

        public string GetController()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(
$@"
using Microsoft.AspNetCore.Mvc;
using ArvinERP.API.Attributes;
using ArvinERP.Domain.DTOs.{data.Schema};
using ArvinERP.Domain.Models.{data.Schema};
using ArvinERP.Domain.ViewModels.{data.Schema};
using ArvinERP.Application.Interfaces.{data.Schema};

namespace ArvinERP.API.Controllers.{data.Schema}
{{
    [Route(""api/{data.Schema}/[controller]"")]
    [ApiController]
    [Controllers(""{data.Schema}"", ""{data.Table}"", ""{data.TableCaption}"", 0)]
    public class {data.Table}Controller {(data.Inherited ? $": Base.BaseController<{data.Table}, {data.Table}Dto, {data.Table}ViewModel, {data.KeyType}>" : "")}
    {{
        private readonly I{data.Table}Service _service; 
        public {data.Table}Controller(I{data.Table}Service service) {(data.Inherited ? $": base(service)" : "")}
        {{
            _service = service;
        }}

         {(data.Inherited && !data.HasYear ? @"
        [NonAction]
        public override Task<ActionResult> IndexByYear(int year)
        {
            return base.IndexByYear(year);
        }" : "")}
    }}
}}
                            ");
            return builder.ToString();

        }

        public List<string> GetResxResources()
        {
            var result = new List<string>();
            foreach (var item in data.Resources)
            {
                result.Add($"<data name=\"{data.Table}_{item.Name}\" xml:space=\"preserve\">\r\n    <value>{item.Value}</value>\r\n  </data>\r\n");
            }
            result.Add($"<data name=\"{data.Table}\" xml:space=\"preserve\">\r\n    <value>{data.TableCaption}</value>\r\n  </data>\r\n");
            return result;
        }
        public List<string> GetDesignerResources()
        {
            var result = new List<string>();
            foreach (var item in data.Resources)
            {
                result.Add(@$"
        /// <summary>
        ///   Looks up a localized string similar to {item.Value}.
        /// </summary>
        public static string {data.Table}_{item.Name} {{
            get {{
                return ResourceManager.GetString(""{data.Table}_{item.Name}"", resourceCulture);
            }}
        }}
    ");
            }

            result.Add(@$"
        /// <summary>
        ///   Looks up a localized string similar to {data.TableCaption}.
        /// </summary>
        public static string {data.Table} {{
            get {{
                return ResourceManager.GetString(""{data.Table}"", resourceCulture);
            }}
        }}
    ");
            return result;
        }

        public string GetResxTemplate()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(@$"<?xml version=""1.0"" encoding=""utf-8""?>
<root>
  <!-- 
    Microsoft ResX Schema 
    
    Version 2.0
    
    The primary goals of this format is to allow a simple XML format 
    that is mostly human readable. The generation and parsing of the 
    various data types are done through the TypeConverter classes 
    associated with the data types.
    
    Example:
    
    ... ado.net/XML headers & schema ...
    <resheader name=""resmimetype"">text/microsoft-resx</resheader>
    <resheader name=""version"">2.0</resheader>
    <resheader name=""reader"">System.Resources.ResXResourceReader, System.Windows.Forms, ...</resheader>
    <resheader name=""writer"">System.Resources.ResXResourceWriter, System.Windows.Forms, ...</resheader>
    <data name=""Name1""><value>this is my long string</value><comment>this is a comment</comment></data>
    <data name=""Color1"" type=""System.Drawing.Color, System.Drawing"">Blue</data>
    <data name=""Bitmap1"" mimetype=""application/x-microsoft.net.object.binary.base64"">
        <value>[base64 mime encoded serialized .NET Framework object]</value>
    </data>
    <data name=""Icon1"" type=""System.Drawing.Icon, System.Drawing"" mimetype=""application/x-microsoft.net.object.bytearray.base64"">
        <value>[base64 mime encoded string representing a byte array form of the .NET Framework object]</value>
        <comment>This is a comment</comment>
    </data>
                
    There are any number of ""resheader"" rows that contain simple 
    name/value pairs.
    
    Each data row contains a name, and value. The row also contains a 
    type or mimetype. Type corresponds to a .NET class that support 
    text/value conversion through the TypeConverter architecture. 
    Classes that don't support this are serialized and stored with the 
    mimetype set.
    
    The mimetype is used for serialized objects, and tells the 
    ResXResourceReader how to depersist the object. This is currently not 
    extensible. For a given mimetype the value must be set accordingly:
    
    Note - application/x-microsoft.net.object.binary.base64 is the format 
    that the ResXResourceWriter will generate, however the reader can 
    read any of the formats listed below.
    
    mimetype: application/x-microsoft.net.object.binary.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
            : and then encoded with base64 encoding.
    
    mimetype: application/x-microsoft.net.object.soap.base64
    value   : The object must be serialized with 
            : System.Runtime.Serialization.Formatters.Soap.SoapFormatter
            : and then encoded with base64 encoding.

    mimetype: application/x-microsoft.net.object.bytearray.base64
    value   : The object must be serialized into a byte array 
            : using a System.ComponentModel.TypeConverter
            : and then encoded with base64 encoding.
    -->
  <xsd:schema id=""root"" xmlns="""" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:msdata=""urn:schemas-microsoft-com:xml-msdata"">
    <xsd:import namespace=""http://www.w3.org/XML/1998/namespace"" />
    <xsd:element name=""root"" msdata:IsDataSet=""true"">
      <xsd:complexType>
        <xsd:choice maxOccurs=""unbounded"">
          <xsd:element name=""metadata"">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name=""value"" type=""xsd:string"" minOccurs=""0"" />
              </xsd:sequence>
              <xsd:attribute name=""name"" use=""required"" type=""xsd:string"" />
              <xsd:attribute name=""type"" type=""xsd:string"" />
              <xsd:attribute name=""mimetype"" type=""xsd:string"" />
              <xsd:attribute ref=""xml:space"" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name=""assembly"">
            <xsd:complexType>
              <xsd:attribute name=""alias"" type=""xsd:string"" />
              <xsd:attribute name=""name"" type=""xsd:string"" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name=""data"">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name=""value"" type=""xsd:string"" minOccurs=""0"" msdata:Ordinal=""1"" />
                <xsd:element name=""comment"" type=""xsd:string"" minOccurs=""0"" msdata:Ordinal=""2"" />
              </xsd:sequence>
              <xsd:attribute name=""name"" type=""xsd:string"" use=""required"" msdata:Ordinal=""1"" />
              <xsd:attribute name=""type"" type=""xsd:string"" msdata:Ordinal=""3"" />
              <xsd:attribute name=""mimetype"" type=""xsd:string"" msdata:Ordinal=""4"" />
              <xsd:attribute ref=""xml:space"" />
            </xsd:complexType>
          </xsd:element>
          <xsd:element name=""resheader"">
            <xsd:complexType>
              <xsd:sequence>
                <xsd:element name=""value"" type=""xsd:string"" minOccurs=""0"" msdata:Ordinal=""1"" />
              </xsd:sequence>
              <xsd:attribute name=""name"" type=""xsd:string"" use=""required"" />
            </xsd:complexType>
          </xsd:element>
        </xsd:choice>
      </xsd:complexType>
    </xsd:element>
  </xsd:schema>
  <resheader name=""resmimetype"">
    <value>text/microsoft-resx</value>
  </resheader>
  <resheader name=""version"">
    <value>2.0</value>
  </resheader>
  <resheader name=""reader"">
    <value>System.Resources.ResXResourceReader, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
  <resheader name=""writer"">
    <value>System.Resources.ResXResourceWriter, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089</value>
  </resheader>
</root>");
            return builder.ToString();
        }

        public string GetDesignerTemplate()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(@$"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArvinERP.Domain.Resources {{
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute(""System.Resources.Tools.StronglyTypedResourceBuilder"", ""17.0.0.0"")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class {data.Schema} {{
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute(""Microsoft.Performance"", ""CA1811:AvoidUncalledPrivateCode"")]
        internal {data.Schema}() {{
        }}
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {{
            get {{
                if (object.ReferenceEquals(resourceMan, null)) {{
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager(""ArvinERP.Domain.Resources.{data.Schema}"", typeof({data.Schema}).Assembly);
                    resourceMan = temp;
                }}
                return resourceMan;
            }}
        }}
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {{
            get {{
                return resourceCulture;
            }}
            set {{
                resourceCulture = value;
            }}
        }}
    }}
}}
");

            return builder.ToString();
        }

        public string GetDeleteOverride(string principal, bool alreadyHas= false)
        {
            var x = data.Relations.FirstOrDefault(x => x.Table == principal);
            var checker = "";
            if (x == null)
                return null;
            var result = !alreadyHas ? $"\t\tprotected override Task BeforeDelete({x.Table} instance)\r\n        {{" : "";
            switch (x.DeleteBahavior)
            {
                case DeleteBahavior.NoAction:
                    if (x.RelationType == RelationType.One2One)
                        checker = $"IsDeleted_";
                    else
                        checker = $"Any(x => !x.IsDeleted_ {(data.HasYear ? "&& (instance.Year ==0 || x.Year == instance.Year)" : "")})";
                    return result + $@"
            if (instance.{data.Table}.{checker})
            {{
                throw new InvalidOperationException(""این رکورد دارای رکوردهای وابسته در '{data.TableCaption}' می باشد.ابتدا رکوردهای وابسته را حذف کنید"");
            }}
            {(alreadyHas?"": "return base.BeforeDelete(instance);\r\n        }\r\n")}";
                    break;
                case DeleteBahavior.Cascade:
                    return result + $@"       
            {(x.RelationType == RelationType.One2One ? $"instance.{data.Table}.IsDeleted_= true" : "")}
            {(x.RelationType != RelationType.One2One ? $@"instance.{data.Table}.Where(x=> !x.IsDeleted_ && (instance.Year == 0 || x.Year == instance.Year)).ToList()
                .ForEach(x=> x.IsDeleted_= true);" : "")}
            {(alreadyHas ? "" : "return base.BeforeDelete(instance);\r\n        }\r\n")}";
                    break;
                case DeleteBahavior.SetNull:
                    return result + $@"
            {(x.RelationType == RelationType.One2One ? $"instance.{data.Table}.{x.ForeignKey}= null" : "")}
            {(x.RelationType != RelationType.One2One ? $@"instance.{data.Table}.Where(x=> !x.IsDeleted_ && (instance.Year == 0 || x.Year == instance.Year)).ToList()
                .ForEach(x=> x.{x.ForeignKey} = null);" : "")}
            {(alreadyHas ? "" : "return base.BeforeDelete(instance);\r\n        }\r\n")}";
                    break;
                default:
                    break;
            }

            return "";
        }

       
    }
}
