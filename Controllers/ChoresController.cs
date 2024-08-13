namespace choresData.Controllers;
[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }
    [HttpGet]

    public ActionResult<List<Chores>> GetAllChores()
    {
        try
        {

            List<Chores> chores = _choresService.GetAllChores();
            return Ok(chores);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

    [HttpGet("{choresId}")]
    public ActionResult<Chores> GetChoresById(int choresId)
    {
        try
        {
            Chores chores = _choresService.GetChoresById(choresId);
            return Ok(chores);
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }

    [HttpPost]
    public ActionResult<Chores> CreateChores([FromBody] Chores choresData)
    {
        try
        {
            Chores chores = _choresService.CreateChores(choresData);
            return Ok(chores);
        }
        catch (Exception exception)
        {

            return BadRequest(exception.Message);
        }
    }
    [HttpDelete("{choresId}")]
    public ActionResult<string> DeleteChores(int choresId)
    {
        try
        {
            string message = _choresService.DeleteChores(choresId);
            return Ok(message);
        }
        catch (Exception exception)
        {

            return BadRequest(exception.Message);
        }
    }
}