using Microsoft.AspNetCore.Identity;

namespace Test_Series.Repository
{
    public class AccountRepo:IdentityUser
    {
        public string Name { get; set; }
        public string LevelName { get; set; }
        public string Edition { get; set; }
    }
}
