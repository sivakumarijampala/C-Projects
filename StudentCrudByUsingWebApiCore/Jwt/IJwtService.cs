namespace StudentCrudByUsingWebApiCore.Jwt
{
    public interface IJwtService
    {
        string authenticate(string username, string password);
    }
}
