using ShopComp.Models;
using System.Collections.Generic;

namespace ShopComp.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Tovar> Tovars { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
    }
}
