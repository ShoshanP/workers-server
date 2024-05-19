using AutoMapper;
using worker.API.Models;
using Worker.Core.Models;

namespace worker.API.Mapping
{
    public class PostModelsMappingProfile : Profile
    {
        public PostModelsMappingProfile()
        {
            CreateMap<RolePostModel, Role>();
            CreateMap<EmployeePostModel, Employee>();
        }
    }
}
