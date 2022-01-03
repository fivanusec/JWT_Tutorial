namespace OrganizeAsp.Services
{
    using OrganizeAsp.Models;
    using OrganizeAsp.Entities;

    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
