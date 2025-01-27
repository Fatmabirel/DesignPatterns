using DesignPattern.CQRS.CQRS.Commands;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly CQRSContext _context;
        public RemoveProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveProductCommand removeProductCommand)
        {
            var values = _context.Products.Find(removeProductCommand.Id);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
