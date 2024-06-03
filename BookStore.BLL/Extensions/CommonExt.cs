using BookStore.BLL.Enum;
using BookStore.BLL.Models;
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

        public static bool HasError(this BaseResponseErrorModel responseErrorModel)
        {
            return (responseErrorModel != null && (responseErrorModel.ResponseError.HasError() || responseErrorModel.SystemErrorMessage != string.Empty));
        }

        public static bool IsDigitsOnly(this string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
