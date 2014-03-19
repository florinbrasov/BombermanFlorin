using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bomberman.Model
{
    /// <summary>
    /// Asa se initializeaza + pornire
    /// GameTime gameTimeObject;
    /// gameTimeObject = new GameTime();
    /// Thread gameTime = new Thread(gameTimeObject.UpdateGameTime);
    /// gameTime.Start();
    /// 
    /// Asa o opresti
    /// gameTimeObject.StopGameTime();
    /// </summary>
    class GameTime
    {
        private volatile bool stop;
        public static float interval = 40f;
        public static float timer = 0;
        public void UpdateGameTime()
        {
            while (!stop)
            {
                Thread.Sleep(20);
                timer += 10;
            }
        }
        public void StopGameTime()
        {
            stop = true;
        }
    }
}
