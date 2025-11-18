using SalesAndInventory.Communication.Request;
using SalesAndInventory.Communication.Response;

namespace SaleAndInventory.Application.UseCase.User.Register;

public interface IRegisterUserUseCase
{
    Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson requestUser);
}