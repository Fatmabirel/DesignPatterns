using DesignPattern.CQRS.CQRS.Results;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;
        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Id = x.Id,
                ProductName = x.Name,
                Price = x.Price,
                Stock = x.Stock,
            }).ToList();
            return values;
        }

    }
}
