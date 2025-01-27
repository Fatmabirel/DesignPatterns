using DesignPattern.CQRS.CQRS.Queries;
using DesignPattern.CQRS.CQRS.Results;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Id = values.Id,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
            };
        }
    }
}
