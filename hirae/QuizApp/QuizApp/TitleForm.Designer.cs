namespace QuizApp
{
    partial class TitleForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.Quizlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StartButton.Location = new System.Drawing.Point(299, 287);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(240, 110);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "スタート！";
            this.StartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.QuizButtonClicked);
            // 
            // Quizlabel
            // 
            this.Quizlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Quizlabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Quizlabel.Location = new System.Drawing.Point(246, 58);
            this.Quizlabel.Name = "Quizlabel";
            this.Quizlabel.Size = new System.Drawing.Size(340, 154);
            this.Quizlabel.TabIndex = 1;
            this.Quizlabel.Text = "なぞなぞQuiz10";
            this.Quizlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 451);
            this.Controls.Add(this.Quizlabel);
            this.Controls.Add(this.StartButton);
            this.Name = "TitleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label Quizlabel;
    }
}

