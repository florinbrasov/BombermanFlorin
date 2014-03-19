using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bomberman.Model
{
    class Bomb:WorldItem
    {
        public double TimeUntilExplosion { get; set; }
        public Size InfluenceZone { get; set; }
        public void Explosde()
        {
            //TODO: implement
            //TODO: Poate fi bagata intr-o interfata IExplode
        }
    }
}
