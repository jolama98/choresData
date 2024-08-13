namespace choresData.Services;
public class ChoresService
{
    private readonly ChoresRepository _choresRepository;
    public ChoresService(ChoresRepository choresRepository)
    {
        _choresRepository = choresRepository;
    }

    public List<Chores> GetAllChores()
    {
        List<Chores> chores = _choresRepository.GetAllChores();
        return chores;
    }

    public Chores GetChoresById(int choresId)
    {
        Chores chores = _choresRepository.GetChoresById(choresId);
        if (chores == null)
        {
            throw new Exception($"No Chores with Id of {choresId}");
        }
        return chores;
    }

    public Chores CreateChores(Chores choresData)
    {
        Chores chores = _choresRepository.CreateChores(choresData);
        return chores;
    }

    public string DeleteChores(int choresId)
    {
        Chores choresToDelete = GetChoresById(choresId);

        _choresRepository.DeleteChores(choresId);

        return $"The {choresToDelete.Description} was delete;";
    }
}
