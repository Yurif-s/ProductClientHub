using ProductClientHub.API.Infrastructure;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCases.Clients.GetAll;

public class GetAllClientUseCase
{
    public ResponseAllClients Execute()
    {
        var dbContext = new ProductClientHubDbContext();

        var clients = dbContext.Clients.ToList();

        return new ResponseAllClients
        {
            Clients = clients.Select(client => new ResponseShortClientJson
            {
                Id = client.Id,
                Name = client.Name,
            }).ToList()
        };
    }
}
