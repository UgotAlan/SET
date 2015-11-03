using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET
{
    public class Cards
    {
        public string image { get { return _image; } set { _image = value; } }
        private string _image; 
        public string color { get { return _color; } set { _color = value; } }
        private string _color;
        public string shade { get { return _shade; } set { _shade = value; } }
        private string _shade;
        public string shape { get { return _shape; } set { _shape = value; } }
        private string _shape;
        public int number { get { return _number; } set { _number = value; } }
        private int _number;
        public bool inplay { get { return _inplay; } set { _inplay = value; } }
        private bool _inplay;
        public bool beenPlayed { get { return _beenPlayed; } set { _beenPlayed = value; } }
        private bool _beenPlayed;
    }
}
