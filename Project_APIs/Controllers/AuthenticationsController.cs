//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Newtonsoft.Json;
//using Project_APIs.Db_contexts;
//using Project_APIs.Models.MetaModel;

//namespace Project_APIs.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AuthenticationsController : ControllerBase
//    {
//        private readonly ProductDBContext _context;

//        public AuthenticationsController(ProductDBContext context)
//        {
//            _context = context ?? throw new ArgumentNullException(nameof(context));
//        }

//        [HttpPost]
//        public IActionResult Register([FromBody]RegisterMetaModel registerMetaModel)
//        {
//            /* Hashing and stuff */
//            // make a new byte array
//            byte[] salt = new byte[16];

//            // Generate salt
//            // GetBytes: places the bytes in the array given
//            new RNGCryptoServiceProvider().GetBytes(salt); // this is void

//            // Hash and salt the password using PBKDF2
//            // 10000 represents the number of iterations the algorithm is going to perform
//            // It will keep hashing the previous hash this number of times. This is what makes it slower by design.
//            // Hashing
//            var pbkdf2 = new Rfc2898DeriveBytes(registerMetaModel.Password, salt, 100000);

//            // place the bytes in hash array
//            byte[] hash = pbkdf2.GetBytes(20);

//            // Make new byte array where to store the hashed password + salt
//            // 36: 20 for hash and 16 for salt
//            byte[] hashBytes = new byte[36];

//            // Place the hash and salt in their respective places
//            Array.Copy(salt, 0, hashBytes, 0, 16);
//            Array.Copy(hash, 0, hashBytes, 16, 20);

//            // Convert byte array to a string
//            string hashedPassword = Convert.ToBase64String(hashBytes);

//            var draft = new RegisterMetaModel
//            {
//                Username = registerMetaModel.Username,
//                Password = hashedPassword
//            };

//            _context.User.Add(draft);
//            _context.SaveChanges();

//            return this.Ok();
//        }
//    }
//}