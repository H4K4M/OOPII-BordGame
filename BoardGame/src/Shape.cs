using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.src
{
    public class Shape
    {
        public string Value { get; set; }

        private Shape(string value)
        {
            Value = value;
        }

        public static Shape Circle { get { return new Shape("●"); } }
        public static Shape Square { get { return new Shape("■"); } }
        public static Shape Triangle { get { return new Shape("▲"); } }
    }
}
