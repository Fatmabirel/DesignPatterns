using DesignPattern.CQRS.CQRS.Commands;
using DesignPattern.CQRS.CQRS.Queries;
using DesignPattern.CQRS.CQRS.Results;
using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.CQRS.Handlers
{
    public class GetProductUpdateByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetProductUpdateByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIdQuery query)
        {
            var values = _context.Set<Product>().Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                Id = values.Id,
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                Description = values.Description
            };
        }
    }
}
