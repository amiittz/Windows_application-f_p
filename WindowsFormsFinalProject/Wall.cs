using System;
using System.Drawing;

public class Wall
{
    private Rectangle Bounds { get; set; }
    private Image WallImage;

    public Wall(int x, int y, int width, int height)
    {
        Bounds = new Rectangle(x, y, width, height);
    }

    public bool CollidesWith(Rectangle otherBounds)
    {
        return Bounds.IntersectsWith(otherBounds);
    }

    public void Draw(Graphics graphics)
    {
        if(Bounds.Width > Bounds.Height)
        {
            WallImage = Image.FromFile(@"pics\wallHorizontal.jpg");
        }
        else
        {
            WallImage = Image.FromFile(@"pics\wallVertical.jpg");
        }
        
        graphics.DrawImage(WallImage, Bounds);
        
    }

}
