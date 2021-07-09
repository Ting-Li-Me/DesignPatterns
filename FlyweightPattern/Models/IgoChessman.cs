namespace FlyweightPattern.Models
{
    using System;
    abstract class IgoChessman
    {
        public abstract string GetColor();

        public void Display(Coordinates coordinates)
        {
            Console.WriteLine($"chess piece color: {this.GetColor()}, position: {coordinates.X} {coordinates.Y}");
        }
    }
}
