using ProductClientHub.API.UseCases.Client.Register;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCase.Client.Register;

public class RegisterClientUseCase
{
    public ResponseClientJson Execute(RequestClientJson request)
    {
        var validator = new RegisterClientValidator();

        var result = validator.Validate(request);

        if(result.IsValid == false)
        {
            throw new ArgumentException("Error in received data");
        }

        return new ResponseClientJson();
    }
}
