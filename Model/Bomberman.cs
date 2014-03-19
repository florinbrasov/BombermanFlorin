using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.Model
{
    class Bomberman:WorldItem
    {
        public int Lifes { get; set; }
        public int AvalibeBombs { get; set; }

        public void Walk()
        {
            //TODO: Implement
            //TODO:IWalk
        }

        public void PutBomb(Bomb bomb)
        {
            //TODO Implement. 
            //TODO: Am schimat denumirea din setBomb in putBomb
        }

        public void LoseLife()
        {
            //TODO: Implement
        }
    }
}
