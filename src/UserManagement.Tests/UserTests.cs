using Xunit;
using Microsoft.EntityFrameworkCore;
using UserManagement.Api.Data;
using UserManagement.Api.Models;

public class UserTests
{
    [Fact]
    public void CreateUser_ShouldAddUser()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase("TestDb")
            .Options;

        using var context = new AppDbContext(options);

        var user = new User { Name = "Test", Email = "test@test.com" };

        context.Users.Add(user);
        context.SaveChanges();

        Assert.Equal(1, context.Users.CountAsync().Result);
    }
}