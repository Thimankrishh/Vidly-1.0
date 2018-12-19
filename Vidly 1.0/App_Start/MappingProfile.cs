using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly_1._0.Dtos;
using Vidly_1._0.Models;

namespace Vidly_1._0.App_Start
{
    public class MappingProfile :Profile  // derive this class from profile define in auto mapper
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore()); /* to create mapping configurations between two types
            takes two parameters target & source. when we call CreateMap(), auto mapper uses reflection
            to scan these types it finds their properties and maps them based on their name.
            
            we need to load this when app is started.
             */
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m=> m.Id, opt=> opt.Ignore());
            
        }
    }
}