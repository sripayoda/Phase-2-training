namespace JwtAuth.Services
{
    public interface IToken
    {
        string GenerateToken(string username, string role);
    }
}
