namespace DesignPattern.CQRS.CQRS.Queries
{
    public class GetProductByIdQuery
    {
        public int Id { get; set; }

        public GetProductByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
