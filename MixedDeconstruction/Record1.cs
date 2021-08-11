#nullable disable
namespace MixedDeconstruction
{
    public record Record1(string Name, int Age);

    record Record2()
    {
        void Test()
        {
            var record1 = new Record1("", 1);

            //(bool isTrue, record1.Age, record1.Name) = (true, 1, "1");
        }
    }
}