using System;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class TitleForm : Form
    {
        // コンストラクタ
        public TitleForm()
        {
            // インスタンス生成
            InitializeComponent();
        }

        private void QuizButtonClicked(object sender, EventArgs e)
        {
            // 現画面を非表示
            Visible = false;

            // Form2を表示
            QuizForm quiz = new QuizForm();
            quiz.Show();
        }
    }
}
