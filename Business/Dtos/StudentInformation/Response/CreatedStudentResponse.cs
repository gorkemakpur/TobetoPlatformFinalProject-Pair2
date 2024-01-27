namespace Business.Dtos.StudentInformation.Response;

public class CreatedStudentInformationResponse
{
    public Guid Id { get; set; }
    public Guid StudentId { get; set; }
    public Guid DistrictId { get; set; }

    public DateTime BirthDate { get; set; }
    public string NationalityId { get; set; }
    public int PhoneNumber { get; set; }
    public string About { get; set; }
    public string Country { get; set; }
    public string AddressDescription { get; set; }
}
