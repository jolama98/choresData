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
}
