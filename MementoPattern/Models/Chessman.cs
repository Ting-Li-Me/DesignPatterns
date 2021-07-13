namespace MementoPattern.Models
{
    class Chessman
    {
        public string Label { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Chessman (string label, int x, int y)
        {
            this.Label = label;
            this.X = x;
            this.Y = y;
        }

        internal ChessmanMemento Save()
        {
            return new ChessmanMemento(this.Label, this.X, this.Y);
        }

        internal void Restore(ChessmanMemento memento)
        {
            this.Label = memento.Label;
            this.X = memento.X;
            this.Y = memento.Y;
        }

    }
}
