using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Visitors
    {
        public string nameVisitor;
        public string favoriteCafe = "NoFavorite";
        public Visitors(string _nameVisitor)
        {
            nameVisitor = _nameVisitor;           
        }

        public Visitors (string _nameVisitor, Cafe _favoriteCafe)
        {
        nameVisitor = _nameVisitor;
        favoriteCafe = _favoriteCafe.cafeName;
        }

      


    }
}



