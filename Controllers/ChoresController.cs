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
}