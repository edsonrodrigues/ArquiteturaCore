using Core.Dao.Interfaces;
using Core.Dao.VO;
using Core.Entities.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Core.Dao
{
    public class UserRepository : IUserRepository
    {
        private readonly Contexto _contexto;

        public UserRepository(Contexto contexto)
        {
            _contexto = contexto;
        }

        public User ValidateCredentials(UserVO user)
        {
            var pass = ComputeHash(user.Password, new SHA256CryptoServiceProvider());
            IList<User> lst = _contexto.Users.ToList();
            return _contexto.Users.FirstOrDefault(u => (u.UserName == user.UserName) && (u.Password == pass));
        }

        private string ComputeHash(string input, SHA256CryptoServiceProvider algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);
            return BitConverter.ToString(hashedBytes);

        }

        public User RefreshUserInfo(User user)
        {
            if (!_contexto.Users.Any(u => u.Id.Equals(user.Id))) return null;

            var result = _contexto.Users.FirstOrDefault(u => u.Id.Equals(user.Id));
            if (result != null)
            {
                try
                {
                    _contexto.Entry(result).CurrentValues.SetValues(user);
                    _contexto.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {

                    throw;
                }


            }
            return result;

        }
    }
}
