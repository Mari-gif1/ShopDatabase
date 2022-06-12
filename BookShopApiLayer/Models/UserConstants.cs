using System.Collections.Generic;

namespace BookShopApiLayer.Models
{
    public class UserConstants
    {
        public static List<UserModel> users = new List<UserModel>()
        {
            new UserModel(){UserName = "Mari", Email = "mari.khachikyan@gmail.com", Password = "mari2022",
                GivenName = "Mari", Surname = "Khachikyan", Role = "Administrator"},
            new UserModel(){UserName = "Lilit", Email = "lilit.khachikyan@gmail.com", Password = "lilit2022",
                GivenName = "Lilit", Surname = "Khachikyan", Role = "Administrator"}
        };
    }
}
