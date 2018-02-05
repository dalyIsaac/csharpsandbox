using System;

namespace UninitializedProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new TestClass("Hello, world!");
            Console.WriteLine(x.setTestValue);
            // x.testValue == null
            Console.ReadLine();
        }
    }

    class TestClass
    {
        public TestClassTwo testValue;
        public string setTestValue;

        public TestClass(string value)
        {
            this.setTestValue = value;
        }
    }

    class TestClassTwo
    {
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
}
