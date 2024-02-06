using ExpressionBuilder.Common;
using ExpressionBuilder.Configuration;
using ExpressionBuilder.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvingCredit.Core
{
    public static class ExpressOperation
    {
        private static List<SupportedType> supportedTypes = new List<SupportedType>() {
                new SupportedType() { TypeGroup = TypeGroup.Date, Type=Type.GetType("System.DateTime", false, true) },
                new SupportedType() { TypeGroup = TypeGroup.Text, Type=Type.GetType("System.Text", false, true) },
                new SupportedType() { TypeGroup = TypeGroup.Number, Type=Type.GetType("System.Decimal", false, true) }
            };
        public static OperationHelper GlobalOperation = new OperationHelper(supportedTypes);
    }
}
