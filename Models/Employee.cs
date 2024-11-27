namespace AddressManager.Models;

public class Employee
{
    public int Id { get; set; }
    public int OrganizationId { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}
