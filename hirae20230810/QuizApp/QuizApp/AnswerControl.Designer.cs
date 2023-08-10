namespace QuizApp
{
    partial class AnswerControl
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
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ExplanationText = new System.Windows.Forms.TextBox();
            this.ProgressionLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(484, 33);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(52, 18);
            this.AnswerLabel.TabIndex = 0;
            this.AnswerLabel.Text = "label1";
            // 
            // ExplanationText
            // 
            this.ExplanationText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExplanationText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExplanationText.Location = new System.Drawing.Point(137, 72);
            this.ExplanationText.Multiline = true;
            this.ExplanationText.Name = "ExplanationText";
            this.ExplanationText.ReadOnly = true;
            this.ExplanationText.Size = new System.Drawing.Size(713, 204);
            this.ExplanationText.TabIndex = 1;
            this.ExplanationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProgressionLabel
            // 
            this.ProgressionLabel.AutoSize = true;
            this.ProgressionLabel.Location = new System.Drawing.Point(484, 348);
            this.ProgressionLabel.Name = "ProgressionLabel";
            this.ProgressionLabel.Size = new System.Drawing.Size(52, 18);
            this.ProgressionLabel.TabIndex = 2;
            this.ProgressionLabel.Text = "label1";
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(751, 302);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(153, 64);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "次の問題";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // AnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProgressionLabel);
            this.Controls.Add(this.ExplanationText);
            this.Controls.Add(this.AnswerLabel);
            this.Name = "AnswerControl";
            this.Size = new System.Drawing.Size(962, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox ExplanationText;
        private System.Windows.Forms.Label ProgressionLabel;
        private System.Windows.Forms.Button NextButton;
    }
}
