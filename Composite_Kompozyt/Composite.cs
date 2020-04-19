using System;
using System.Collections.Generic;

namespace Composite_Kompozyt
{
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}