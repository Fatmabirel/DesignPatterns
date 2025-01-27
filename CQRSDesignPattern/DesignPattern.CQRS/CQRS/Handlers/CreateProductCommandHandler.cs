using DesignPattern.CQRS.CQRS.Commands;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;
        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand createProductCommand)
        {
            _context.Products.Add(new Product
            {
                Name = createProductCommand.Name,
                Price = createProductCommand.Price,
                Stock = createProductCommand.Stock,
                Description = createProductCommand.Description,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
