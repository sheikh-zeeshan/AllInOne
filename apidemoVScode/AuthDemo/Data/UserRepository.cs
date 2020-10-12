using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Data
{
    public interface IUserRepository
    {
        bool Login(string userName, string password);
    }
    public class UserRepository: IUserRepository
    {
        public bool Login(string userName, string password)
        {
            return true;
        }
    }
}
