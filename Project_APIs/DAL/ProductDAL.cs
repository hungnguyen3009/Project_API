using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project_APIs.DAL.Interfaces;
using Project_APIs.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.DAL
{
    public class ProductDAL : IProductDAL
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
