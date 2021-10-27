// Sharp10 InterpolatedStringImprovements_net6 AttributeOnClass.cs

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

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
    ref struct RefMyStruct
    {
        public RefMyStruct(int t, int t2)
        {
        }
        public RefMyStruct(int t, int t2, IFormatProvider provider)
        {
        }
        public RefMyStruct(int t, int t2, IFormatProvider provider, string first)
        {
        }

        public bool AppendFormatted<T>(T t)
        {
            return true;
        }

        public bool AppendFormatted(string t)
        {
            return true;
        }

        public bool AppendLiteral(object s)
        {
            return true;
        }
    }

    public class ClassWithHandlerArgumentAttributeBase
    {
    }

    public class ClassWithHandlerArgumentAttribute : ClassWithHandlerArgumentAttributeBase
    {
        public void Log([InterpolatedStringHandlerArgument("")] AttributeOnClass c)
        {
        }
        [StringFormatMethod("format")]
        public void Log(string format, params string[] args)
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

    public static class StaticClassWithHandlerArgumentAttribute1
    {
    }

    record RecordWithHandlerArgumentAttribute1(string Name, int Age)
    {
        public void Log(string first, IFormatProvider provider,  
            [InterpolatedStringHandlerArgument("provider", "first")] RefMyStruct handler)
        {
        }

        public void Log([InterpolatedStringHandlerArgument()] RefMyStruct handler)
        {
            throw new NotImplementedException();
        }

        [StringFormatMethod("format")]
        public void Log(string format, params string[] args)
        {
        }

        [StringFormatMethod("format")]
        public void Log(bool b, string format, params string[] args)
        {
        }
    }

    class Use2
    {
        private void Test()
        {
            var classWithHandlerArgumentAttribute = new ClassWithHandlerArgumentAttribute();
            classWithHandlerArgumentAttribute.Log($"{1:D} test");
            var test = "test";
            classWithHandlerArgumentAttribute.Log("{0}", test);

            var classWithHandlerArgumentAttribute2 = new ClassWithHandlerArgumentAttribute2();
            var i = 2;
            var i1 = 1;
            classWithHandlerArgumentAttribute2.Log(a: i, b: "test", c:$"{i1} {i} test");

            var recordWithHandlerArgumentAttribute1 = new RecordWithHandlerArgumentAttribute1("bob", 21);
            const string task = "task";
            recordWithHandlerArgumentAttribute1.Log("", null, $"{task}" + $" tes t");
            recordWithHandlerArgumentAttribute1.Log($"{task}" + $" tes t");

            recordWithHandlerArgumentAttribute1.Log(@"test {0} {1}", "string", 1.ToString());
        }

        private static string Args() => "test";
    }
}