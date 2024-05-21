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
        /// <summary>
        /// System Error Message
        /// </summary>
        public string SystemErrorMessage { get; set; }
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
                    this.Message = "Some thing went wrong. Please try again later!";
                    this.ErrorMessage = responseError.ToErrorMessage();
                }
                else
                {
                    this.Message = "Success";
                }
            }
        }

        public void SetResponseError(BaseResponseErrorModel responseModel)
        {
            if (this != null)
            {
                if (responseModel.ResponseError.HasError())
                {
                    this.Code = (int)responseModel.ResponseError;
                    this.Message = "Some thing went wrong. Please try again later!";
                    this.ErrorMessage = responseModel.ResponseError.ToErrorMessage();
                    this.SystemErrorMessage = responseModel.SystemErrorMessage;
                }
                else
                {
                    this.Message = "Success";
                }
            }
        }
    }

    public class BaseResponseErrorModel
    {
        public ResponseError ResponseError { get; set; } = ResponseError.NoError;
        public string SystemErrorMessage { get; set; }
        public void SetErrorModel(ResponseError responseError, string systemErrorMessage = "")
        {
            this.ResponseError = responseError;
            this.SystemErrorMessage = systemErrorMessage;
        }
    }
}
