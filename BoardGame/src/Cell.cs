using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame.src
{
    public class Cell : Button
    {
        public static int BUTTON_HEIGHT = 30;
        public static int BUTTON_WIDTH = 30;

        public bool Occupied { get; set; }

        public Cell ()
        {
            Occupied = false;
        }

    }
}
