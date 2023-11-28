using Microsoft.IdentityModel.Tokens;
using StudentCrudByUsingWebApiCore.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudentCrudByUsingWebApiCore.Jwt
{
    public class JwtService : IJwtService
    {
        public UserRepo UserRepo { get; set; }
       
        public readonly IConfiguration configuration;
        public JwtService(IConfiguration configuration,UserRepo userRepo) { 
            this.configuration = configuration;
            UserRepo = userRepo;
        }
        public string authenticate(string email, string password)
        {
            IEnumerable<userDetails> userDetails=UserRepo.GetAllUserDetails();
            if(!userDetails.Any(x=>x.email.Equals(email) &&x.password.Equals(password)))
            {
                return null;
            }

            var key = configuration.GetValue<string>("JwtConfig:Key");
            var keybytes=Encoding.ASCII.GetBytes(key);
            var tokenhandler = new JwtSecurityTokenHandler();

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keybytes), SecurityAlgorithms.HmacSha256)


            };
            var token = tokenhandler.CreateToken(tokenDescriptor);
            return tokenhandler.WriteToken(token);

        }
    }
}
