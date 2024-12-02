using API.Date;
using API.DTO;
using API.Models;

namespace API.Repo.loginR
{
    public class loginRepo : IloginRepo
    {
        private readonly Appdbcontext context;

        public loginRepo(Appdbcontext context)
        {
            this.context = context;
        }

        public LoginDTO Get(LoginDTO loginDTO)
        {
            var user = context.Users
                .FirstOrDefault(u => u.Email == loginDTO.Email && u.Password == loginDTO.Password);

            if (user == null)
                return null;

            return new LoginDTO
            {
                Email = user.Email
               ,Password = user.Password
            };
        }
    }
}
