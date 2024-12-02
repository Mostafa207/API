using API.Date;
using API.DTO;
using API.Models;

namespace API.Repo.signupR
{
    public class signupRepo: IsignupRepo
    {
        private readonly Appdbcontext context;

        public signupRepo(Appdbcontext context)
        {
            this.context = context;
        }

        public void Add(SignUpDTO signupDTO)
        {
            
            var user = new Users
            {
                FristName = signupDTO.FristName,
                LastName = signupDTO.LastName,
                Age = signupDTO.Age,
                Email = signupDTO.Email,
                Password = HashPassword(signupDTO.Password), 
                Phone = signupDTO.Phone,
                Location = signupDTO.Location
            };

            
            context.Users.Add(user);
            context.SaveChanges(); 
        }

       
        private string HashPassword(string password)
        {
            
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));
        }
    
    }
}
