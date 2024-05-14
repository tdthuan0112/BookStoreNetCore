using BookStore.BLL.Enum;
using System.ComponentModel;
using System.Reflection;

namespace BookStore.BLL.Extensions
{
    public static class CommonExt
    {
        public static bool HasError(this ResponseError responseError)
        {
            return responseError != ResponseError.NoError;
        }

        public static string ToErrorMessage(this ResponseError enumValue)
        {
            return enumValue.ToDescription();
        }

        public static string ToDescription(this System.Enum enumValue)
        {
            return enumValue.GetType().GetMember(enumValue.ToString()).First()
                .GetCustomAttribute<DescriptionAttribute>()?.Description ?? string.Empty;
        }
    }
}
