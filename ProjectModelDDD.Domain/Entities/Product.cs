
namespace ProjectModelDDD.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Available { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
