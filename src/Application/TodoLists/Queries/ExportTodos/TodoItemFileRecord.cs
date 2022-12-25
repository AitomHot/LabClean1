using LabClean1.Application.Common.Mappings;
using LabClean1.Domain.Entities;

namespace LabClean1.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
