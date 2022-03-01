namespace LLAS_SPscore2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numAppeal1_ValueChanged(object sender, EventArgs e)
        {
            Program.appear[0] = (double)numAppeal1.Value;
        }

        private void numAppeal2_ValueChanged(object sender, EventArgs e)
        {
            Program.appear[1] = (double)numAppeal2.Value;
        }

        private void numAppeal3_ValueChanged(object sender, EventArgs e)
        {
            Program.appear[2] = (double)numAppeal3.Value;
        }

        private void numTechnique1_ValueChanged(object sender, EventArgs e)
        {
            Program.technique[0] = (double)numTechnique1.Value;
        }

        private void numTechnique2_ValueChanged(object sender, EventArgs e)
        {
            Program.technique[1] = (double)numTechnique2.Value;
        }

        private void numTechnique3_ValueChanged(object sender, EventArgs e)
        {
            Program.technique[2] = (double)numTechnique3.Value;
        }

        private void CBSPup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SPup[0] = Program.Str2double(CBSPup1.Text) / 100;
        }

        private void CBSPup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SPup[1] = Program.Str2double(CBSPup2.Text) / 100;
        }

        private void CBSPup3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SPup[2] = Program.Str2double(CBSPup3.Text) / 100;
        }

        private void CBSameType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SameType[0] = Program.Str2double(CBSameType1.Text) / 100 + 1;
            if(CBSameType1.Text != "0")
            {
                Program.IsSameType[0] = 1;
            }
            else { Program.IsSameType[0] = 0; }
        }

        private void CBSameType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SameType[1] = Program.Str2double(CBSameType2.Text) / 100 + 1;
            if (CBSameType2.Text != "0")
            {
                Program.IsSameType[1] = 1;
            }
            else { Program.IsSameType[1] = 0; }
        }
        private void CBSameType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SameType[2] = Program.Str2double(CBSameType3.Text) / 100 + 1;
            if(CBSameType3.Text != "0")
            {
                Program.IsSameType[2] = 1;
            }
            else { Program.IsSameType[2] = 0; }
        }

        private void BTNStart_Click(object sender, EventArgs e)
        {
            double sum_appear = 0; //SP分數表現力總和
            double sum_technique = 0; //SP分數技巧總和
            double sum_SPup = 0; //默契能力表SP分數UP總和
            double SPscore = 0; //SP分數最終值

            //隊伍編成顯示值計算
            for (int i = 0; i < 3; i++) 
            {
                sum_appear += Program.appear[i];
                sum_technique += Program.technique[i];
                sum_SPup += Program.SPup[i];
            }
            SPscore = (sum_appear + Math.Floor(sum_technique*1.2)) * (1 + sum_SPup);
            TBSPScore1.Text = Math.Floor(SPscore).ToString();  
            //隊伍顯示值計算

        }
    }
}