using BoockAPI.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoockAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);
        Task<Book> Ceate(Book book);
        Task Update(Book book);
        Task Delete(int id);
    }
}
