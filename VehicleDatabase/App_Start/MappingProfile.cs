using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleDatabase.Models;
using VehicleDatabase.Dtos;

namespace VehicleDatabase.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Mapper.CreateMap<VehicleMake, VehicleMakeDto>();
            //Mapper.CreateMap<VehicleMakeDto, VehicleMake>();

            Mapper.CreateMap<VehicleModel, VehicleModelDto>();
            Mapper.CreateMap<VehicleModelDto, VehicleModel>();

        }
    }
}