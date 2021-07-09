namespace FlyweightPattern.Models
{
    class BlackIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "black";
        }
    }
}
