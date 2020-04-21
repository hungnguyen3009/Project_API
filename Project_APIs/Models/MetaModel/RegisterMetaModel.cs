using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_APIs.Models.MetaModel
{
    public class RegisterMetaModel
    {
        private string _username;
        private string _password;

        [Key]
        public string Username 
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password 
        {
            get 
            {
                return _password;
            } 
            set 
            {
                _password = value;
            } 
        }


    }
}
