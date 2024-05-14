using System.ComponentModel;

namespace BookStore.DAL.Enum
{
    public class EnumCommon
    {
    }

    public enum Sexes
    {
        [Description("Mr/Mrs")]
        Undefined = -1,
        [Description("Mrs.")]
        Female = 0,
        [Description("Mr.")]
        Male = 1,
    }
}
