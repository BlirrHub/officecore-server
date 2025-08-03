using System.ComponentModel.DataAnnotations;

public class User 
{
    [Key]
    public int UserId { get; set; }
    [Required] 
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    
    [Required]
    public int EmployeeId { get; set; }
    [Required]
    public Employee Employee { get; set; }
}