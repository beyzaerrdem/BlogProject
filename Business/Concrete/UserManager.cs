using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public List<User> GetList()
        {
            return _userDal.GetAllList();
        }

        public void TAdd(User user)
        {
            _userDal.Add(user);
        }

        public void TDelete(User user)
        {
            _userDal.Delete(user);
        }

        public void TUpdate(User user)
        {
            _userDal.Update(user);
        }
    }
}
