using System.Reflection;
namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyAssembly = Assembly.LoadFile(@"C: \Users\kakar\OneDrive\Desktop\C#\SomeClassLibrary\bin\Debug/SomeClassLibrary.dll");
            var MyType=MyAssembly.GetType("SomeClassLibrary.Class1");
            dynamic MyObject=Activator.CreateInstance(MyType);
           Type ParameterType =MyObject.GetType();
            Console.WriteLine("all public methods");
            foreach(MemberInfo memberInfo in ParameterType.GetFields())
            {
                Console.WriteLine(memberInfo.Name);
            }
            foreach(MemberInfo memberInfo1 in ParameterType.GetProperties())
            {
                Console.WriteLine(memberInfo1.Name);
            }
            foreach(MemberInfo memberInfo2 in ParameterType.GetMethods())
            {
                Console.WriteLine(memberInfo2.Name);
            }

            Console.ReadKey();
        }
    }
}