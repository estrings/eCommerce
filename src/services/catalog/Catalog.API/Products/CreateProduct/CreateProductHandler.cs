using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(string Name, string Description, List<string> Category, string ImageFile, decimal Price) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        //Business logic to create a product
        throw new NotImplementedException();
    }
}
