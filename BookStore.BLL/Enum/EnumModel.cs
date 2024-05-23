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
        #endregion

        #region User
        [Description("Error get all users")]
        ErrorGetAllUsers = 4000,
        [Description("Error get user by id")]
        ErrorGetUserById = 4001,
        #endregion

        #region Order
        [Description("Error to get all user orders")]
        ErrorInGetAllUserOrders = 5000,
        [Description("Failed to submit order")]
        FailedToSubmitOrder = 5001,
        [Description("Failed to get order detail by order id")]
        FailedToGetOrderDetailByOrderId = 5001,
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
