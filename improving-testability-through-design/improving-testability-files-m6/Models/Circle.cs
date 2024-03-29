﻿using Models.Common;
using System;

namespace Models
{
    public class Circle : ICircle, IEquatable<Circle>
    {

        private readonly Location center;
        private readonly decimal radius;

        public Circle(Location center, decimal radius)
        {
            if (radius <= 0)
                throw new System.ArgumentException("Radius cannot be negative.", "radius");
            this.center = center;
            this.radius = radius;
        }

        public bool IsInsideOf(Rectangle rect)
        {
            return
                this.center.X - this.radius >= rect.Left
                && this.center.Y - this.radius >= rect.Top
                && this.center.X + radius <= rect.Right
                && this.center.Y + radius <= rect.Bottom;
        }

        public ICircle Move(Location center)
        {
            return new Circle(center, this.radius);
        }

        public ICircle Resize(decimal radius)
        {
            return new Circle(this.center, radius);
        }

        public void Accept(IShapeVisitor visitor)
        {
            visitor.VisitCircle(this.center, this.radius);
        }

        public bool Equals(ICircle other)
        {
            return Equals(other as Circle);
        }

        public bool Equals(Circle other)
        {
            return !object.ReferenceEquals(other, null) && other.center.Equals(this.center) && 
                    other.radius == this.radius;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Circle);
        }

        public override int GetHashCode()
        {
            return this.center.GetHashCode() ^ this.radius.GetHashCode();
        }

        public static bool operator ==(Circle a, Circle b)
        {
            if (!object.ReferenceEquals(a, null))
                return a.Equals(b);
            return object.ReferenceEquals(b, null);
        }

        public static bool operator !=(Circle a, Circle b)
        {
            return !(a == b);
        }
    
        public override string ToString()
        {
            return string.Format("Circle({0}, {1}, R{2})",
                                 this.center.X, this.center.Y, this.radius);
        }

    }
}