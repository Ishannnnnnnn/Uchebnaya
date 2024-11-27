namespace Application.Dto.UserDto;

public class UpdateUserRequest
{
    public Guid Id { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
}