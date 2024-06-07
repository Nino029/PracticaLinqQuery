

namespace PracticaLinqDomain.BaseClass
{
    public class Product
    {

       public int ProductId { get; set; }
        public string ?CodigoBarra { get; set; }
        public string ?Marca { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
