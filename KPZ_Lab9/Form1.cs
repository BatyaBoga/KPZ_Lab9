using KPZ_Lab9.Patern;

namespace KPZ_Lab9
{
    public partial class Form1 : Form
    {
        private Room _room;


        public Form1()
        {
            InitializeComponent();

            _room = new Room();
        }

        private void AddComponent_Click(object sender, EventArgs e)
        {
            IRoomComponent component;

            if (rbRoom.Checked)
            {
                component = new Room();
            }
            else if (rbPuzzle.Checked)
            {
                component = new Puzzle();
            }
            else
            {
                component = new Item();
            }

            TreeNode node = tvComponents.SelectedNode;

            if (node == null)
            {
                _room.Add(component);
                node = tvComponents.Nodes.Add(component.GetType().Name);
            }
            else if (node.Tag is Room room)
            {
                room.Add(component);
                node = node.Nodes.Add(component.GetType().Name);
            }

            node.Tag = component;

            Display();
        }


        private void DisplaySubComponents(IRoomComponent component, TreeNode node)
        {
            if (component is Room room)
            {
                foreach (IRoomComponent subComponent in room.GetComponents())
                {
                    TreeNode subNode = node.Nodes.Add(subComponent.GetType().Name);
                    subNode.Tag = subComponent;

                    DisplaySubComponents(subComponent, subNode);
                }
            }
        }

        private void Display()
        {
            tvComponents.Nodes.Clear();

            TreeNode rootNode = tvComponents.Nodes.Add(_room.GetType().Name);

            foreach (IRoomComponent component in _room.GetComponents())
            {
                TreeNode node = rootNode.Nodes.Add(component.GetType().Name);
                node.Tag = component;

                DisplaySubComponents(component, node);
            }

            rootNode.ExpandAll();
        }

      }
    }
