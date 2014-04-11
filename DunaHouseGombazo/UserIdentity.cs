using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DunaHouseGombazo
{
    public class UserIdentity : User
    {

        public static User Create(string username, string fullname, string password, bool canBrowse=false, bool canEdit=false, bool canImport=false, bool canExport=false)
        {
            var sha1= SHA1.Create();
            var hash = sha1.ComputeHash( Encoding.UTF8.GetBytes(password));


            var u = new User()
            {
                FullName = fullname,
                UserName = username,
                Password = Convert.ToBase64String(hash)
            };

            return u;
        }

        internal static UserIdentity From(User matchedUser)
        {
            return new UserIdentity()
            {
                FullName = matchedUser.FullName,
                Id = matchedUser.Id,
                Password = matchedUser.Password,
                UserName = matchedUser.UserName
            };
        }
    }
}
