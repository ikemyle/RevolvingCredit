using ExpressionBuilder.Common;
using ExpressionBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Data.DataFiltering
{
    public class DbFilter
    {
        public string PropertyName { get; set; }
        public object Value { get; set; }
        public object SecondValue { get; set; }
        public string DataType { get; set; }
        public IOperation Operation { get; set; }
        public Connector FilterConnector { get; set; } = Connector.Or;
    }
}
