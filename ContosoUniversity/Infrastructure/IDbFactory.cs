namespace ContosoUniversity.Infrastructure
{
    public interface IDbFactory
    {
        Db NewDb();
    }
}
