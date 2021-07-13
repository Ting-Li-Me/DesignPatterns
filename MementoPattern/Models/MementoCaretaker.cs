namespace MementoPattern.Models
{
    class MementoCaretaker
    {
        private ChessmanMemento memento;

        internal ChessmanMemento GetMemento()
        {
            return this.memento;
        }

        internal void SetMemento(ChessmanMemento memento)
        {
            this.memento = memento;
        }
        
    }
}
