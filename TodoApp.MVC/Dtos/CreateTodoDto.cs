namespace TodoApp.MVC.Dtos;

public sealed record CreateTodoDto(
    string Title,
    string Description,
    DateTimeOffset EndDate);