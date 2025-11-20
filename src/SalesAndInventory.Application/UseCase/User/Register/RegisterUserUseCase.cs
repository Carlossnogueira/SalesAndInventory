using AutoMapper;
using FluentValidation.Results;
using SalesAndInventory.Communication.Request;
using SalesAndInventory.Communication.Response;
using SalesAndInventory.Domain.Repositories;
using SalesAndInventory.Domain.Repositories.User;
using SalesAndInventory.Domain.Security.Cryptography;
using SalesAndInventory.Domain.Security.Token;
using SalesAndInventory.Exception;

namespace SalesAndInventory.Application.UseCase.User.Register;

public class RegisterUserUseCase : IRegisterUserUseCase
{
    private readonly IEncrypter _encrypter;
    private readonly IUnityOfWork  _unityOfWork;
    private readonly IUserRepositoryWriteOnly  _userRepository;
    private readonly IMapper  _mapper;
    private readonly IUserRepositoryReadOnly _repositoryReadOnly;
    private readonly IAccessTokenGenerator _accessTokenGenerator;

    public RegisterUserUseCase(IEncrypter encrypter, 
        IUnityOfWork unityOfWork, 
        IUserRepositoryWriteOnly userRepository, 
        IMapper mapper, 
        IUserRepositoryReadOnly repositoryReadOnly, 
        IAccessTokenGenerator accessTokenGenerator)
    {
        _encrypter = encrypter;
        _unityOfWork = unityOfWork;
        _userRepository = userRepository;
        _mapper = mapper;
        _repositoryReadOnly = repositoryReadOnly;
        _accessTokenGenerator = accessTokenGenerator;
    }

    public async Task<ResponseRegisterUserJson> Execute(RequestRegisterUserJson requestUser)
    {
        await Validate(requestUser);
        
        var user = _mapper.Map<SalesAndInventory.Domain.Entities.User>(requestUser);
        
        user.Password = _encrypter.Encrypt(requestUser.Password);
        
        user.UserIdentifier = Guid.NewGuid();
        
        user.UpdatedAt = DateTime.UtcNow;
        
        await _userRepository.AddAsync(user);
        
        await _unityOfWork.Commit();

        return new ResponseRegisterUserJson()
        {
            Name = user.Name,
            Token = _accessTokenGenerator.Generate(user),
        };
    }
    
    private async Task Validate(RequestRegisterUserJson requestUser)
    {
        
        var result = new RegisterUserValidator().Validate(requestUser);
      
        
        var existsUserWithSameLogin = await _repositoryReadOnly.UserExistsWithSameLogin(requestUser.Login);

        if (existsUserWithSameLogin)
        {
            result.Errors.Add(new ValidationFailure("Login", "Invalid login"));
        }
        
        if (!result.IsValid)
        {
            var errors = result.Errors.Select(e => e.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errors);
        }
    }
}