namespace ConstantInterpolatedStrings
{
    public class Local
    {
        private void Test()
        {
            const string renamed = "const string";
            // sel start
            const string localConst = $"{renamed}";
            // sel end

            LocalFunc();

            void LocalFunc()
            {
                const string localF1 = $"{renamed}";
            }
        }
    }
}