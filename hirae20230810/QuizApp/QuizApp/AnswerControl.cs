using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class AnswerControl : UserControl
    {
        public AnswerControl()
        {
            // インスタンス生成
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // 問題CTR表示
            QuizForm.proCtr.Visible = true;
            QuizForm.ansCtr.Visible = false;
            // 問題呼び出し
            QuizForm.CallProblem();
        }

        // テキスト変更
        public void ChangeText()
        {
            // 正誤判定
            if (QuizForm.proCtr.GetAnswerText() == QuizForm.proCtr.GetChoiceText())
            {
                AnswerLabel.Text = "正解!";
                QuizForm.SetAnsAry("正解!");
            }
            else
            {
                AnswerLabel.Text = "不正解";
                QuizForm.SetAnsAry("不正解");
            }
            // 現在何問目か取得して文字列に変換
            string now = Convert.ToString(QuizForm.GetProgression());
            // 最大問題数取得
            string max = Convert.ToString(QuizForm.GetMax());
            // 現在何問中何問目かを表示するため結合
            string fraction = now + "/" + max;

            // 代入
            ExplanationText.Text = QuizForm.proCtr.GetExplanationText();
            ProgressionLabel.Text = fraction;
        }
    }
}
