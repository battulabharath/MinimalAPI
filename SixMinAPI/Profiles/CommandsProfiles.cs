using AutoMapper;
using SixMinApi.Dtos;
using SixMinApi.Models;

namespace SixMinApi.Profiles
{
    public class CommandsProfiles : Profile
    {
        public CommandsProfiles()
        {
            //source object to target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }
    }   
}