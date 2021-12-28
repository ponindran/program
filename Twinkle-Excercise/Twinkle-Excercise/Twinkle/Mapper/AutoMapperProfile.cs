using AutoMapper;
using Store.Infrastructure.BaseEntity;
using Store.Twinkle.BaseModel;
using System;
using Twinkle.Models;
using Twinkle.Models.ViewModels;
using Twinkle.Mvc.Converter;

namespace Twinkle.Mvc.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BaseEntity, BaseModel>();

            CreateMap<string, DateTime>().ConvertUsing(new DateTimeConverterForString());
            CreateMap<DateTime, string>().ConvertUsing(new StringConverterForDatetime());
            CreateMap<long, string>().ConvertUsing(new StringConverterForLong());
            CreateMap<string, long>().ConvertUsing(new LongConverterForString());

            CreateMap<double, string>().ConvertUsing(new StringConverterForDouble());
            CreateMap<string, double>().ConvertUsing(new DoubleConverterForString());

            CreateMap<ProductInfo, ProductInfoVM>()
                .ForMember(desc=> desc.Image , opt=> opt.MapFrom(src=> src.Image))
                .ForMember(desc=> desc.Name , opt=> opt.MapFrom(src=>src.Name))
                .ForMember(desc=> desc.ShortDesc, opt=> opt.MapFrom(src=>src.ShortDesc))
                .ForMember(desc=> desc.ProductId, opt=> opt.MapFrom(src=>src.ProductId))
                .ForMember(desc=> desc.Price, opt=> opt.MapFrom(src=>src.PriceInfo.Price))
                .ForMember(desc=> desc.Description, opt=>opt.MapFrom(src=>src.Description))
                /*.ForMember(desc=> desc.CreatedOn, opt=> opt.MapFrom(src=>src.CreatedOn))*/;


            CreateMap<ProductInfoVM,ProductInfo>()
               .ForMember(desc => desc.Image, opt => opt.MapFrom(src => src.Image))
               .ForMember(desc => desc.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(desc => desc.ShortDesc, opt => opt.MapFrom(src => src.ShortDesc))
               .ForMember(desc => desc.ProductId, opt => opt.MapFrom(src => src.ProductId))
               .ForMember(desc => desc.Description, opt => opt.MapFrom(src => src.Description))
               /*.ForMember(desc=> desc.CreatedOn, opt=> opt.MapFrom(src=>src.CreatedOn))*/;

            CreateMap<ProductInfoVM, PriceInfo>()
             .ForMember(desc => desc.ProductId, opt => opt.MapFrom(src => src.ProductId))
             .ForMember(desc => desc.Price, opt => opt.MapFrom(src => src.Price));
            
        }
    }
}
