namespace KPZ_Lab9.Patern
{
    public class Room : IRoomComponent
    {
        private List<IRoomComponent> _components = new List<IRoomComponent>();

        public void Add(IRoomComponent component)
        {
            _components.Add(component);
        }

        public void Remove(IRoomComponent component)
        {
            _components.Remove(component);
        }

        public string Display(int depth)
        {
            string result = new string('-', depth) + "Room\n";

            foreach (IRoomComponent component in _components)
            {
                result += component.Display(depth + 2);
            }

            return result;
        }

        public List<IRoomComponent> GetComponents()
        {
            return _components;
        }
    }
}
