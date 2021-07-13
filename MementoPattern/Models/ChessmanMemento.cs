namespace MementoPattern.Models
{
    class ChessmanMemento
    {
        internal string Label { get; set; }
        internal int X { get; set; }
        internal int Y { get; set; }

        internal ChessmanMemento(string label, int x, int y)
        {
            this.Label = label;
            this.X = x;
            this.Y = y;
        }
    }
}
