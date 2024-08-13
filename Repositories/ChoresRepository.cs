namespace choresData.Repositories;
public class ChoresRepository
{
    private readonly IDbConnection _db;
    public ChoresRepository(IDbConnection db)
    {
        _db = db;
    }

    public List<Chores> GetAllChores()
    {
        string sql = "SELECT * FROM chores;";

        List<Chores> chores = _db.Query<Chores>(sql).ToList();
        return chores;
    }
}