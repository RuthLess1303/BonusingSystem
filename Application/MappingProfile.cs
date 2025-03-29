using AutoMapper;

namespace Application;

public class MappingProfile : Profile
{
    /// <summary>
    /// ეს არის AutoMapper რომელიც ავტომატურად გადამეპავს მონაცემებს ერთი მოდელიდან მეორეში.
    /// გადასამეპად საჭიროა CreateMap ში გაწეროთ მოდელები.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public MappingProfile()
    {
        //CreateMap<FromWhatToMap, ToWhatToMap>();
    }
}
