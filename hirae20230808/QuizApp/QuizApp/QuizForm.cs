using System.Windows.Forms;
using System.Collections.Generic;

namespace QuizApp
{
    public partial class QuizForm : Form
    {
        // コンストラクタ
        public QuizForm()
        {
            QuizProblem quiz = new QuizProblem();
            // ファイル読み込み
            List<string[]> lists = quiz.CsvReader(quiz.GetFileName());
            // 読み込んだファイルをシャッフルして引数分返させる
            string[][] randomAry = quiz.Random(10, lists);

            //インスタンス生成
            InitializeComponent();
        }
    }
}
