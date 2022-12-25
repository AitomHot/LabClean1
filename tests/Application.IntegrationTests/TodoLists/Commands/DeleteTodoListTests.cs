using LabClean1.Application.Common.Exceptions;
using LabClean1.Application.TodoLists.Commands.CreateTodoList;
using LabClean1.Application.TodoLists.Commands.DeleteTodoList;
using LabClean1.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace LabClean1.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
