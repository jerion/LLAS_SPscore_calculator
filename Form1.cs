namespace LLAS_SPscore2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 基本數值區-開始
        private void numAppeal1_ValueChanged(object sender, EventArgs e)
        {
            Program.appeal[0] = (double)numAppeal1.Value;
        }

        private void numAppeal2_ValueChanged(object sender, EventArgs e)
        {
            Program.appeal[1] = (double)numAppeal2.Value;
        }

        private void numAppeal3_ValueChanged(object sender, EventArgs e)
        {
            Program.appeal[2] = (double)numAppeal3.Value;
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
        // 基本數值區-結束

        // 計算區-開始
        private void BTNStart_Click(object sender, EventArgs e)
        {
            double sum_appeal = 0; //SP分數表現力總和
            double sum_technique = 0; //SP分數技巧總和
            double sum_SPup = 0; //默契能力表SP分數UP總和
            double SPscore = 0; //SP分數最終值
            double SameTypeCount = 0; //同屬性計數器

            // 隊伍編成顯示值計算-開始
            sum_appeal = Program.appeal.Sum();
            sum_technique = Program.technique.Sum();
            sum_SPup = Program.SPup.Sum() + 1;

            SPscore = (sum_appeal + Math.Floor(sum_technique * 1.2)) * sum_SPup;
            TBSPScore1.Text = Math.Floor(SPscore).ToString();  
            // 隊伍顯示值計算-結束

            // 好友效果計算-開始
            for (int i = 0; i < 3; i++)
            {
                sum_appeal += Math.Floor(Program.cardAppeal[i] * Program.freindAppealUp[i]);
                sum_technique += Math.Floor(Program.cardTechnique[i] * Program.friendTechniqueUp[i]);
            }

            SPscore = (sum_appeal + Math.Floor(sum_technique * 1.2)) * sum_SPup;
            TBSPScore2.Text = Math.Floor(SPscore).ToString();
            // 好友效果計算-結束

            // 同屬性計算效果-開始
            sum_technique = 0;
            for (int i = 0; i < 3; i++)
            {
                if(Program.IsSameType[i] == 1)
                {
                    sum_technique += Math.Floor((Program.technique[i]
                        + Math.Floor(Program.cardTechnique[i] * Program.friendTechniqueUp[i]))
                        * Program.SameType[i]);
                    SameTypeCount++;
                }
                else
                {
                    sum_technique += Program.technique[i]
                           + Math.Floor(Program.cardTechnique[i] * Program.friendTechniqueUp[i]);
                }
            }

            SPscore = Math.Floor((sum_appeal + Math.Floor(sum_technique * 1.2)) * sum_SPup);
            if (SameTypeCount > 0)
            {
                SPscore = Math.Floor(SPscore * (1.05 + 0.05 * SameTypeCount));
            }
            else { }
            TBSPScore3.Text = SPscore.ToString();
            // 同屬性計算效果-結束

            // 腰帶區-開始
            SPscore = Math.Floor(SPscore * (Program.SPBeltEffect.Sum() / 100 + 1));
            TBSPScore4.Text = SPscore.ToString();
            // 腰帶區-結束

        }
        // 計算區-結束

        // 好友數值區-開始
        private void numCardAppeal1_ValueChanged(object sender, EventArgs e)
        {
            Program.cardAppeal[0] = (double)numCardAppeal1.Value;
        }

        private void numCardAppeal2_ValueChanged(object sender, EventArgs e)
        {
            Program.cardAppeal[1] = (double)numCardAppeal2.Value;
        }

        private void numCardAppeal3_ValueChanged(object sender, EventArgs e)
        {
            Program.cardAppeal[2] = (double)numCardAppeal3.Value;
        }

        private void numCardTechnique1_ValueChanged(object sender, EventArgs e)
        {
            Program.cardTechnique[0] = (double)numCardTechnique1.Value;
        }

        private void numCardTechnique2_ValueChanged(object sender, EventArgs e)
        {
            Program.cardTechnique[1] = (double)numCardTechnique2.Value;
        }

        private void numCardTechnique3_ValueChanged(object sender, EventArgs e)
        {
            Program.cardTechnique[2] = (double)numCardTechnique3.Value;
        }

        private void TBFriendAppealUp1_TextChanged(object sender, EventArgs e)
        {
            Program.freindAppealUp[0] = Program.Str2double(TBFriendAppealUp1.Text) / 100;
        }

        private void TBFriendAppealUp2_TextChanged(object sender, EventArgs e)
        {
            Program.freindAppealUp[1] = Program.Str2double(TBFriendAppealUp2.Text) / 100;
        }

        private void TBFriendAppealUp3_TextChanged(object sender, EventArgs e)
        {
            Program.freindAppealUp[2] = Program.Str2double(TBFriendAppealUp3.Text) / 100;
        }

        private void TBFriendTechniqueUp1_TextChanged(object sender, EventArgs e)
        {
            Program.friendTechniqueUp[0] = Program.Str2double(TBFriendTechniqueUp1.Text) / 100;
        }

        private void TBFriendTechniqueUp2_TextChanged(object sender, EventArgs e)
        {
            Program.friendTechniqueUp[1] = Program.Str2double(TBFriendTechniqueUp2.Text) / 100;
        }

        private void TBFriendTechniqueUp3_TextChanged(object sender, EventArgs e)
        {
            Program.friendTechniqueUp[2] = Program.Str2double(TBFriendTechniqueUp3.Text) / 100;
        }
        // 好友數值區-結束

        // 飾品:腰帶區-開始
        private void numBeltLimit1_ValueChanged(object sender, EventArgs e)
        {
            Program.beltLimit[0] = (double)numBeltLimit1.Value;
        }

        private void numBeltLimit2_ValueChanged(object sender, EventArgs e)
        {
            Program.beltLimit[1] = (double)numBeltLimit2.Value;
        }

        private void numBeltLimit3_ValueChanged(object sender, EventArgs e)
        {
            Program.beltLimit[2] = (double)numBeltLimit3.Value;
        }

        private void numBeltSkillLV1_ValueChanged(object sender, EventArgs e)
        {
            Program.beltSkillLevel[0] = (double)numBeltSkillLV1.Value;
        }

        private void numBeltSkillLV2_ValueChanged(object sender, EventArgs e)
        {
            Program.beltSkillLevel[1] = (double)numBeltSkillLV2.Value;
        }

        private void numBeltSkillLV3_ValueChanged(object sender, EventArgs e)
        {
            Program.beltSkillLevel[2] = (double)numBeltSkillLV3.Value;
        }

        private void numBelt1Technique1_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[0] = (double)numBelt1Technique1.Value;
        }

        private void numBelt1Technique2_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[1] = (double)numBelt1Technique2.Value;
        }

        private void numBelt1Technique3_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[2] = (double)numBelt1Technique3.Value;
        }

        private void CBBelt1SameType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[0] = Program.Str2double(CBBelt1SameType1.Text) / 100;
        }

        private void CBBelt1SameType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[1] = Program.Str2double(CBBelt1SameType2.Text) / 100;
        }

        private void CBBelt1SameType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[2] = Program.Str2double(CBBelt1SameType3.Text) / 100;
        }

        private void numBelt2Technique1_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[3] = (double)numBelt2Technique1.Value;
        }

        private void numBelt2Technique2_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[4] = (double)numBelt2Technique2.Value;
        }

        private void numBelt2Technique3_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[5] = (double)numBelt2Technique3.Value;
        }

        private void CBBelt2SameType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[3] = Program.Str2double(CBBelt2SameType1.Text) / 100;
        }

        private void CBBelt2SameType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[4] = Program.Str2double(CBBelt2SameType2.Text) / 100;
        }

        private void CBBelt2SameType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[5] = Program.Str2double(CBBelt2SameType3.Text) / 100;
        }

        private void numBelt3Technique1_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[6] = (double)numBelt3Technique1.Value;
        }

        private void numBelt3Technique2_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[7] = (double)numBelt3Technique2.Value;
        }

        private void numBelt3Technique3_ValueChanged(object sender, EventArgs e)
        {
            Program.beltTechnique[8] = (double)numBelt3Technique3.Value;
        }

        private void CBBelt3SameType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[6] = Program.Str2double(CBBelt3SameType1.Text) / 100;
        }

        private void CBBelt3SameType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[7] = Program.Str2double(CBBelt3SameType2.Text) / 100;
        }

        private void CBBelt3SameType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.beltSameType[8] = Program.Str2double(CBBelt3SameType3.Text) / 100;
        }

        private void BTNBeltStart_Click(object sender, EventArgs e)
        {
            double beltEffect = 0;
            Program.SPBeltEffect = new double[3];
            
            for(int i = 0; i < 3; i++)
            {
                if(Program.beltSkillLevel[i] != 0)
                {
                    beltEffect = (Program.beltSkillLevel[i] - 1) / (14 + Program.beltLimit[i]);
                    if (Program.beltLimit[i] < 4)
                    {
                        beltEffect = beltEffect * (Program.beltLimit[i] + 1) * 0.5 + 1;
                        beltEffect = Math.Floor(beltEffect * 100) / 100;
                        for (int j = 0; j < 3; j++)
                        {
                            Program.SPBeltEffect[i] += Math.Floor(beltEffect * Program.beltTechnique[3 * i + j] * (Program.beltSameType[3 * i + j] + 1) / 100) / 100;
                        }
                    }
                    else
                    {
                        beltEffect = beltEffect * (Program.beltLimit[i] - 1) + 1;
                        beltEffect = Math.Floor(beltEffect * 100) / 100;
                        for (int j = 0; j < 3; j++)
                        {
                            Program.SPBeltEffect[i] += Math.Floor(beltEffect * Program.beltTechnique[3 * i + j] * (Program.beltSameType[3 * i + j] + 1) / 100) / 100;
                        }
                    }
                }
                else { }
            }

            TBBeltEffect1.Text = Program.SPBeltEffect[0].ToString();
            TBBeltEffect2.Text = Program.SPBeltEffect[1].ToString();
            TBBeltEffect3.Text = Program.SPBeltEffect[2].ToString();
        }
        // 飾品:腰帶區-結束
    }
}