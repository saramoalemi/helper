using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.Model
{
    public class Property
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Required { get; set; }
        public string? Maxlength { get; set; }
        public string? Minlength { get; set;}
        public string? Regex { get; set; }
        public bool IsKey { get; set; }
        public bool HasIndex { get; set; }
        public Relation Relation { get; set; }
    }
}
