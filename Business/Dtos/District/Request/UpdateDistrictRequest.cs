namespace Business.Dtos.District.Request;

public class UpdateDistrictRequest
{
    public Guid Id { get; set; }
    public Guid CityId { get; set; }
    public string Name { get; set; }
}