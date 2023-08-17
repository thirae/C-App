using System;
using System.Media;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ResultForm : Form
    {
        // 全問正解の音
        private SoundPlayer allCorrectSound =
            new SoundPlayer(@"C: /Users/User/Desktop/hirae/QuizApp/Sound/allcorrect.wav");

        // コンストラクタ
        public ResultForm()
        {
            InitializeComponent();

            // 正答率計算用変数
            float right = 0.0f;
            float bad = 0.0f;
            // 正誤を代入している配列を代入
            string[] JudgeAry = QuizForm.GetAnsAry();
            // 何問目か表示する変数
            string now;

            // ラベルのテキストに代入
            for(int i = 0;i< 10;i++)
            {
                // 何問目か表示する変数に代入
                now = i + 1 + "問目   ";

                // 正解ならrightを
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
                        JudgeLabel1.Text = now + JudgeAry[i];
                        break;
                    case 1:
                        JudgeLabel2.Text = now + JudgeAry[i];
                        break;
                    case 2:
                        JudgeLabel3.Text = now + JudgeAry[i];
                        break;
                    case 3:
                        JudgeLabel4.Text = now + JudgeAry[i];
                        break;
                    case 4:
                        JudgeLabel5.Text = now + JudgeAry[i];
                        break;
                    case 5:
                        JudgeLabel6.Text = now + JudgeAry[i];
                        break;
                    case 6:
                        JudgeLabel7.Text = now + JudgeAry[i];
                        break;
                    case 7:
                        JudgeLabel8.Text = now + JudgeAry[i];
                        break;
                    case 8:
                        JudgeLabel9.Text = now + JudgeAry[i];
                        break;
                    case 9:
                        JudgeLabel10.Text = now + JudgeAry[i];
                        break;
                }
            }

            // 正答率計算
            float corAnswer = right / (right + bad) * 100.0f;
            // 文字列に変換
            string answerRate = Convert.ToString(corAnswer);
            answerRate = "結果   " + answerRate + "%";
            AnswerRateLabel.Text = answerRate;

            // 全問正解なら音を鳴らす
            if (corAnswer == 100.0f)
            {
                allCorrectSound.Play();
            }

        }

        /// <summary>
        /// 終了ボタンを押した際のイベント、アプリを終了させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// リトライボタンを押した際のイベント、アプリを再起動させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetryButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
