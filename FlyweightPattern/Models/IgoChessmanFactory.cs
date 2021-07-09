namespace FlyweightPattern.Models
{
    using System.Collections;
    class IgoChessmanFactory
    {
        private static IgoChessmanFactory instance = new IgoChessmanFactory();
        private Hashtable ht;

        private IgoChessmanFactory()
        {
            ht = new Hashtable();
            IgoChessman black, white;
            black = new BlackIgoChessman();
            ht.Add("b", black);
            white = new WhiteIgoChessman();
            ht.Add("w", white);
        }

        public static IgoChessmanFactory GetInstance()
        {
            return instance;
        }

        public IgoChessman GetIgochessman(string color)
        {
            return (IgoChessman)ht[color];
        }


    }
}
