using System.ComponentModel;

namespace BookStore.DAL.Enum
{
    public class EnumCommon
    {
    }

    public enum Sexes
    {
        [Description("Undifined")]
        Undefined = -1,
        [Description("Female")]
        Female = 0,
        [Description("Male")]
        Male = 1,
    }
}
