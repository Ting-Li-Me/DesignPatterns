namespace ObserverPattern.Interfaces
{
    using Models;
    interface IObserver
    {
        string Name { get; set; }
        void Help();
        void BeAttacked(AllyControlCenter acc);
    }
}
