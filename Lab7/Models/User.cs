namespace Lab7.Models;

public record User : Model
{
    public required string FirstName { get; init; }

    public required string LastName { get; init; }

    public required string Email { get; init; }
}
