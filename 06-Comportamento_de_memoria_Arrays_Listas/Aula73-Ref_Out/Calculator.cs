namespace Aula73_Ref_Out
{
    public class Calculator
    {
        public static void TripleREF(ref int x) {
            x = x * 3;
        }
        public static void TripleOUT(int origin, out int result) {
            result = origin * 3;
        }
    }
}