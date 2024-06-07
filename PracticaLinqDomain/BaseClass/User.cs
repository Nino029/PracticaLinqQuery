

namespace PracticaLinqDomain.BaseClass
{
    public class User
    {
        public int UserId { get; set; }
        public string ?Nombre { get; set; }
        public ICollection<Sale> ? Sales { get; set; }

    }
}
