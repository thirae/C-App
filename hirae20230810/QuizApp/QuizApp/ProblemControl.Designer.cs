namespace QuizApp
{
    partial class ProblemControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProblemText = new System.Windows.Forms.TextBox();
            this.AnswerButton1 = new System.Windows.Forms.Button();
            this.AnswerButton2 = new System.Windows.Forms.Button();
            this.AnswerButton3 = new System.Windows.Forms.Button();
            this.AnswerButton4 = new System.Windows.Forms.Button();
            this.ProblemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProblemText
            // 
            this.ProblemText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProblemText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProblemText.Location = new System.Drawing.Point(14, 58);
            this.ProblemText.Multiline = true;
            this.ProblemText.Name = "ProblemText";
            this.ProblemText.ReadOnly = true;
            this.ProblemText.Size = new System.Drawing.Size(736, 100);
            this.ProblemText.TabIndex = 6;
            this.ProblemText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AnswerButton1
            // 
            this.AnswerButton1.Location = new System.Drawing.Point(58, 188);
            this.AnswerButton1.Name = "AnswerButton1";
            this.AnswerButton1.Size = new System.Drawing.Size(304, 131);
            this.AnswerButton1.TabIndex = 7;
            this.AnswerButton1.Text = "button1";
            this.AnswerButton1.UseVisualStyleBackColor = true;
            this.AnswerButton1.Click += new System.EventHandler(this.AnswerButton1_Click);
            // 
            // AnswerButton2
            // 
            this.AnswerButton2.Location = new System.Drawing.Point(390, 188);
            this.AnswerButton2.Name = "AnswerButton2";
            this.AnswerButton2.Size = new System.Drawing.Size(338, 131);
            this.AnswerButton2.TabIndex = 8;
            this.AnswerButton2.Text = "button2";
            this.AnswerButton2.UseVisualStyleBackColor = true;
            this.AnswerButton2.Click += new System.EventHandler(this.AnswerButton2_Click);
            // 
            // AnswerButton3
            // 
            this.AnswerButton3.Location = new System.Drawing.Point(58, 348);
            this.AnswerButton3.Name = "AnswerButton3";
            this.AnswerButton3.Size = new System.Drawing.Size(304, 135);
            this.AnswerButton3.TabIndex = 9;
            this.AnswerButton3.Text = "button3";
            this.AnswerButton3.UseVisualStyleBackColor = true;
            this.AnswerButton3.Click += new System.EventHandler(this.AnswerButton3_Click);
            // 
            // AnswerButton4
            // 
            this.AnswerButton4.Location = new System.Drawing.Point(390, 348);
            this.AnswerButton4.Name = "AnswerButton4";
            this.AnswerButton4.Size = new System.Drawing.Size(338, 131);
            this.AnswerButton4.TabIndex = 10;
            this.AnswerButton4.Text = "button4";
            this.AnswerButton4.UseVisualStyleBackColor = true;
            this.AnswerButton4.Click += new System.EventHandler(this.AnswerButton4_Click);
            // 
            // ProblemLabel
            // 
            this.ProblemLabel.AutoSize = true;
            this.ProblemLabel.Location = new System.Drawing.Point(358, 19);
            this.ProblemLabel.Name = "ProblemLabel";
            this.ProblemLabel.Size = new System.Drawing.Size(52, 18);
            this.ProblemLabel.TabIndex = 11;
            this.ProblemLabel.Text = "label1";
            // 
            // ProblemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ProblemLabel);
            this.Controls.Add(this.AnswerButton4);
            this.Controls.Add(this.AnswerButton3);
            this.Controls.Add(this.AnswerButton2);
            this.Controls.Add(this.AnswerButton1);
            this.Controls.Add(this.ProblemText);
            this.Name = "ProblemControl";
            this.Size = new System.Drawing.Size(770, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProblemText;
        private System.Windows.Forms.Button AnswerButton1;
        private System.Windows.Forms.Button AnswerButton2;
        private System.Windows.Forms.Button AnswerButton3;
        private System.Windows.Forms.Button AnswerButton4;
        private System.Windows.Forms.Label ProblemLabel;
    }
}
