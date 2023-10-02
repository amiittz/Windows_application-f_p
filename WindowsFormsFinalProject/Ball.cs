using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

public class Ball
{
    public Point Position { get; set; }
    public Size Size { get; set; }
    public Point Velocity { get; set; }

    public Ball(int diameter)
    {
        // Set the default starting position to (300, 300)
        Position = new Point(300, 300);
        Size = new Size(diameter, diameter);
        Velocity = Point.Empty; // Initialize velocity to zero
    }

    public void Move()
    {
        // Update the ball's position based on its velocity
        Position = new Point(Position.X + Velocity.X, Position.Y + Velocity.Y);
    }

    public void Draw(Graphics graphics)
    {
        // Draw the ball as a filled circle
        graphics.FillEllipse(Brushes.White, new Rectangle(Position, Size));
    }
}
