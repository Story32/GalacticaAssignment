using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticaOOP
{
    //SpaceObject is the parent class

    abstract class SpaceObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
    }

    class Position
    {
        public float X { get; set; }
        public float Y { get; set; }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public Position(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Position operator +(Position a, Position b)
        {
            return new Position(a.X + b.X, a.Y + b.Y);
        }

        public static Position operator -(Position a, Position b)
        {
            return new Position(a.X - b.X, a.Y - b.Y);
        }

        public static Position operator *(Position a, float f)
        {
            return new Position(a.X * f, a.Y * f);
        }

        public static Position operator /(Position a, float f)
        {
            
            if (f < 0.000001f && f > -0.000001f)
            {
                throw new DivideByZeroException();
            }
            return new Position(a.X / f, a.Y / f);
        }
    }
}
