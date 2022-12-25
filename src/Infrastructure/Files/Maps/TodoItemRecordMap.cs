using System.Globalization;
using LabClean1.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace LabClean1.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).ConvertUsing(c => c.Done ? "Yes" : "No");
    }
}
