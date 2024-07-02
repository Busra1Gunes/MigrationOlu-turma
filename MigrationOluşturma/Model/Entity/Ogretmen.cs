using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationOluşturma.Model.Entity
{
    public class Ogretmen
    {
        public int Id { get; set; }
        public string OgretmenAdi { get; set; }
        public string OgretmenSoyadi { get; set; }
        public string Sinifi {  get; set; }
        public int DersId {  get; set; }    
        public virtual Ders Dersler { get; set; }
    }
}
