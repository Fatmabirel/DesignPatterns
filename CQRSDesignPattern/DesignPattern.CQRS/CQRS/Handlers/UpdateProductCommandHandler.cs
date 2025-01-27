using DesignPattern.CQRS.CQRS.Commands;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly CQRSContext _context;
        public UpdateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateProductCommand updateProductCommand)
        {
            var values = _context.Products.Find(updateProductCommand.Id);
            values.Name = updateProductCommand.Name;
            values.Price = updateProductCommand.Price;
            values.Stock = updateProductCommand.Stock;
            values.Description = updateProductCommand.Description;
            values.Status = true;
            _context.SaveChanges();
        }
    }
}
