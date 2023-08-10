using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ProblemControl : UserControl
    {
        // 解答格納するための変数
        private string answerText;
        // 解説を格納するための変数
        private string explanationText;
        // 選択肢を記憶しておくための変数
        private string choiceText;

        public ProblemControl()
        {
            InitializeComponent();
        }

        // 問題を出すメソッド
        public void Problem(string[] pro)
        {
            // 現在何問目か取得して文字列に変換
            string now = Convert.ToString(QuizForm.GetProgression()+1);
            now = "第" + now + "問";

            // ラベルに代入
            ProblemLabel.Text = now;
            // 問題文
            ProblemText.Text = pro[1];
            // ボタン1～4の選択肢テキスト
            AnswerButton1.Text = pro[2];
            AnswerButton2.Text = pro[3];
            AnswerButton3.Text = pro[4];
            AnswerButton4.Text = pro[5];
            // 答え
            answerText = pro[6];
            // 解説
            explanationText = pro[7];
        }

        // 選択肢Aのボタン
        private void AnswerButton1_Click(object sender, EventArgs e)
        {
            choiceText = AnswerButton1.Text;
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        // 選択肢Bのボタン
        private void AnswerButton2_Click(object sender, EventArgs e)
        {
            choiceText = AnswerButton2.Text;
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        // 選択肢Cのボタン
        private void AnswerButton3_Click(object sender, EventArgs e)
        {
            choiceText = AnswerButton3.Text;
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        // 選択肢Dのボタン
        private void AnswerButton4_Click(object sender, EventArgs e)
        {
            choiceText = AnswerButton4.Text;
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        //getメソッド
        public string GetAnswerText()
        {
            return answerText;
        }

        //getメソッド
        public string GetExplanationText()
        {
            return explanationText;
        }

        //getメソッド
        public string GetChoiceText()
        {
            return choiceText;
        }
    }
}
