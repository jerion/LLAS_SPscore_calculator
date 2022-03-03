namespace LLAS_SPscore2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static double[] appeal = { 20000, 20000, 20000 }; // SP���� ��{�O
        public static double[] technique = { 20000, 20000, 20000 }; // SP���� �ޥ�
        
        public static double[] SPup = new double[3]; // SP���� �q����O�� SP�i�Oup
        
        public static double[] SameType = new double[3]; // SP���� �P�ݩʮĪG
        public static int[] IsSameType = new int[3]; // �P�ݩʰ���+�p��ƶq
        
        public static double[] cardAppeal = { 20000, 20000, 20000 }; //SP����d����l��{�O
        public static double[] cardTechnique = { 20000, 20000, 20000 }; //SP����d����l�ޥ�

        public static double[] freindAppealUp = new double[3]; //�n�ͪ�{�O�ĪG
        public static double[] friendTechniqueUp = new double[3]; //�n�ͧޥ��ĪG

        public static double[] beltLimit = { 5, 5, 0 }; // ���~:�y�a��}��
        public static double[] beltSkillLevel = { 20, 20, 0 }; // ���~:�y�a�ޯ൥��

        public static double[] beltTechnique = {20000,20000,20000,
                20000,20000,20000,
                20000,20000,20000 }; // ��۸y�a���⪺�ޥ�
        public static double[] beltSameType = new double[9]; // ��۸y�a���⪺�P�ݩʮĪG
        public static double[] SPBeltEffect = new double[3];
        public static double Str2double(string str) // string��double
        {
            double ans = 0;
            int dot = 1;
            double minus_sign = 1;

            for (int i = 0; i < str.Length; i++)
            {
                switch ((char)str[i])
                {
                    case '0':
                        break;
                    case '1':
                        ans = ans + Math.Pow(10, str.Length - i - dot);
                        break;
                    case '2':
                        ans = ans + 2 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '3':
                        ans = ans + 3 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '4':
                        ans = ans + 4 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '5':
                        ans = ans + 5 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '6':
                        ans = ans + 6 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '7':
                        ans = ans + 7 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '8':
                        ans = ans + 8 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '9':
                        ans = ans + 9 * Math.Pow(10, str.Length - i - dot);
                        break;
                    case '.':
                        ans = ans / 100;
                        dot = 2;
                        break;
                    case '-':
                        minus_sign = -1;
                        break;
                    default:
                        return 0;
                }
            }
            return ans * minus_sign;
        }  

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}