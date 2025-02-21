using ApiProjectKampi.WebApi.Controllers.Entities;
using ApiProjectKampi.WebApi.Dtos.FeatureDtos;
using ApiProjectKampi.WebApi.Dtos.MessageDtos;
using AutoMapper;

namespace ApiProjectKampi.WebApi.Mapping
{
    public class GeneralMapping:Profile
    {
    
        public GeneralMapping()
        {

            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetByIdFeatureDto>().ReverseMap();




            CreateMap<Message,ResultMessageDto>().ReverseMap();
            CreateMap<Message,CreateMessageDto>().ReverseMap();
            CreateMap<Message,UpdateMessageDto>().ReverseMap();
            CreateMap<Message,GetByIdMessageDto>().ReverseMap();



        }
    }
}
