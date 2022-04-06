using Microsoft.AspNetCore.Identity;
using Test_Series.Models;

namespace Test_Series.Repository
{
    public interface IAuthenticationRepository
    {
        Task<int> Logout();
        Task<SignInResult> SignIn(LoginModel loginModel);
        Task<IdentityResult> SignUp(SignUpViewModel signUpViewModel);
    }
}