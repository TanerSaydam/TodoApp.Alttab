namespace TodoApp.MVC.Models;

public sealed class Todo
{
    public Todo()
    {
        Id = Guid.CreateVersion7();
    }
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTimeOffset EndDate { get; set; }
    public bool IsCompleted { get; set; }
    public DateTimeOffset? CompletedDate { get; set; }
}