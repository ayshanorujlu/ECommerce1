using ECommerce.Entities.Concrete;

namespace ECommerce.WebUI
{
    internal class CartListViewModel
    {
        public Cart Cart { get; set; }
        public bool ShowRemoveButton { get; set; }
    }
}