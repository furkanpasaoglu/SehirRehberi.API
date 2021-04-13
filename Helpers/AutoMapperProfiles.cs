using System.Linq;
using AutoMapper;
using SehirRehberi.API.Dtos;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<City, CityForListDto>()
                .ForMember(dest=>dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src=>src.Photos.FirstOrDefault(p=>p.IsMain).Url);
                });

            CreateMap<City, CityForDetailDto>();

            CreateMap<Photo, PhotoForCreationDto>();
            CreateMap<PhotoForCreationDto, Photo>();
        }
    }
}