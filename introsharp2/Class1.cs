using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToSharpEX2
{
    struct Vector2
    {
        public float x;
        public float y;

        public Vector2(float v1)
        {
            x = v1;
            y = 0;
        }
        public Vector2(float v1, float v2)
        {
            x = v1;
            y = v2;
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y);
        }

        public Vector2 Normal()
        {
            float mag = Magnitude();
            return new Vector2(x / mag, y / mag);
        }
        public void Normalize()
        {
            float mag = Magnitude();
            x /= mag;
            y /= mag;
        }

        public static float Distance(Vector2 start, Vector2 end)
        {
            Vector2 displace = start - end;
            return displace.Magnitude();
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }
        public static Vector2 operator *(Vector2 lhs, float rhs)
        {
            return new Vector2(lhs.x * rhs, lhs.y * rhs);
        }
        public static Vector2 operator *(float lhs, Vector2 rhs)
        {
            return new Vector2(lhs * rhs.x, lhs * rhs.y);
        }
        public static Vector2 operator /(Vector2 lhs, float rhs)
        {
            return new Vector2(lhs.x / rhs, lhs.y / rhs);
        }
        public static bool operator ==(Vector2 lhs, Vector2 rhs)
        {
            float deltaX = Math.Abs(lhs.x - rhs.x);
            float deltaY = Math.Abs(lhs.y - rhs.y);

            return deltaX < float.Epsilon && deltaY < float.Epsilon;
        }
        public static bool operator !=(Vector2 lhs, Vector2 rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            return obj is Vector2 && this == (Vector2)obj;
        }
        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", x, y);
        }
    }
}