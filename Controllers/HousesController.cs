

namespace greglist_sql.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HousesController : ControllerBase
{
    private readonly HousesService _housesService;

    public HousesController(HousesService housesService)
    {
        _housesService = housesService;
    }


    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
    try
    {
        List<House> houses = _housesService.GetHouses();
        return Ok(houses);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
    }

    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId)
    {
    try
    {
        House House = _housesService.GetHouseById(houseId);
        return Ok(House);
    }
    catch (Exception e)
    {
        return BadRequest(e.Message);
    }
    }
    [HttpPost]
    public ActionResult<House> CreateHouse([FromBody] House houseData)
    {
        try
        {
            House house = _housesService.CreateHouse(houseData);
            return Ok(house);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }
    [HttpDelete("{houseId}")]
    public ActionResult<string> RemoveHouse(int houseId)
    {
        try
        {
            _housesService.RemoveHouse(houseId);
            return Ok("House was Removed.");
        }
        catch (Exception e) 
        {
            
            return BadRequest(e.Message);
        }
    }
    [HttpPut("{houseId}")]
    public ActionResult<House> UpdateHouse(int houseId, [FromBody] House houseData)
    {
        try
        {
            House house = _housesService.UpdateHouse(houseId, houseData);
            return Ok(house);
        }
        catch (Exception e)
        {
            
            return BadRequest(e.Message);
        }
    }
}


