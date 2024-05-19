using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Core.DTOs;
using Worker.Core.Models;

namespace Worker.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee,EmployeeDto>().ReverseMap();
        }
    }
}
