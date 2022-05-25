using EvaShop.ViewModels;

namespace EvaShop.Services
{
    public static class MessagesFormatter
    {
        public static string Factura(string message, IEnumerable<ShopingCartViewModel> model)
        {
            var msg = "<table>" +
                      "<tr>" +
                      "<th>Articulo</th>" +
                      "<th>Cantidad</th>" +
                      "<th>Precio</th>" +
                      "</tr>";

            foreach (var item in model)
            {
                msg += "  <tr>" +
                       $"  <td>{item.Articulo}</td>" +
                       $"  <td>{item.Cantidad}</td>" +
                       $"  <td>{item.PrecioDeVenta}</td>" +
                       "  </tr>";
            }
            msg +=  "</table>";
            return msg;
        }

       
    }
}
