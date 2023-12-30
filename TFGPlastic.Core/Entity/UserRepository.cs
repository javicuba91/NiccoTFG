using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Core.Entity.User.User;

namespace TFGPlastic.Core.Entity
{
    public class UserRepository : IUserRepository
    {

        /*private List<usuario> _users; // Lista en memoria para almacenar usuarios

        public UserRepository()
        {
            _users = new List<usuario>();
            _users.Add(new usuario(new Guid(), "nicolas.simarro", "Nicosima_111"));
        }
        
        public void AddUser(usuario user)
        {
            _users.Add(user);
        }

        public usuario GetUserById(Guid userId)
        {
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public usuario GetUserByName(string userName)
        {
            return _users.FirstOrDefault(u => u.Name == userName);
        }

        public List<usuario> GetAllUsers()
        {
            return _users.ToList();
        }

        public void UpdateUser(usuario user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                //Actualiza el usuario existente con los datos del nuevo usuario.
                existingUser.UpdateName(user.Name);
                existingUser.UpdatePassword(user.Password);
            }
        }

        public void DeleteUser(Guid userId)
        {
            var userToDelete = _users.FirstOrDefault(u => u.Id == userId);
            if (userToDelete != null)
            {
                _users.Remove(userToDelete);
            }
        }

        public bool ValidateLog(string userName, string password)
        {
           return _users.Exists(u=>string.Equals(u.Name.ToLower(),userName.ToLower())&& string.Equals(u.Password, password));
        }*/
    }
}
