using System.ComponentModel.DataAnnotations;

namespace TrevalTripProject.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int ID { get; set; }

        public string FotoUrl { get; set; }

        public string Aciklama { get; set; }
    }
}