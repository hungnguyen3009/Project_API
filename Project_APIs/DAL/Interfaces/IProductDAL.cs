using Project_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.DAL.Interfaces
{
    public interface IProductDAL
    {
        void Insert(Product product);
        void Update(int id, Product product);
        void Delete(int id);
        Product GetById(int id);
        List<Product> GetAll();
    }
}
