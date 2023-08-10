using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ResultForm : Form
    {
        // コンストラクタ
        public ResultForm()
        {
            InitializeComponent();

            //正答率計算用変数
            float right = 0.0f;
            float bad = 0.0f;
            //正誤を代入している配列を代入
            string[] JudgeAry = QuizForm.GetAnsAry();

            //ラベルのテキストに代入
            for(int i = 0;i< 10;i++)
            {
                //正解ならrightを
                if (JudgeAry[i] == "正解!")
                {
                    right++;
                }
                else
                {
                    bad++;
                }

                switch(i)
                {
                    case 0:
                        JudgeLabel1.Text = JudgeAry[i];
                        break;
                    case 1:
                        JudgeLabel2.Text = JudgeAry[i];
                        break;
                    case 2:
                        JudgeLabel3.Text = JudgeAry[i];
                        break;
                    case 3:
                        JudgeLabel4.Text = JudgeAry[i];
                        break;
                    case 4:
                        JudgeLabel5.Text = JudgeAry[i];
                        break;
                    case 5:
                        JudgeLabel6.Text = JudgeAry[i];
                        break;
                    case 6:
                        JudgeLabel7.Text = JudgeAry[i];
                        break;
                    case 7:
                        JudgeLabel8.Text = JudgeAry[i];
                        break;
                    case 8:
                        JudgeLabel9.Text = JudgeAry[i];
                        break;
                    case 9:
                        JudgeLabel10.Text = JudgeAry[i];
                        break;
                }
            }

            //正答率計算
            float corAnswer = right / (right + bad) * 100.0f;
        }
    }
}
