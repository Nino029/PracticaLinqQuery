

namespace PracticaLinqDomain.BaseClass
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int UserId { get; set; }
        public User ?User { get; set; }

    }
}
