using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IUserDetails
    {
        public Task<bool> AddUser(UserDetails userDetails);
        public Task<bool> EditUser(UserDetails userDetails);
        public Task<List<UserDetails>> GetUserList();
        public Task<UserDetails> GetUser(int Id);
    }
}
