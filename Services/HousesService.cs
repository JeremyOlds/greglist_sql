

namespace greglist_sql.Services;

    public class HousesService
    {
            private readonly HousesRepository _housesRepository;

    public HousesService(HousesRepository housesRepository)
    {
        _housesRepository = housesRepository;
    }



    internal List<House> GetHouses()
    {
        List<House> houses = _housesRepository.GetHouses();
        return houses;
    }
    internal House GetHouseById(int houseId)
    {
        House house = _housesRepository.GetHouseById(houseId);

    if (house == null)
    {
        throw new Exception($"{houseId} is not a valid ID");
    }


        return house;
    }

    internal House CreateHouse(House houseData)
    {
        int houseId = _housesRepository.CreateHouse(houseData);
        House house = GetHouseById(houseId);
        return house;
    }

    internal void RemoveHouse(int houseId)
    {
        House house = GetHouseById(houseId);
        _housesRepository.RemoveHouse(houseId);
        
    }

    internal House UpdateHouse(int houseId, House houseData)
    {
        House originalHouse = GetHouseById(houseId);

        originalHouse.Bedrooms = houseData.Bedrooms ?? originalHouse.Bedrooms;
        originalHouse.Bathrooms = houseData.Bathrooms ?? originalHouse.Bathrooms;
        originalHouse.Levels = houseData.Levels ?? originalHouse.Levels;
        originalHouse.Description = houseData.Description ?? originalHouse.Description;
        originalHouse.Price = houseData.Price ?? originalHouse.Price;

        House house = _housesRepository.UpdateHouse(originalHouse);

        return house;
    }
}
