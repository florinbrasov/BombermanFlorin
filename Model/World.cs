using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bomberman.Model
{
    class World
    {
        public WorldItem[,] WorldItems{get;set;}
        public Size size { get; set; }//TODO de ce e de tip point? Nu trb sa fie un integer?

        public World()
        {
            WorldItems = new WorldItem[11,11];

        }

        public void LoadLevel(String filePath)
        {
            string[] gameObjects;
            gameObjects=File.ReadAllLines(filePath);

            int i = 0;
            int j = 0;
            foreach(string gameObject in gameObjects) 
            {
                j = 0;
                string[] contents = gameObject.Split(' ');
                foreach (string content in contents)
                {
                    switch (content)
                    {
                        case "1":
                            WorldItems[i,j] = new Ground();
                            //worldItems[i][j].CellContent = CellContent.Ground;
                        break;
                        case "2":
                            WorldItems[i,j] = new IndestructibleWall();
                            //worldItems[i][j].CellContent = CellContent.IndestructibleWall;
                        break;
                        case "3":
                            WorldItems[i,j] = new DestructibleWall();
                            //worldItems[i][j].CellContent = CellContent.DestructibleWall;
                        break;
                    }
                    j++;
                }
                i++;
            }
            //TODO: Implement LoadGame
        }
    }
}
