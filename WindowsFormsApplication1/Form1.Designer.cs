namespace WindowsFormsApplication1
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.comFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSports = new System.Windows.Forms.Label();
            this.rdoBasketball = new System.Windows.Forms.RadioButton();
            this.rdoBaseball = new System.Windows.Forms.RadioButton();
            this.rdoSoccer = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prb1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.trb1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkBold);
            this.groupBox1.Controls.Add(this.comFont);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "그룹1";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(90, 77);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(184, 21);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "Oracle Java";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(367, 33);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(60, 16);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Location = new System.Drawing.Point(313, 31);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(48, 16);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // comFont
            // 
            this.comFont.FormattingEnabled = true;
            this.comFont.Location = new System.Drawing.Point(90, 29);
            this.comFont.Name = "comFont";
            this.comFont.Size = new System.Drawing.Size(184, 20);
            this.comFont.TabIndex = 1;
            this.comFont.SelectedIndexChanged += new System.EventHandler(this.comFont_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "폰트 목록";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSports);
            this.groupBox2.Controls.Add(this.rdoBasketball);
            this.groupBox2.Controls.Add(this.rdoBaseball);
            this.groupBox2.Controls.Add(this.rdoSoccer);
            this.groupBox2.Location = new System.Drawing.Point(12, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 99);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "체크박스";
            // 
            // lblSports
            // 
            this.lblSports.AutoSize = true;
            this.lblSports.Location = new System.Drawing.Point(19, 71);
            this.lblSports.Name = "lblSports";
            this.lblSports.Size = new System.Drawing.Size(85, 12);
            this.lblSports.TabIndex = 3;
            this.lblSports.Text = "선택 되지 않음";
            // 
            // rdoBasketball
            // 
            this.rdoBasketball.AutoSize = true;
            this.rdoBasketball.Location = new System.Drawing.Point(218, 36);
            this.rdoBasketball.Name = "rdoBasketball";
            this.rdoBasketball.Size = new System.Drawing.Size(92, 16);
            this.rdoBasketball.TabIndex = 2;
            this.rdoBasketball.TabStop = true;
            this.rdoBasketball.Text = "radioButton3";
            this.rdoBasketball.UseVisualStyleBackColor = true;
            this.rdoBasketball.CheckedChanged += new System.EventHandler(this.rdoBasketball_CheckedChanged);
            // 
            // rdoBaseball
            // 
            this.rdoBaseball.AutoSize = true;
            this.rdoBaseball.Location = new System.Drawing.Point(119, 36);
            this.rdoBaseball.Name = "rdoBaseball";
            this.rdoBaseball.Size = new System.Drawing.Size(92, 16);
            this.rdoBaseball.TabIndex = 1;
            this.rdoBaseball.TabStop = true;
            this.rdoBaseball.Text = "radioButton2";
            this.rdoBaseball.UseVisualStyleBackColor = true;
            this.rdoBaseball.CheckedChanged += new System.EventHandler(this.rdoBaseball_CheckedChanged);
            // 
            // rdoSoccer
            // 
            this.rdoSoccer.AutoSize = true;
            this.rdoSoccer.Location = new System.Drawing.Point(21, 36);
            this.rdoSoccer.Name = "rdoSoccer";
            this.rdoSoccer.Size = new System.Drawing.Size(92, 16);
            this.rdoSoccer.TabIndex = 0;
            this.rdoSoccer.TabStop = true;
            this.rdoSoccer.Text = "radioButton1";
            this.rdoSoccer.UseVisualStyleBackColor = true;
            this.rdoSoccer.CheckedChanged += new System.EventHandler(this.rdoSoccer_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.prb1);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.trb1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // prb1
            // 
            this.prb1.Location = new System.Drawing.Point(21, 109);
            this.prb1.Name = "prb1";
            this.prb1.Size = new System.Drawing.Size(406, 23);
            this.prb1.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(218, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "button2";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // trb1
            // 
            this.trb1.Location = new System.Drawing.Point(21, 58);
            this.trb1.Name = "trb1";
            this.trb1.Size = new System.Drawing.Size(406, 45);
            this.trb1.TabIndex = 1;
            this.trb1.Scroll += new System.EventHandler(this.trb1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TrackBar, ProgressBar 컨트롤 테스트";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox comFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSports;
        private System.Windows.Forms.RadioButton rdoBasketball;
        private System.Windows.Forms.RadioButton rdoBaseball;
        private System.Windows.Forms.RadioButton rdoSoccer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar prb1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TrackBar trb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

