using Core.Dao.VO;
using Core.Entities.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dao.Interfaces
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User RefreshUserInfo(User user);


    }
}
