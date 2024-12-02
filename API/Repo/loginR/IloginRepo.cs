using API.DTO;

namespace API.Repo.loginR
{
    public interface IloginRepo
    {
        public void Get(LoginDTO loginDTO);
        public void Add(LoginDTO loginDTO);

    }
}
