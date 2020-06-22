using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AireSpring.Model;
using AireSpring.View;
using AutoMapper;

namespace AireSpring.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Employee, IEmployeeView>();
            Mapper.CreateMap<IEmployeeView, Employee>();
        }
    }
}
