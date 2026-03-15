using AutoMapper;

namespace clean_architecture_demo_v2.App.Common.Mappings
{
    //<T> for generic to be able to use any entity
    public interface IMapFrom<T>
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
