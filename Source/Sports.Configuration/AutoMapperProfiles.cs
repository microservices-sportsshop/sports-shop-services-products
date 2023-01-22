﻿using AutoMapper;
using Sports.Data.Dtos;
using Sports.Data.Entities;

namespace Sports.Configuration
{

    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            _ = CreateMap<ProductDto, Product>().ReverseMap();
        }
    }

}