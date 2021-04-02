using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(String userName);

        bool RevokeToken(string userName);

        User RefreshUserInfo(User user);
    }
}
