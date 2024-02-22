using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Visitor
    {
        public string name;
        public string favoriteCafe = "NoFavorite";
        public Visitor(string _name)
        {
            name = _name;           
        }

        public Visitor (string _name, Cafe _favoriteCafe)
        {
            name = _name;
            favoriteCafe = _favoriteCafe.name;
        }   
    }
}



