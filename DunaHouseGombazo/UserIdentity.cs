using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DunaHouseGombazo
{
    public partial class User
    {
        public static string HashAPassword(string password)
        {
            var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }
        public static User Create(string username, string fullname, string password, string email, string phone=null, bool canBrowse=true, bool canEdit=false, bool canImport=false, bool canExport=true)
        {

            var u = new User()
            {
                FullName = fullname,
                UserName = username,
                Password = HashAPassword(password),
                Email = email,
            };

            if (phone != null)
            {
                u.Phone = phone;
            }

            return u;
        }

        internal static User From(User matchedUser)
        {
            return new User()
            {
                FullName = matchedUser.FullName,
                Id = matchedUser.Id,
                Password = matchedUser.Password,
                UserName = matchedUser.UserName,
                IsAdmin = matchedUser.IsAdmin,
                Phone = matchedUser.Phone,
                Email = matchedUser.Email,
                CanEdit = matchedUser.CanEdit,
                CanExport = matchedUser.CanExport,
                CanImport = matchedUser.CanImport,
                CanView = matchedUser.CanView
            };
        }
    }
}
