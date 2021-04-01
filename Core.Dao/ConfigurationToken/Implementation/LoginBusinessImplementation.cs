using Core.Dao.ConfigurationToken.Business;
using Core.Dao.Interfaces;
using Core.Dao.VO;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Dao.ConfigurationToken.Implementation
{
    public class LoginBusinessImplementation : ILoginBusiness

    {
        private const string DATE_FORMAT = "yyyy-MM-dd HH:mm:ss";
        private TokenConfiguration _configuraton;
        private IUserRepository _repository;
        private readonly ITokenService _tokenService;

        public LoginBusinessImplementation(TokenConfiguration configuraton, IUserRepository repository, ITokenService tokenService)
        {
            _configuraton = configuraton;
            _repository = repository;
            _tokenService = tokenService;
        }

        public TokenVO ValidateCredentials(UserVO userCredentials)
        {
            var user = _repository.ValidateCredentials(userCredentials);
            if (user == null) return null;
            var claims = new List<Claim>
            {
            new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString("N")),
            new Claim(JwtRegisteredClaimNames.UniqueName,user.UserName)
            };

            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(_configuraton.DaysToExpire);
           
            _repository.RefreshUserInfo(user);

            DateTime createDate = DateTime.Now;
            DateTime expirationDate = createDate.AddMinutes(_configuraton.Minutes);


            return new TokenVO
            (true,
            createDate.ToString(DATE_FORMAT),
            expirationDate.ToString(DATE_FORMAT),
            accessToken,
            refreshToken
                );
        }
    }
}
