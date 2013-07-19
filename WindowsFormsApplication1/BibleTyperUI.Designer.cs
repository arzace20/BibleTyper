namespace BibleTyper
{
    partial class BibleTyperUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RunButton = new System.Windows.Forms.Button();
            this.BookSelectBox = new System.Windows.Forms.ComboBox();
            this.StartRadio = new System.Windows.Forms.RadioButton();
            this.ResumeRadio = new System.Windows.Forms.RadioButton();
            this.ResumeLabel = new System.Windows.Forms.Label();
            this.BibleSelectComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(176, 139);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // BookSelectBox
            // 
            this.BookSelectBox.FormattingEnabled = true;
            this.BookSelectBox.Items.AddRange(new object[] {
            "창세기",
            "출애굽기",
            "레위기",
            "민수기",
            "신명기",
            "여호수아",
            "사사기",
            "룻기",
            "사무엘상",
            "사무엘하",
            "열왕기상",
            "열왕기하",
            "역대상",
            "역대하",
            "에스라",
            "느헤미야",
            "에스더",
            "욥기",
            "시편",
            "잠언",
            "전도",
            "아사",
            "이사야",
            "예레미야",
            "예레미야애가",
            "에스겔",            
            "다니엘",
            "호세아",
            "요엘",
            "아모스",
            "오바댜",
            "요나",
            "미가",
            "나훔",
            "하박국",
            "스바냐",
            "학개",
            "스가랴",
            "말라기",
            "마태복음",
            "마가복음",
            "누가복음",
            "요한복음",
            "사도행전",
            "로마서",
            "고린도전서",
            "고린도후서",
            "갈라디아서",
            "에베소서",
            "빌립보서",
            "골로새서",
            "데살로니가전서",
            "데살로니가후서",
            "디모데전서",
            "디모데후서",
            "디도서",
            "빌레몬서",
            "히브리서",
            "야고보서",
            "베드로전서",
            "베드로후서",
            "요한1서",
            "요한2서",
            "요한3서",
            "유다서",
            "요한계시록"});
            this.BookSelectBox.Location = new System.Drawing.Point(163, 96);
            this.BookSelectBox.Name = "BookSelectBox";
            this.BookSelectBox.Size = new System.Drawing.Size(121, 21);
            this.BookSelectBox.TabIndex = 1;
            this.BookSelectBox.Text = "Select Book";
            // 
            // StartRadio
            // 
            this.StartRadio.AutoSize = true;
            this.StartRadio.Location = new System.Drawing.Point(93, 96);
            this.StartRadio.Name = "StartRadio";
            this.StartRadio.Size = new System.Drawing.Size(47, 17);
            this.StartRadio.TabIndex = 2;
            this.StartRadio.TabStop = true;
            this.StartRadio.Text = "Start";
            this.StartRadio.UseVisualStyleBackColor = true;
            this.StartRadio.CheckedChanged += new System.EventHandler(this.StartRadio_CheckedChanged);
            // 
            // ResumeRadio
            // 
            this.ResumeRadio.AutoSize = true;
            this.ResumeRadio.Location = new System.Drawing.Point(93, 73);
            this.ResumeRadio.Name = "ResumeRadio";
            this.ResumeRadio.Size = new System.Drawing.Size(64, 17);
            this.ResumeRadio.TabIndex = 3;
            this.ResumeRadio.TabStop = true;
            this.ResumeRadio.Text = "Resume";
            this.ResumeRadio.UseVisualStyleBackColor = true;
            this.ResumeRadio.CheckedChanged += new System.EventHandler(this.ResumeRadio_CheckedChanged);
            // 
            // ResumeLabel
            // 
            this.ResumeLabel.AutoSize = true;
            this.ResumeLabel.Location = new System.Drawing.Point(163, 75);
            this.ResumeLabel.Name = "ResumeLabel";
            this.ResumeLabel.Size = new System.Drawing.Size(102, 13);
            this.ResumeLabel.TabIndex = 4;
            this.ResumeLabel.Text = "Resume from before";
            // 
            // BibleSelectComboBox
            // 
            this.BibleSelectComboBox.FormattingEnabled = true;
            this.BibleSelectComboBox.Location = new System.Drawing.Point(163, 51);
            this.BibleSelectComboBox.Name = "BibleSelectComboBox";
            this.BibleSelectComboBox.Size = new System.Drawing.Size(121, 21);
            this.BibleSelectComboBox.TabIndex = 5;
            this.BibleSelectComboBox.Text = "Select Bible";
            this.BibleSelectComboBox.Items.AddRange(new object[] {
                "한글성경",
                "쉬운성경",
                "영어성경",
            });
            // 
            // BibleTyperUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 316);
            this.Controls.Add(this.BibleSelectComboBox);
            this.Controls.Add(this.ResumeLabel);
            this.Controls.Add(this.ResumeRadio);
            this.Controls.Add(this.StartRadio);
            this.Controls.Add(this.BookSelectBox);
            this.Controls.Add(this.RunButton);
            this.Name = "BibleTyperUI";
            this.Text = "BibleTyper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ComboBox BookSelectBox;
        private System.Windows.Forms.RadioButton StartRadio;
        private System.Windows.Forms.RadioButton ResumeRadio;
        private System.Windows.Forms.Label ResumeLabel;
        private System.Windows.Forms.ComboBox BibleSelectComboBox;
    }
}

