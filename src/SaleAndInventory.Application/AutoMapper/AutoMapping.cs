using AutoMapper;
using SalesAndInventory.Communication.Request;
using SalesAndInventory.Communication.Response;
using SalesAndInventory.Domain.Entities;

namespace SaleAndInventory.Application.AutoMapper;

public class AutoMapping : Profile
{

    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }
    
    private void RequestToEntity()
    {
        CreateMap<RequestRegisterUserJson, User>()
            .ForMember(dest => dest.Password, config => config.Ignore());
    }

    private void EntityToResponse()
    {
        CreateMap<User, ResponseRegisterUserJson>();
    }
    
}