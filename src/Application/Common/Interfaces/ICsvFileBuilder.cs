using LabClean1.Application.TodoLists.Queries.ExportTodos;

namespace LabClean1.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
