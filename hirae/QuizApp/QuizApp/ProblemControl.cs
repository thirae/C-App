using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class ProblemControl : UserControl
    {
        // 解答格納するための変数
        private string answerNumber;
        // 解説を格納するための変数
        private string explanationText;
        // 選択肢を記憶しておくための変数
        private string choiceNumber;

        // コンストラクタ
        public ProblemControl()
        {
            // インスタンス生成
            InitializeComponent();
        }

        /// <summary>
        /// 選択肢Aのボタンを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButton1_Click(object sender, EventArgs e)
        {
            // 選んだ選択肢がAなら0を代入
            choiceNumber = "0";
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        /// <summary>
        /// 選択肢Bのボタンを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButton2_Click(object sender, EventArgs e)
        {
            // 選んだ選択肢がBなら1を代入
            choiceNumber = "1";
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        /// <summary>
        /// 選択肢Cのボタンを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButton3_Click(object sender, EventArgs e)
        {
            // 選んだ選択肢がCなら2を代入
            choiceNumber = "2";
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        /// <summary>
        /// 選択肢Dのボタンを押した際のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerButton4_Click(object sender, EventArgs e)
        {
            // 選んだ選択肢がDなら3を代入
            choiceNumber = "3";
            // 解答のコントローラー表示メソッド
            QuizForm.ChangeAnswerControl();
        }

        /// <summary>
        /// 問題を出すメソッド
        /// </summary>
        /// <param name="pro">問題が格納された配列を受け取る</param>
        public void Problem(string[] pro)
        {
            // 現在何問目か取得して文字列に変換
            string now = Convert.ToString(QuizForm.GetProgression() + 1);
            now = "第" + now + "問";
            // ラベルに代入
            ProblemLabel.Text = now;

            // 問題文を代入
            Quizlabel.Text = pro[1];
            // ボタン1～4の選択肢テキストを代入
            AnswerButton1.Text = pro[2];
            AnswerButton2.Text = pro[3];
            AnswerButton3.Text = pro[4];
            AnswerButton4.Text = pro[5];
            // 答えのNoを代入
            answerNumber = pro[6];
            // 解説を代入
            explanationText = pro[7];
        }

        /// <summary>
        /// 解答が格納された変数をgetするためのメソッド
        /// </summary>
        /// <returns></returns>
        public string GetAnswerNumber()
        {
            return answerNumber;
        }

        /// <summary>
        /// 解説が格納された変数をgetするためのメソッド
        /// </summary>
        /// <returns></returns>
        public string GetExplanationText()
        {
            return explanationText;
        }

        /// <summary>
        /// 選んだ選択肢が格納された変数をgetするためのメソッド
        /// </summary>
        /// <returns></returns>
        public string GetChoiceNumber()
        {
            return choiceNumber;
        }
    }
}
