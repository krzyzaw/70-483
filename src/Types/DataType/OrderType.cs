using System.ComponentModel;

namespace Types.DataType
{
    public enum OrderType
    {
        [Description("Standard order type.")]
        Standard = 1,

        [Description("Urgent order type.")]
        Urgent = 2,

        [Description("Warranty order type.")]
        Warranty = 3
    }
}