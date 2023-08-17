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
            this.ProgressionLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.ExplanationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AnswerLabel.Location = new System.Drawing.Point(440, 26);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(100, 20);
            this.AnswerLabel.TabIndex = 0;
            this.AnswerLabel.Text = "label1";
            this.AnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressionLabel
            // 
            this.ProgressionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ProgressionLabel.Location = new System.Drawing.Point(398, 398);
            this.ProgressionLabel.Name = "ProgressionLabel";
            this.ProgressionLabel.Size = new System.Drawing.Size(200, 47);
            this.ProgressionLabel.TabIndex = 2;
            this.ProgressionLabel.Text = "label1";
            this.ProgressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(754, 392);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(200, 64);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "次の問題";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ExplanationLabel
            // 
            this.ExplanationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExplanationLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ExplanationLabel.Location = new System.Drawing.Point(100, 100);
            this.ExplanationLabel.Name = "ExplanationLabel";
            this.ExplanationLabel.Size = new System.Drawing.Size(800, 240);
            this.ExplanationLabel.TabIndex = 4;
            this.ExplanationLabel.Text = "label1";
            this.ExplanationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExplanationLabel);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProgressionLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Name = "AnswerControl";
            this.Size = new System.Drawing.Size(1000, 480);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label ProgressionLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label ExplanationLabel;
    }
}
