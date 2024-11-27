using Application.Dto.UserDto;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserService(
        IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public UserService(
        IUserRepository userRepository,
        IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<AddUserResponse> AddAsync(
        AddUserRequest userRequest,
        CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(userRequest);
        if (await _userRepository.IsUniqueUser(user.Email, cancellationToken))
            return null;
        
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);
        var createdUser = await _userRepository.AddAsync(user, cancellationToken);
        await _userRepository.SaveChangesAsync(cancellationToken);
        return _mapper.Map<AddUserResponse>(createdUser);
    }
    
    public async Task<LoginResponse> LoginAsync(
        LoginRequest loginRequest,
        CancellationToken cancellationToken)
    {
        var user = await _userRepository.IsUserExistAsync(loginRequest.Email, cancellationToken);
        if (user == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.Password))
            return null;

        var loginResponse = new LoginResponse { Email = user.Email, Password = user.Password };
        return loginResponse;
    }
    
    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var user = await GetByIdOrThrowAsync(id, cancellationToken);
        
        await _userRepository.DeleteAsync(user, cancellationToken); 
        await _userRepository.SaveChangesAsync(cancellationToken);
    }
    
    public async Task<UpdateUserResponse> UpdateAsync(
        UpdateUserRequest userRequest,
        CancellationToken cancellationToken)
    {
        var user = await GetByIdOrThrowAsync(userRequest.Id, cancellationToken);

        user.Update(
            userRequest.Email,
            userRequest.Password);
        
        await _userRepository.UpdateAsync(user, cancellationToken);
        await _userRepository.SaveChangesAsync(cancellationToken);
        
        return _mapper.Map<UpdateUserResponse>(user);
    }
    
    public async Task<List<GetAllUserResponse>> GetAllAsync(CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync(cancellationToken);
        return _mapper.Map<List<GetAllUserResponse>>(users);
    }
    
    private async Task<User> GetByIdOrThrowAsync(Guid id, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(id, cancellationToken);
        if (user != null)
            return user;
        
        return null;
    }
}