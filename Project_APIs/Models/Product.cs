using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private float _price;
        private bool _isDeleted;

        public int Id { 
            get 
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name { 
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            } 
        }

        public float Price { 
            get 
            {
                return _price;
            } 
            set 
            {
                _price = value;
            }
        }

        public bool IsDeleted {
            get 
            {
                return _isDeleted;
            }
            set
            {
                _isDeleted = value;
            }
        }
    }
}
