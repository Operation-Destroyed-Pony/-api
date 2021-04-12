using System;

namespace Destroyed.Pony.Domain.Catalog
{
    public class Rating {
        public int Id { get; set; }
        public int Star { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
    }
}