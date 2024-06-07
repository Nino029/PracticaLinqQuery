
using PracticaLinqDomain.BaseClass;
namespace PracticaLinqDomain
{
    public class VentaDb
    {
        
        private readonly List<Sale> _sales;

        public VentaDb(List<Sale> sales)
        {
            _sales = sales;
        }

        public IEnumerable<object> GetTotalSalesByUser(int userId)
        {
            var result = from sale in _sales
                         where sale.UserId == userId
                         group sale by sale.User?.Nombre into g
                         select new
                         {
                             Vendedor = g.Key,
                             CantidadVentasRealizadas = g.Count()
                         };

            return result;
        }




    }
}
