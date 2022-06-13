using Blazored.LocalStorage;
using OnlineBookShopWeb.Contracts;
using OnlineBookShopWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OnlineBookShopWeb.Service
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;

        public BookRepository(IHttpClientFactory client,
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }
    }
}
