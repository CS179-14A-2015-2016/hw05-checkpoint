using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
        struct Vector
        {
            public int X;
            public int Y;

            public Vector(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int DotProduct(Vector u, Vector v)
            {
                int dotproduct = (u.X * u.Y) + (v.X * v.Y);
                return dotproduct;
            }

            public int CrossProduct(Vector u, Vector v)
            {
                int crossproduct = (u.X * v.Y) - (v.X * u.Y);
                return crossproduct;
            }

            public int GetMagnitude(Vector u)
            {
                double magSqrdX = Math.Pow(u.X, 2);
                double magSqrdY = Math.Pow(u.Y, 2);
                double magSqrt = Math.Sqrt(magSqrdX + magSqrdY);
                int mag = Convert.ToInt32(magSqrt);
                return mag;
            }

            public Vector Normalize(Vector u)
            {
                int mag = GetMagnitude(u);
                int norX = u.X / mag;
                int norY = u.Y / mag;
                Vector v = new Vector(norX, norY);
                return v;
            }

            public Vector Project(Vector u, Vector v)
            {
                int proj = DotProduct(u, v) / Convert.ToInt32(Math.Pow(GetMagnitude(v), 2));
                Vector projection = new Vector(v.X*proj, v.Y*proj);
                return projection;
            }

            public Vector Reflect(Vector i, Vector n)
            {
                Vector N = Project(i, n);
                i.X = -2 * N.X;
                i.Y = 2 * N.Y;
                return i;
            }
            
        }
    }

