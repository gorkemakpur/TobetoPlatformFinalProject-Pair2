namespace Business.Dtos.District.Request;

public class CreateDistrictRequest
{
    public Guid CityId { get; set; }
    public string Name { get; set; }
}