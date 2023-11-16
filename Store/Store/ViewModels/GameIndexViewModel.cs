using System.ComponentModel.DataAnnotations;

namespace Store.ViewModels
{
    public class GameIndexViewModel
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RemoveTime { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}
