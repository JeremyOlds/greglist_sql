

namespace greglist_sql.Repositories;

public class HousesRepository
    {
        private readonly IDbConnection _db;

    public HousesRepository(IDbConnection db)
    {
        _db = db;
    }
    internal List<House> GetHouses()
    {
    string sql = "SELECT * FROM houses;";

    List<House> houses = _db.Query<House>(sql).ToList();

    return houses;

    }
    internal House GetHouseById(int houseId)
    {
    string sql = $"SELECT * FROM houses WHERE id = @houseId;";


    House House = _db.QueryFirstOrDefault<House>(sql, new { houseId });

    return House;

    }

    internal int CreateHouse(House houseData)
    {
        string sql = @"INSERT INTO houses (    bathrooms, bedrooms, price, levels, description)
        VALUES (@Bathrooms, @Bedrooms, @Price, @Levels, @Description);
        SELECT LAST_INSERT_ID()
        ;";

        int houseId = _db.ExecuteScalar<int>(sql, houseData);
        return houseId;

    }

    internal void RemoveHouse(int houseId)
    {
        string sql = "DELETE FROM houses WHERE id = @houseId LIMIT 1";
        _db.Execute(sql, new {houseId});
    }

    internal House UpdateHouse(House originalHouse)
    {
        string sql = @"
        UPDATE houses
        SET
        bedrooms = @Bedrooms,
        bathrooms = @Bathrooms,
        levels = @Levels,
        price = @Price,
        description = @Description
        WHERE id = @Id LIMIT 1;
        SELECT * FROM houses WHERE id = @Id
        ;";

        House updatedHouse = _db.QueryFirstOrDefault<House>(sql, originalHouse);
        return updatedHouse;
    }
}
