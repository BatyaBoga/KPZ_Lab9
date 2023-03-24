namespace KPZ_Lab9.Patern
{
    public interface IRoomComponent
    {
        void Add(IRoomComponent component);
        void Remove(IRoomComponent component);
        string Display(int depth);
    }
}
