using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_GAME_1
{
    public class Player
    {
        private String name
        public string Name { get => name; set => name = value; }
       
        private Image pic;
        public Image Pic { get => pic; set => pic = value; }
        public Player(String name, Image pic)
        {
            this.name = name;
            this.pic = pic;
        }

    }
}
