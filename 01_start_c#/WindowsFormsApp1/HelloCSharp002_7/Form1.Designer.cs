﻿namespace HelloCSharp002_7
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.th1 = new System.Windows.Forms.Label();
            this.th2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // th1
            // 
            this.th1.AutoSize = true;
            this.th1.Location = new System.Drawing.Point(112, 26);
            this.th1.Name = "th1";
            this.th1.Size = new System.Drawing.Size(69, 12);
            this.th1.TabIndex = 4;
            this.th1.Text = "숫자만 입력";
            // 
            // th2
            // 
            this.th2.AutoSize = true;
            this.th2.Location = new System.Drawing.Point(308, 26);
            this.th2.Name = "th2";
            this.th2.Size = new System.Drawing.Size(29, 12);
            this.th2.TabIndex = 5;
            this.th2.Text = "정답";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 38);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(74, 35);
            this.start.TabIndex = 6;
            this.start.Text = "숫자 뽑기";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 91);
            this.Controls.Add(this.start);
            this.Controls.Add(this.th2);
            this.Controls.Add(this.th1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "숫자 맞히기 게임";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label th1;
        private System.Windows.Forms.Label th2;
        private System.Windows.Forms.Button start;
    }
}

