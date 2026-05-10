using DAL.IRepo;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserDetailsRepo : IUserDetails
    {
        public readonly AppDb _appDb;
        public UserDetailsRepo(AppDb appDb)
        {
            _appDb = appDb;
        }
        public async Task<bool> AddUser(UserDetails userDetails)
        {
            try
            {
                await _appDb.UserDetails.AddAsync(userDetails);
                await _appDb.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> EditUser(UserDetails userDetails)
        {
            try
            {
                _appDb.UserDetails.Update(userDetails);
                await _appDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<UserDetails>> GetUserList()
        {
            var res = await _appDb.UserDetails.ToListAsync();
            return res;
        }
        public async Task<UserDetails> GetUser(int Id)
        {
            var res = await _appDb.UserDetails.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return res;

        }
    }
}
