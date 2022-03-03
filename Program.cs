namespace LLAS_SPscore2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static double[] appeal = { 20000, 20000, 20000 }; // SP角色 表現力
        public static double[] technique = { 20000, 20000, 20000 }; // SP角色 技巧
        
        public static double[] SPup = new double[3]; // SP角色 默契能力表 SP張力up
        
        public static double[] SameType = new double[3]; // SP角色 同屬性效果
        public static int[] IsSameType = new int[3]; // 同屬性偵測+計算數量
        
        public static double[] cardAppeal = { 20000, 20000, 20000 }; //SP角色卡片原始表現力
        public static double[] cardTechnique = { 20000, 20000, 20000 }; //SP角色卡片原始技巧

        public static double[] freindAppealUp = new double[3]; //好友表現力效果
        public static double[] friendTechniqueUp = new double[3]; //好友技巧效果

        public static double[] beltLimit = { 5, 5, 0 }; // 飾品:腰帶突破數
        public static double[] beltSkillLevel = { 20, 20, 0 }; // 飾品:腰帶技能等級

        public static double[] beltTechnique = {20000,20000,20000,
                20000,20000,20000,
                20000,20000,20000 }; // 穿著腰帶角色的技巧
        public static double[] beltSameType = new double[9]; // 穿著腰帶角色的同屬性效果
        public static double[] SPBeltEffect = new double[3];
        public static double Str2double(string str) // string轉double
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