using ExpressionBuilder.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Data
{
    public class UiDataFilter
    {
        public UiDataFilter() { }
        public UiDataFilter(string groupName, string name, string fieldName, object value)
        {
            this.GroupName = groupName;
            this.Name = name;
            this.FieldName = fieldName;
            Value = value;
        }
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string FieldName { get; set; }
        public object Value { get; set; }
    }
}
