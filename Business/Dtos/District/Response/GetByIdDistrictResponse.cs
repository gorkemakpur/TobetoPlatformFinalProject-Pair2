namespace Business.Dtos.District.Response;

public class GetByIdDistrictResponse
{
    public Guid Id { get; set; }
    public Guid CityId { get; set; }
    public string Name { get; set; }
}