using ProductClientHub.API.Entities;
using ProductClientHub.API.Infrastructure;
using ProductClientHub.API.UseCases.Products.SharedValidator;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Products.Register;

public class RegisterProductUseCase
{
    public ResponseShortProductJson Execute(Guid clientId, RequestProductJson request)
    {
        var dbContext = new ProductClientHubDbContext();

        Validate(dbContext, clientId, request);

        var entity = new Product
        {
            Name = request.Name,
            Brand = request.Brand,
            Price = request.Price,
            ClientId = clientId,
        };

        dbContext.Products.Add(entity);
        try
        {
            dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao salvar alterações: {ex.Message}");
            Console.WriteLine($"Detalhes: {ex.InnerException?.Message}");
            throw;
        }


        return new ResponseShortProductJson
        {
            Id = entity.Id,
            Name = entity.Name,
        };
    }
    private void Validate(ProductClientHubDbContext dbContext, Guid clientId, RequestProductJson request)
    {
        var clientExist = dbContext.Clients.Any(client => client.Id == clientId);

        if (clientExist == false)
            throw new NotFoundException("Client not found");

        var validator = new RequestProductValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errors = result.Errors.Select(failure => failure.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errors);
        }
    }
}
