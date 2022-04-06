using Microsoft.AspNetCore.Identity;
using Test_Series.Models;

namespace Test_Series.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        private readonly SignInManager<AccountRepo> signInManager;
        private readonly UserManager<AccountRepo> userManager;

        public AuthenticationRepository(SignInManager<AccountRepo> signInManager, UserManager<AccountRepo> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public async Task<IdentityResult> SignUp(SignUpViewModel signUpViewModel)
        {
            AccountRepo accountRepo = new AccountRepo()
            {
                Name = signUpViewModel.FirstName +" " +signUpViewModel.Lastname,
                UserName = signUpViewModel.Email,
                Email = signUpViewModel.Email,
                PhoneNumber = signUpViewModel.Phone,
                LevelName = signUpViewModel.Level,
                Edition = signUpViewModel.Edition
            };
            var result = await userManager.CreateAsync(accountRepo, signUpViewModel.Password);
            return result;
        }

        public async Task<SignInResult> SignIn(LoginModel loginModel)
        {
            var result = await signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, loginModel.RememberMe, false);
            return result;
        }

        public async Task<int> Logout()
        {
            await signInManager.SignOutAsync();
            return 1;
        }
    }
}
