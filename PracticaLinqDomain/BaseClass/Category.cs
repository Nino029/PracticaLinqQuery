
namespace PracticaLinqDomain.BaseClass
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string ?Nombre { get; set; }

        public ICollection<Product> ?Products { get; set; }


        List<Category> categories = new List<Category>
{
        new Category { CategoryId = 1, Nombre = "Electrónica" },
        new Category { CategoryId = 2, Nombre = "Ropa" }
};

       

    }
}
