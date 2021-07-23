namespace Sharp10
{
    public struct ParameterlessStruct
    {
        private string Name;
        private string Nickname = "s";

        public ParameterlessStruct()
        {
        }

        public override string ToString()
        {
            return GetType().ToString();
        }
    }
    public class ParameterlessClass
    {
        private string Name;
        private string Nickname = "s";

        public ParameterlessClass()
        {
        }
    }

    public class UseStruct
    {
        private void Test()
        {
            new ParameterlessStruct(){};
            ParameterlessStruct parameterlessStruct = new(){};
        }
    }
}