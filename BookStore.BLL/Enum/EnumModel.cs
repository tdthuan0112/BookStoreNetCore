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
        #endregion
    }
}
