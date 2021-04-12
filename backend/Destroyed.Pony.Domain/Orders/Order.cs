using System.Collections.Generic;
using System.Linq;

namespace Destroyed.Pony.Domain.Orders
{
    public class Orders
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
        public decimal TotalPrice => Items.Sum(i => i.Price);
        
    }
}