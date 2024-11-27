using Application.Dto.UserDto;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping;

/// <summary>
/// Конфигурация маппинга для User
/// </summary>
public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, AddUserResponse>();
        
        CreateMap<AddUserRequest, User>()
            .ConstructUsing(dto => new User
            {
                Id = Guid.NewGuid(),
                Email = dto.Email,
                Password = dto.Password
            });

        CreateMap<User, UpdateUserResponse>();
        
        CreateMap<UpdateUserRequest, User>()
            .ConstructUsing(dto => new User
            {
                Id = dto.Id,
                Email = dto.Email,
                Password = dto.Password,
            });

        CreateMap<User, GetAllUserResponse>();
    }
}