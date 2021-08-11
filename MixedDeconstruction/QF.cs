namespace MixedDeconstruction
{
#nullable disable
    public class QF<T>
    {
        private void Test<T_MethodGeneric>()
        {
            T_MethodGeneric localU;
            T localT ;

            (localU, localT) = (default, default);
        }
    }

    class QF2
    {
        private void Test()
        {

        }
    }
}