using System;
using System.Windows.Forms;
using System.Media;

namespace QuizApp
{
    public partial class AnswerControl : UserControl
    {
        // 正解の音
        private SoundPlayer correctSound =
            new SoundPlayer(@"C: /Users/User/Desktop/hirae/QuizApp/Sound/correct.wav");
        // ハズレの音
        private SoundPlayer errorSound =
            new SoundPlayer(@"C: /Users/User/Desktop/hirae/QuizApp/Sound/error.wav");

        // コンストラクタ
        public AnswerControl()
        {
            // インスタンス生成
            InitializeComponent();
        }

        /// <summary>
        /// ボタンをクリックすると問題Controllerを表示するイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // 問題CTR表示
            QuizForm.proCtr.Visible = true;
            QuizForm.ansCtr.Visible = false;
            // 問題呼び出し
            QuizForm.CallProblem();
        }

        /// <summary>
        /// 正誤判定しtextを書き換えるメソッド
        /// </summary>
        public void ChangeText()
        {
            // 正誤判定
            if (QuizForm.proCtr.GetAnswerNumber() == QuizForm.proCtr.GetChoiceNumber())
            {
                // 正解の音を鳴らす
                correctSound.Play();
                // text書き換え
                AnswerLabel.Text = "正解!";
                // 配列に正解を格納
                QuizForm.SetAnsAry("正解!");
            }
            else
            {
                // 不正解の音を鳴らす
                errorSound.Play();
                // text書き換え
                AnswerLabel.Text = "不正解";
                // 配列に不正解を格納
                QuizForm.SetAnsAry("不正解");
            }
            // 現在何問目か取得して文字列に変換
            string now = Convert.ToString(QuizForm.GetProgression());
            // 最大問題数取得
            string max = Convert.ToString(QuizForm.GetMax());
            // 現在何問中何問目かを表示するため結合
            string fraction = now + "/" + max;
            // 現在何問目か代入
            ProgressionLabel.Text = fraction;
            // 解説を代入
            ExplanationLabel.Text = QuizForm.proCtr.GetExplanationText();          
        }
    }
}
