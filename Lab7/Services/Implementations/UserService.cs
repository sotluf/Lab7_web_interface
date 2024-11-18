using Lab7.Models;

namespace Lab7.Services.Implementations;

internal class UserService() :
    ModelService<User>([
        new User { Id = Guid.NewGuid(), FirstName = "John", LastName = "Doe", Email = "john.doe@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Alice", LastName = "Brown", Email = "alice.brown@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Bob", LastName = "Davis", Email = "bob.davis@example.com" },
        new User
        {
            Id = Guid.NewGuid(), FirstName = "Charlie", LastName = "Wilson", Email = "charlie.wilson@example.com"
        },
        new User { Id = Guid.NewGuid(), FirstName = "Diana", LastName = "Taylor", Email = "diana.taylor@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Edward", LastName = "Moore", Email = "edward.moore@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Fiona", LastName = "Clark", Email = "fiona.clark@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "George", LastName = "Hall", Email = "george.hall@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Hannah", LastName = "Young", Email = "hannah.young@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Ian", LastName = "Allen", Email = "ian.allen@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Julia", LastName = "Wright", Email = "julia.wright@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Kevin", LastName = "Lopez", Email = "kevin.lopez@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Linda", LastName = "Hill", Email = "linda.hill@example.com" },
        new User { Id = Guid.NewGuid(), FirstName = "Michael", LastName = "Scott", Email = "michael.scott@example.com" }
    ]), IUserService;
