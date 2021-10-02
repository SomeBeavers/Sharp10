// Sharp10 InterpolatedStringImprovements_net6 AttributeOnClass.cs

using System.Runtime.CompilerServices;

namespace MyNamespace
{
    [InterpolatedStringHandlerAttribute]
    public class AttributeOnClass
    {
        public AttributeOnClass(int t, int t2, ClassWithHandlerArgumentAttribute classWithHandlerArgumentAttribute)
        {
        }
        public AttributeOnClass(int t, int t2, ClassWithHandlerArgumentAttributeBase classWithHandlerArgumentAttribute)
        {
        }

        public AttributeOnClass(int t, int t2, int outInt, ClassWithHandlerArgumentAttributeBase classWithHandlerArgumentAttribute)
        {
            outInt = 0;
        }
        public AttributeOnClass(int t, int t2, int outInt, string name, ClassWithHandlerArgumentAttributeBase classWithHandlerArgumentAttribute)
        {
            outInt = 0;
        }

        public bool AppendLiteral(string s)
        {
            return true;
        }

        public bool AppendFormatted<T>(T t)
        {
            return true;
        }
        public bool AppendFormatted<T>(T t, string format)
        {
            return true;
        }
        //public bool AppendFormatted(object t, string format)
        //{
        //    return true;
        //}
    }

    public class ClassWithHandlerArgumentAttribute1
    {
    }

    [InterpolatedStringHandler]
    record R();

    [InterpolatedStringHandler]
    struct MyStruct
    {
        
    }

    [InterpolatedStringHandler]
    ref struct RefMyStruct
    {
        
    }

    public class ClassWithHandlerArgumentAttributeBase
    {
    }

    public class ClassWithHandlerArgumentAttribute : ClassWithHandlerArgumentAttributeBase
    {
        public void Log([InterpolatedStringHandlerArgument("")] AttributeOnClass c)
        {
        }
    }
    public class ClassWithHandlerArgumentAttribute2: ClassWithHandlerArgumentAttributeBase
    {
        public void Log(int a, [InterpolatedStringHandlerArgument("a", "b", "")] AttributeOnClass c, string b)
        {
        }

        private const string b = "a";

        private const string a = "a";
    }

    class Use2
    {
        private void Test()
        {
            var classWithHandlerArgumentAttribute = new ClassWithHandlerArgumentAttribute();
            classWithHandlerArgumentAttribute.Log($"{1:D} test");

            var classWithHandlerArgumentAttribute2 = new ClassWithHandlerArgumentAttribute2();
            var i = 2;
            var i1 = 1;
            classWithHandlerArgumentAttribute2.Log(a: i, b: "test", c:$"{i1} {i} test");
        }
    }
}