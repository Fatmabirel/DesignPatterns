namespace DesignPattern.CQRS.DataAccessLayer
{
    public class Discount
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Amount { get; set; }
        public bool CodeStatus { get; set; }
    }
}
