using AutoMapper;
using Application.Features.Tareas.DTOs;
using Domain.Entities;

namespace Application.MappingProfiles
{
    public class TareaProfile : Profile
    {
        public TareaProfile()
        {
            // 🟢 Lectura: Entidad → DTO
           CreateMap<Tarea, TareaDTO>()
              .ForMember(dest => dest.creado_por, opt => opt.MapFrom(src => src.creado_por))
              .ForMember(dest => dest.asignado_a, opt => opt.MapFrom(src => src.asignado_a))
              .ForMember(dest => dest.nombre_creador, opt => opt.MapFrom(src => src.creador.nombre))
              .ForMember(dest => dest.nombre_asignado, opt => opt.MapFrom(src => src.asignado.nombre));


            // 🟡 Creación: DTO → Entidad
            CreateMap<TareaCreateDTO, Tarea>()
               .ForMember(dest => dest.creado_por, opt => opt.MapFrom(src => src.creado_por))
               .ForMember(dest => dest.asignado_a, opt => opt.MapFrom(src => src.asignado_a));

            // 🔵 Actualización: DTO → Entidad existente
            CreateMap<TareaUpdateDTO, Tarea>();
        }
    }
}
