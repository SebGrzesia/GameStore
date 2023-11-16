using System.ComponentModel.DataAnnotations;

namespace Store.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RemoveTime { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        public Game()
        {
            Id = Guid.NewGuid();
        }
    }
}
