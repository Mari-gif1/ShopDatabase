using OnlineBookShopWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookShopWeb.Contracts
{
    public interface IBookRepository : IBaseRepository<Book>
    {
    }
}
