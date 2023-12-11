using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.NetDevelopHelper.Model
{
    public class Relation
    {
        public string Schema { get; set; }
        public string Table { get; set; }
        public string PrincipalKey { get; set; }
        public string ForeignKey { get; set; }
        public RelationType RelationType { get; set; }
        public DeleteBahavior DeleteBahavior { get; set; }
        public bool IsSoftDelete { get; set; }
        public bool IsSoftRelation { get; set; }
    }

    public enum RelationType
    {
        One2Many,
        One2One,
        Many2Many
    }
    public enum DeleteBahavior
    {
        NoAction,
        Cascade,
        SetNull,
    }
}
