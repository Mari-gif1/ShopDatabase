 using AutoMapper;
using BookShopApiLayer.Models;
using DataAccessLayer.Models;

namespace BookShopApiLayer
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserModel, User>();
            CreateMap<User, UserModel>();
            CreateMap<UserSignIn, UserLogin>();
            CreateMap<UserLogin, UserSignIn>();
            CreateMap<BookModel, Books>();
            CreateMap<Books, BookModel>();
        }
    }
}
