namespace DeskCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.resultText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiButton = new System.Windows.Forms.Button();
            this.devideButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearEntryButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(26, 29);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(388, 19);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "0";
            this.resultText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 1;
            this.button1.Tag = "";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.interNumber);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 42);
            this.button2.TabIndex = 2;
            this.button2.Tag = "";
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.interNumber);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 42);
            this.button3.TabIndex = 3;
            this.button3.Tag = "";
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.interNumber);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(42, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 42);
            this.button4.TabIndex = 4;
            this.button4.Tag = "";
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.interNumber);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(124, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 42);
            this.button5.TabIndex = 5;
            this.button5.Tag = "";
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.interNumber);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 42);
            this.button6.TabIndex = 6;
            this.button6.Tag = "";
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.interNumber);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(42, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 42);
            this.button7.TabIndex = 7;
            this.button7.Tag = "";
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.interNumber);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(124, 108);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 42);
            this.button8.TabIndex = 8;
            this.button8.Tag = "";
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.interNumber);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(206, 108);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 42);
            this.button9.TabIndex = 9;
            this.button9.Tag = "";
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.interNumber);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(42, 357);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(124, 42);
            this.button0.TabIndex = 10;
            this.button0.Tag = "";
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.interNumber);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(372, 275);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(42, 124);
            this.equalButton.TabIndex = 11;
            this.equalButton.Tag = "";
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.operate);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(290, 275);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(42, 42);
            this.plusButton.TabIndex = 12;
            this.plusButton.Tag = "";
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operate);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(290, 357);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(42, 42);
            this.minusButton.TabIndex = 13;
            this.minusButton.Tag = "";
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.operate);
            // 
            // multiButton
            // 
            this.multiButton.Location = new System.Drawing.Point(290, 192);
            this.multiButton.Name = "multiButton";
            this.multiButton.Size = new System.Drawing.Size(42, 42);
            this.multiButton.TabIndex = 14;
            this.multiButton.Tag = "";
            this.multiButton.Text = "*";
            this.multiButton.UseVisualStyleBackColor = true;
            this.multiButton.Click += new System.EventHandler(this.operate);
            // 
            // devideButton
            // 
            this.devideButton.Location = new System.Drawing.Point(290, 108);
            this.devideButton.Name = "devideButton";
            this.devideButton.Size = new System.Drawing.Size(42, 42);
            this.devideButton.TabIndex = 15;
            this.devideButton.Tag = "";
            this.devideButton.Text = "/";
            this.devideButton.UseVisualStyleBackColor = true;
            this.devideButton.Click += new System.EventHandler(this.operate);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(372, 108);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(42, 42);
            this.clearAllButton.TabIndex = 16;
            this.clearAllButton.Tag = "";
            this.clearAllButton.Text = "C";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.culc_clear);
            // 
            // clearEntryButton
            // 
            this.clearEntryButton.Location = new System.Drawing.Point(372, 192);
            this.clearEntryButton.Name = "clearEntryButton";
            this.clearEntryButton.Size = new System.Drawing.Size(42, 42);
            this.clearEntryButton.TabIndex = 17;
            this.clearEntryButton.Tag = "";
            this.clearEntryButton.Text = "CE";
            this.clearEntryButton.UseVisualStyleBackColor = true;
            this.clearEntryButton.Click += new System.EventHandler(this.culc_clear);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(206, 357);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(42, 42);
            this.dotButton.TabIndex = 18;
            this.dotButton.Tag = "";
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.interNumber);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 433);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.clearEntryButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.devideButton);
            this.Controls.Add(this.multiButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiButton;
        private System.Windows.Forms.Button devideButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearEntryButton;
        private System.Windows.Forms.Button dotButton;
    }
}

