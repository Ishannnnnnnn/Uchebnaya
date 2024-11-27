namespace Application.Dto.UserDto;

public class GetAllUserResponse
{
    public Guid Id { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
}