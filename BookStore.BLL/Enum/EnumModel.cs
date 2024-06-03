using System.ComponentModel;

namespace BookStore.BLL.Enum
{
    public enum ResponseError
    {
        [Description("NoError")]
        NoError = 0,

        #region BOOK
        [Description("Error in get all books")]
        ErrorGetAllBook = 1000,
        [Description("Error in get best seller books")]
        ErrorGetBestSellerBook = 1001,
        [Description("Error in get book by category url")]
        ErrorGetBookByCategoryUrl = 1002,
        [Description("Error in get book by book url")]
        ErrorGetBookDetailByUrl = 1003,
        [Description("Could not find book by book url")]
        CouldNotFindBookByUrl = 1004,
        [Description("Error in add book, your book url is existed")]
        ErrorInAddBookExistedUrl = 3005,
        #endregion

        #region Cart
        [Description("Error in get cart")]
        ErrorGetCart = 2000,
        [Description("Error Could not found cart item")]
        CouldNotFoundCartItem = 2001,
        [Description("Error in add to cart")]
        ErrorAddToCartCart = 2002,
        [Description("Error in update cart")]
        ErrorInUpdateCart = 2003,
        [Description("Error not enought quantity in stock when add to cart")]
        NotEnoughtQuantityInStockWhenAddToCart = 2004,
        #endregion

        #region Category
        [Description("Error in get all category")]
        ErrorGetAllCategory = 3000,
        [Description("Error in add category")]
        ErrorInAddCategory = 3001,
        [Description("Error in find category by url")]
        ErrorInFindCategoryByUrl = 3002,
        [Description("Error in find category by id")]
        ErrorInFindCategoryById = 3003,
        [Description("Error in delete category by id")]
        ErrorInDeleteCategoryById = 3003,
        [Description("Error in add category, your url is existed")]
        ErrorInAddCategoryExistedUrl = 3004,
        #endregion

        #region User
        [Description("Error get all users")]
        ErrorGetAllUsers = 4000,
        [Description("Error get user by id")]
        ErrorGetUserById = 4001,
        [Description("Error in add new user")]
        ErrorInAddNewUser = 4002,
        [Description("Error in delete user by user id")]
        ErrorInDeleteUserByUserId= 4003,
        #endregion

        #region Order
        [Description("Error to get all user orders")]
        ErrorInGetAllUserOrders = 5000,
        [Description("Failed to submit order")]
        FailedToSubmitOrder = 5001,
        [Description("Failed to get order detail by order id")]
        FailedToGetOrderDetailByOrderId = 5001,
        #endregion

        #region Authentication
        [Description("In correct Password")]
        InCorrectPassword = 6000,
        [Description("Could not find user by user name")]
        CouldNotFindUserByUserName = 6001,
        [Description("Error in login")]
        ErrorInLogin = 6002,
        [Description("Your login session is expired, please login again")]
        ExpiredAuthentication = 6003,
        #endregion

        #region Role
        [Description("Error in get role")]
        ErrorInGetRole = 7000,
        [Description("Could Not Find Role By Role Name")]
        CouldNotFindRoleByRoleName = 7001,
        #endregion

        #region JWT
        [Description("Expired Token")]
        ExpiredToken = 8000,
        [Description("Error in validate token")]
        ErrorInValidateToken = 8001,
        [Description("Token is empty")]
        TokenIsEmpty = 8002,
        #endregion
    }

    public enum OrderStatus
    {
        [Description("NORMAL")]
        Normal = 0,
        [Description("FAILED")]
        Failed = 1,
        [Description("SUCCESS")]
        Success = 2,
        [Description("PENDING")]
        Pending = 3,
    }

    public enum ShippingMethod
    {
        [Description("Standard")]
        Standard = 0,
        [Description("Fast")]
        Fast = 1,
        [Description("Express")]
        Express = 3,
    }

    public enum PaymentMethod
    {
        [Description("Cash Payment On Delivery (Ship COD)")]
        COD = 0,
        [Description("Pay with international cards Visa/Master/JCB")]
        Card = 1,
    }
}
