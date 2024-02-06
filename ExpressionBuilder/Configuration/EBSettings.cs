using System.Collections.Generic;

namespace ExpressionBuilder.Configuration
{
    public class EBSettings
    {
        public EBSettings(List<SupportedType> _supportedTypes)
        {
            SupportedTypes = _supportedTypes;
        }
        public List<SupportedType> SupportedTypes { get; private set; }
    }
}