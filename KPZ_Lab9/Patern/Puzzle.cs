namespace KPZ_Lab9.Patern
{
    public class Puzzle : IRoomComponent
    {
        public void Add(IRoomComponent component)
        {
            throw new NotImplementedException();
        }

        public void Remove(IRoomComponent component)
        {
            throw new NotImplementedException();
        }

        public string Display(int depth)
        {
            return new string('-', depth) + "Puzzle\n";
        }
    }
}
