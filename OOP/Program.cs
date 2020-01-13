using System;

namespace OOP
{
    // Encapsulation
    // Inheritance
    // Polymorphism

    public class Parent
    {
        private int privateField = 1;
        protected int protectedField = 1;
        public int publicField = 1;

        static Parent()
        {
            Console.WriteLine("Parent: Static Ctor is accessed");
        }

        public Parent()
        {
            Console.WriteLine("Parent is instantiated");
        }

        public virtual void showParentMessage()
        {
            Console.WriteLine("Hello world from Parent");
        }
    }

    public class Child : Parent
    {
        protected new int protectedField = 5;
        public new int publicField = 5;

        static Child() // no access modifiers and it runs once in the app during the first object initialization
        {
            Console.WriteLine("Child: Static Ctor is accessed");
        }

        public Child()
        {
            Console.WriteLine("Child is instantiated");
        }

        public override void showParentMessage()
        {
            Console.WriteLine("Hello world from Child");
        }

        public void printParentInnerData()
        {
            Console.WriteLine($"protectedField: {base.protectedField}, publicField: {base.publicField}");
        }

        public void printChildInnerData()
        {
            Console.WriteLine($"protectedField: {protectedField}, publicField: {publicField}");
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, long b)
        {
            return a + (int)b;
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Parent obj = new Child();

            //obj.showParentMessage();

            //obj.printParentInnerData();
            //obj.printChildInnerData();

            var obj = new Child();

            var obj2 = new Child();

            var parent = new Parent();

            var obj3 = new Child();

        }
    }
}
