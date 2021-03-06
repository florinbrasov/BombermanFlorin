﻿using Bomberman.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bomberman
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            World world = new World();
            world.LoadLevel(@"..\..\Model\Levels\Level1.txt");
            //Console.Write(world.worldItems);
        }
    }
     enum CellContent
     {
         None,
         Ground,
         IndestructibleWall,
         DestructibleWall,
         Bomb,
         Monster,
         Bomberman
     }

}
