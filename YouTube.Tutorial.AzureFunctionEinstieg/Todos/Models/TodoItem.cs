using System;

namespace YouTube.Tutorial.AzureFunctionEinstieg.Todos.Models;

public class TodoItem
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}