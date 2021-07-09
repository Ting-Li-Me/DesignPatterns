namespace FlyweightPattern.Models
{
    class WhiteIgoChessman : IgoChessman
    {
        public override string GetColor()
        {
            return "White";
        }
    }
}
