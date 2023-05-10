using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Server.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interfaces;
using Repository.Repositories;
using Server.Repository.Entities;
using Services.Models;

namespace Services
{
    public static class Extensions
    {
        public static void AddRepoDependencies(this IServiceCollection services)
        {
            services.AddScoped<IPatientRepository, PatientRepository>();

            MapperConfiguration config = new MapperConfiguration(
               conf => conf.CreateMap<Patient, PatientModel>()
               .ForMember(dest => dest.PatientId, opt => opt.MapFrom(dest => dest.PatientId))
               .ReverseMap()
               .ForMember(dest => dest.PatientId, opt => opt
               .MapFrom(dest => dest.PatientId)));
            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddDbContext<IDataSource, Context>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }
    }
}
