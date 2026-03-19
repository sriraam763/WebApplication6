namespace WebApplication6.Models;

public class TaskList
{
    public int Id { get; set; }
    
    public string TaskName { get; set; }

    public DateTime datetime { get; set; } = DateTime.Now;
    
    public bool IsDone { get; set; }
}