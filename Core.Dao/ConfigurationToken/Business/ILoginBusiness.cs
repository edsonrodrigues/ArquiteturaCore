using Core.Dao.VO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Dao.ConfigurationToken.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
    }
}
