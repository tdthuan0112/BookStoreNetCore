using BookStore.BLL.Enum;
using BookStore.BLL.Extensions;

namespace BookStore.BLL.Models
{
    [Serializable]
    public class BaseResponseModel
    {
        /// <summary>
        /// Error code of the error
        /// 0: NoError
        /// != 0: HasError
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// ResponseMessage
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        public string ErrorMessage { get; set; }
        public dynamic Data { get; set; }
        public BaseResponseModel()
        {
            Code = 0;
            ErrorMessage = String.Empty;
        }
        public void SetResponseError(ResponseError responseError)
        {
            if (this != null)
            {
                if (responseError.HasError())
                {
                    this.Code = (int)responseError;
                    this.Message = "";
                    this.ErrorMessage = responseError.ToErrorMessage();
                }
                else
                {
                    this.Message = "Success";
                }
            }
        }
    }
}
