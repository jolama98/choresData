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

    public Chores GetChoresById(int choresId)
    {
        string sql = "SELECT * FROM chores WHERE id = @choresId;";

        Chores chores = _db.Query<Chores>(sql, new { choresId = choresId }).FirstOrDefault();
        return chores;
    }

    public Chores CreateChores(Chores choresData)
    {
        string sql = @"
        INSERT INTO
        chores (name, description, isComplete)
        VALUES (@Name, @Description, @IsComplete);

        SELECT * FROM chores WHERE id = LAST_INSERT_ID();";

        Chores chores = _db.Query<Chores>(sql, choresData).FirstOrDefault();
        return chores;
    }

    public void DeleteChores(int choresId)
    {
        string sql = "DELETE FROM chores WHERE id = @choresIs LIMIT 1;";
        int rowsAffected = _db.Execute(sql, new { choresId });

        if (rowsAffected == 0)
        {
            throw new Exception("DELETE WAS A NO GO");
        }

        if (rowsAffected > 1)
        {
            throw new Exception("DELETE WAS OVER POWERED");
        }
    }
}