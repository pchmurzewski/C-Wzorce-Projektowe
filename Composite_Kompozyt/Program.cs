using System;

namespace Composite_Kompozyt
{
    class Program
    {
        static void Main()
        {
            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf 1"));
            root.Add(new Leaf("Leaf 2"));
            root.Add(new Leaf("Leaf 3"));

            Composite compX = new Composite("Composite X");
            compX.Add(new Leaf("Leaf X 1"));
            compX.Add(new Leaf("Leaf X 2"));

            Composite compY = new Composite("Composite X");
            compY.Add(new Leaf("Leaf Y 1"));

            compX.Add(compY);

            root.Add(compX);
            root.Add(new Leaf("Leaf 3"));

            Leaf leaf = new Leaf("Leaf 4");
            root.Add(leaf);
            root.Remove(leaf);

            root.Display(1);

            Console.ReadKey();
        }
    }
}
