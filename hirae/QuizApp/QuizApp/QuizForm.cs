using System.Windows.Forms;
using System.Collections.Generic;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        // 現在何問目かの変数
        private static int progression = 0;
        // シャッフルしたファイルを保存しておく配列
        private static string[][] randomAry;
        // 何問連続で問題を出すか
        private static int max = 10;
        // 解答記録を代入する配列
        private static string[] ansAry = new string[max];

        // インスタンスを固定
        public static ProblemControl proCtr;
        public static AnswerControl ansCtr;

        // コンストラクタ
        public QuizForm()
        {
            // インスタンス化
            proCtr = new ProblemControl();
            ansCtr = new AnswerControl();
            QuizProblem quiz = new QuizProblem();
            // ファイル読み込み
            List<string[]> lists = quiz.CsvReader();
            // 読み込んだファイルをシャッフルして引数分返させる
            randomAry = quiz.Random(max, lists);

            // インスタンス生成
            InitializeComponent();

            // パネルに追加
            QuizPanel.Controls.Add(proCtr);
            QuizPanel.Controls.Add(ansCtr);

            // 問題のコントロールのみを見えるようにする
            proCtr.Visible = true;
            ansCtr.Visible = false;

            // 問題メソッドを呼ぶメソッド呼び出し
            CallProblem();
        }

        /// <summary>
        /// 現在何問目か格納された変数をgetするためのメソッド
        /// </summary>
        /// <returns></returns>
        public static int GetProgression()
        {
            return progression;
        }

        /// <summary>
        /// 最大何問か格納された変数をgetするためのメソッド
        /// </summary>
        /// <returns></returns>
        public static int GetMax()
        {
            return max;
        }

        /// <summary>
        /// 解答記録が格納された変数をgetするためのメソッド
        /// </summary>
        /// <returns></returns>
        public static string[] GetAnsAry()
        {
            return ansAry;
        }

        /// <summary>
        /// 解答記録を変数に格納するためのメソッド
        /// </summary>
        /// <param name="answer">正誤の文字を引数として受け取り代入</param>
        public static void SetAnsAry(string answer)
        {
            ansAry[progression - 1] = answer;
        }

        /// <summary>
        /// 解答コントローラ切り替えメソッド
        /// </summary>
        public static void ChangeAnswerControl()
        {
            // 解答のコントローラー表示
            proCtr.Visible = false;
            ansCtr.Visible = true;
            // テキスト変更メソッド呼び出し
            ansCtr.ChangeText();
        }

        /// <summary>
        /// 問題メソッドを呼び出すメソッド
        /// </summary>
        public static void CallProblem()
        {
            // 最後の問題を超えていたら
            if(progression >= max)
            {  
                // 非表示にして結果フォームを表示
                proCtr.Visible = false;

                ResultForm result = new ResultForm();
                result.ShowDialog();
            }
            else
            {
                // 問題メソッド呼び出し
                proCtr.Problem(randomAry[progression]);
                // 問題を変更
                progression++;
            }
        }
    }
}
