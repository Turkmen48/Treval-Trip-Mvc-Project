using System.Collections.Generic;

namespace TrevalTripProject.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

        public IEnumerable<Yorumlar> Deger2 { get; set; }

    }
}