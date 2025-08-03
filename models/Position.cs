using System.ComponentModel.DataAnnotations;

public class Position
{
    [Key]
    public int PositionId { get; set; }
    [Required]
    public string Title { get; set; }
    public string Description { get; set; }
    [Required]
    public DateTime CreatedAt { get; set; }

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}