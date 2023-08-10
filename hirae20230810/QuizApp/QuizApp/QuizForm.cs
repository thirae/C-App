using System.Windows.Forms;
using System.Collections.Generic;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        // 現在何問目かの変数
        private static int progression = 0;
        //シャッフルしたファイルを保存しておく配列
        private static string[][] randomAry;
        //何問連続で問題を出すか
        private static int max = 10;
        //解答記録を代入する配列
        private static string[] ansAry = new string[max];

        // インスタンスを固定
        public static ProblemControl proCtr;
        public static AnswerControl ansCtr;

        // コンストラクタ
        public QuizForm()
        {
            // インスタンス
            proCtr = new ProblemControl();
            ansCtr = new AnswerControl();
            QuizProblem quiz = new QuizProblem();
            // ファイル読み込み
            List<string[]> lists = quiz.CsvReader(quiz.GetFileName());
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

        // progressionを返す
        public static int GetProgression()
        {
            return progression;
        }

        // maxを返す
        public static int GetMax()
        {
            return max;
        }

        // ansAryを返す
        public static string[] GetAnsAry()
        {
            return ansAry;
        }

        // ansAryに代入する
        public static void SetAnsAry(string answer)
        {
            ansAry[progression - 1] = answer;
        }

        // 解答コントローラ切り替えメソッド
        public static void ChangeAnswerControl()
        {
            // 解答のコントローラー表示
            proCtr.Visible = false;
            ansCtr.Visible = true;
            // テキスト変更メソッド呼び出し
            ansCtr.ChangeText();
        }

        // 問題メソッドを呼び出すメソッド
        public static void CallProblem()
        {
            //最後の問題を超えていたら
            if(progression >= max)
            {
                // QuizForm qForm = new QuizForm();  
                proCtr.Visible = false;
                ansCtr.Visible = false;
                // 現画面を非表示
                // qForm.Visible = false;

                ResultForm result = new ResultForm();
                result.Show();
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
