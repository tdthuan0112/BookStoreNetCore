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
    }
}
