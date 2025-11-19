using SalesAndInventory.Communication.Request;
using SalesAndInventory.Communication.Response;

namespace SalesAndInventory.Application.UseCase.User.Register;

public interface IRegisterUserUseCase
{
    Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson requestUser);
}