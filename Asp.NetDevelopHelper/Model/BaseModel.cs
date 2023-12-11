using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.Model
{
    public class BaseModel
    {
        public string Schema { get; set; }
        public string Table { get; set; }
        public string TableCaption { get; set; }
        public bool Inherited { get; set; }
        public string? KeyType { get; set; }
        public string ProjectPath { get; set; }
        public bool HasYear { get; set; }
        public string YearName { get; set; }
        public List<Property> Properties { get; set; } = new List<Property>();
        public List<List<string>> UniqueIndexes { get; set; } = new List<List<string>>();
        public List<Relation> Relations { get; set; } = new List<Relation>();
        public List<Resource> Resources { get; set; } = new List<Resource>();

        public bool CreateModel { get; set; }
        public bool CreateDto { get; set; }
        public bool CreateViewModel { get; set; }
        public bool CreateMapping { get; set; }
        public bool CreateRepository { get; set; }
        public bool CreateService { get; set; }
        public bool CreateController { get; set; }
        public bool CreateResources { get; set; }
        public bool CreateContextDbset { get; set; }
        public bool CreateRelations { get; set; }
    }
}
