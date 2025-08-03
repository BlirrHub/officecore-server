using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }
    [Required] 
    public string FirstName { get; set; }
    [Required] 
    public string LastName { get; set; }
    public DateOnly BirthDay { get; set; }
    [EmailAddress]
    public string EmailAddress { get; set; }
    [Required] [Phone]
    public string PhoneNumber { get; set; }
    [Required] 
    public DateOnly DateHired { get; set; }
    [Required] 
    public DateTime CreatedAt { get; set; }

    [Required]
    public int PositionId { get; set;}
    [Required]
    public Position Position { get; set; }

    [Required]
    public int RoleId {get; set; }
    [Required]
    public required Role Role { get; set; }

    [Required]
    public User User { get; set; }
}