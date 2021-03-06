﻿using Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Frame
    {

        private readonly Size size;
        private readonly ICollection<ICircle> circles = new HashSet<ICircle>();

        public Frame(Size size)
        {

            if (size.Length <= 0 || size.Width <= 0)
                throw new System.ArgumentException("Frame dimensions must be positive.", "size");

            this.size = size;

        }

        public Frame Add(ICircle circle)
        {

            if (circle == null)
                throw new System.ArgumentNullException("circle", "Circle reference is null.");

            if (this.circles.Contains(circle))
                throw new System.ArgumentException("Circle already exists in the frame.", "circle");

            if (!circle.IsInsideOf(new Rectangle(new Location(), this.size)))
                throw new System.ArgumentException("Circle is outside of the frame.", "circle");

            Frame frame = new Frame(this.size);
            foreach (Circle c in this.circles)
                frame.circles.Add(c);
            frame.circles.Add(circle);

            return frame;

        }

        public Frame Replace(ICircle circle, ICircle with)
        {

            if (circle == null)
                throw new System.ArgumentNullException("circle", "Circle is null.");

            if (!this.circles.Contains(circle))
                throw new System.ArgumentException("Frame does not contain specified circle.", "circle");

            if (circle.Equals(with))
                return this;    // Nothing to do

            Frame frame = new Frame(this.size);

            foreach (ICircle c in this.circles.Where(x => !x.Equals(circle)))
                frame.circles.Add(c);

            return frame.Add(with);   // Validates with

        }

        public Frame Resize(Size size)
        {

            Frame frame = new Frame(size);  // Validates size

            Rectangle rect = new Rectangle(new Location(), size);

            if (this.circles.Any(c => !c.IsInsideOf(rect)))
                throw new System.ArgumentException("At least one circle is not inside new frame size.", "size");

            foreach (ICircle circle in this.circles)
                frame.circles.Add(circle);

            return frame;

        }

        public void Draw()
        {
            Console.WriteLine("Frame {0}x{1}", this.size.Length, this.size.Width);
            foreach (ICircle circle in this.circles)
                circle.Draw();
        }

    }
}