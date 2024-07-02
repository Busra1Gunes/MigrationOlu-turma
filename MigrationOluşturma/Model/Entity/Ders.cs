using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationOluşturma.Model.Entity
{
    public class Ders
    {
        public int DersId { get; set; }
        public int DersAdi { get; set; }
        public  virtual List<Ogretmen> OgretmenlerList { get; set; }
    }
}
