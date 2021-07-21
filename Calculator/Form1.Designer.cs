namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultLabel = new System.Windows.Forms.Label();
            this.expressionLabel = new System.Windows.Forms.Label();
            this.memoryClearBtn = new System.Windows.Forms.Button();
            this.memoryReadBtn = new System.Windows.Forms.Button();
            this.memorySaveBtn = new System.Windows.Forms.Button();
            this.AddToMemoryBtn = new System.Windows.Forms.Button();
            this.SubtractFromMomoryBtn = new System.Windows.Forms.Button();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.changeSignBtn = new System.Windows.Forms.Button();
            this.rootBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.divisionBtn = new System.Windows.Forms.Button();
            this.percentBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.multiplicationBtn = new System.Windows.Forms.Button();
            this.reciprocalBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.decimalPointBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.equalsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Controls.Add(this.expressionLabel);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 63);
            this.panel1.TabIndex = 0;
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultLabel.Location = new System.Drawing.Point(0, 16);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(282, 45);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // expressionLabel
            // 
            this.expressionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expressionLabel.Location = new System.Drawing.Point(0, 0);
            this.expressionLabel.Name = "expressionLabel";
            this.expressionLabel.Size = new System.Drawing.Size(282, 16);
            this.expressionLabel.TabIndex = 0;
            this.expressionLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // memoryClearBtn
            // 
            this.memoryClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryClearBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.memoryClearBtn.Location = new System.Drawing.Point(13, 83);
            this.memoryClearBtn.Name = "memoryClearBtn";
            this.memoryClearBtn.Size = new System.Drawing.Size(52, 38);
            this.memoryClearBtn.TabIndex = 1;
            this.memoryClearBtn.Text = "MC";
            this.memoryClearBtn.UseVisualStyleBackColor = true;
            this.memoryClearBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // memoryReadBtn
            // 
            this.memoryReadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryReadBtn.Location = new System.Drawing.Point(71, 83);
            this.memoryReadBtn.Name = "memoryReadBtn";
            this.memoryReadBtn.Size = new System.Drawing.Size(52, 38);
            this.memoryReadBtn.TabIndex = 2;
            this.memoryReadBtn.Text = "MR";
            this.memoryReadBtn.UseVisualStyleBackColor = true;
            this.memoryReadBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // memorySaveBtn
            // 
            this.memorySaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memorySaveBtn.Location = new System.Drawing.Point(129, 83);
            this.memorySaveBtn.Name = "memorySaveBtn";
            this.memorySaveBtn.Size = new System.Drawing.Size(52, 38);
            this.memorySaveBtn.TabIndex = 3;
            this.memorySaveBtn.Text = "MS";
            this.memorySaveBtn.UseVisualStyleBackColor = true;
            this.memorySaveBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // AddToMemoryBtn
            // 
            this.AddToMemoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToMemoryBtn.Location = new System.Drawing.Point(187, 83);
            this.AddToMemoryBtn.Name = "AddToMemoryBtn";
            this.AddToMemoryBtn.Size = new System.Drawing.Size(52, 38);
            this.AddToMemoryBtn.TabIndex = 4;
            this.AddToMemoryBtn.Text = "M+";
            this.AddToMemoryBtn.UseVisualStyleBackColor = true;
            this.AddToMemoryBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // SubtractFromMomoryBtn
            // 
            this.SubtractFromMomoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractFromMomoryBtn.Location = new System.Drawing.Point(245, 83);
            this.SubtractFromMomoryBtn.Name = "SubtractFromMomoryBtn";
            this.SubtractFromMomoryBtn.Size = new System.Drawing.Size(52, 38);
            this.SubtractFromMomoryBtn.TabIndex = 5;
            this.SubtractFromMomoryBtn.Text = "M-";
            this.SubtractFromMomoryBtn.UseVisualStyleBackColor = true;
            this.SubtractFromMomoryBtn.Click += new System.EventHandler(this.memoryBtn_Click);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.backspaceBtn.Location = new System.Drawing.Point(13, 127);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(52, 38);
            this.backspaceBtn.TabIndex = 6;
            this.backspaceBtn.Text = "←";
            this.backspaceBtn.UseVisualStyleBackColor = false;
            this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sevenBtn.Location = new System.Drawing.Point(13, 171);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(52, 38);
            this.sevenBtn.TabIndex = 7;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fourBtn.Location = new System.Drawing.Point(13, 215);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(52, 38);
            this.fourBtn.TabIndex = 8;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.oneBtn.Location = new System.Drawing.Point(13, 259);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(52, 38);
            this.oneBtn.TabIndex = 9;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.zeroBtn.Location = new System.Drawing.Point(13, 303);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(110, 38);
            this.zeroBtn.TabIndex = 10;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearEntryBtn.Location = new System.Drawing.Point(71, 127);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(52, 38);
            this.clearEntryBtn.TabIndex = 11;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = false;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearBtn.Location = new System.Drawing.Point(129, 127);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(52, 38);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // changeSignBtn
            // 
            this.changeSignBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.changeSignBtn.Location = new System.Drawing.Point(187, 127);
            this.changeSignBtn.Name = "changeSignBtn";
            this.changeSignBtn.Size = new System.Drawing.Size(52, 38);
            this.changeSignBtn.TabIndex = 13;
            this.changeSignBtn.Text = "±";
            this.changeSignBtn.UseVisualStyleBackColor = false;
            this.changeSignBtn.Click += new System.EventHandler(this.changeSignBtn_Click);
            // 
            // rootBtn
            // 
            this.rootBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rootBtn.Location = new System.Drawing.Point(245, 127);
            this.rootBtn.Name = "rootBtn";
            this.rootBtn.Size = new System.Drawing.Size(52, 38);
            this.rootBtn.TabIndex = 14;
            this.rootBtn.Text = "√";
            this.rootBtn.UseVisualStyleBackColor = false;
            this.rootBtn.Click += new System.EventHandler(this.immediateOperatorBtns_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eightBtn.Location = new System.Drawing.Point(71, 171);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(52, 38);
            this.eightBtn.TabIndex = 15;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nineBtn.Location = new System.Drawing.Point(129, 171);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(52, 38);
            this.nineBtn.TabIndex = 16;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // divisionBtn
            // 
            this.divisionBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.divisionBtn.Location = new System.Drawing.Point(187, 171);
            this.divisionBtn.Name = "divisionBtn";
            this.divisionBtn.Size = new System.Drawing.Size(52, 38);
            this.divisionBtn.TabIndex = 17;
            this.divisionBtn.Text = "/";
            this.divisionBtn.UseVisualStyleBackColor = false;
            this.divisionBtn.Click += new System.EventHandler(this.easternOperatorsBtns_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.percentBtn.Location = new System.Drawing.Point(245, 171);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(52, 38);
            this.percentBtn.TabIndex = 18;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = false;
            this.percentBtn.Click += new System.EventHandler(this.immediateOperatorBtns_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fiveBtn.Location = new System.Drawing.Point(71, 215);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(52, 38);
            this.fiveBtn.TabIndex = 19;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sixBtn.Location = new System.Drawing.Point(129, 215);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(52, 38);
            this.sixBtn.TabIndex = 20;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // multiplicationBtn
            // 
            this.multiplicationBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.multiplicationBtn.Location = new System.Drawing.Point(187, 215);
            this.multiplicationBtn.Name = "multiplicationBtn";
            this.multiplicationBtn.Size = new System.Drawing.Size(52, 38);
            this.multiplicationBtn.TabIndex = 21;
            this.multiplicationBtn.Text = "*";
            this.multiplicationBtn.UseVisualStyleBackColor = false;
            this.multiplicationBtn.Click += new System.EventHandler(this.easternOperatorsBtns_Click);
            // 
            // reciprocalBtn
            // 
            this.reciprocalBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.reciprocalBtn.Location = new System.Drawing.Point(245, 215);
            this.reciprocalBtn.Name = "reciprocalBtn";
            this.reciprocalBtn.Size = new System.Drawing.Size(52, 38);
            this.reciprocalBtn.TabIndex = 22;
            this.reciprocalBtn.Text = "1/x";
            this.reciprocalBtn.UseVisualStyleBackColor = false;
            this.reciprocalBtn.Click += new System.EventHandler(this.immediateOperatorBtns_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.twoBtn.Location = new System.Drawing.Point(71, 259);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(52, 38);
            this.twoBtn.TabIndex = 23;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.threeBtn.Location = new System.Drawing.Point(129, 259);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(52, 38);
            this.threeBtn.TabIndex = 24;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.minusBtn.Location = new System.Drawing.Point(187, 259);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(52, 38);
            this.minusBtn.TabIndex = 25;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.easternOperatorsBtns_Click);
            // 
            // decimalPointBtn
            // 
            this.decimalPointBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.decimalPointBtn.Location = new System.Drawing.Point(129, 303);
            this.decimalPointBtn.Name = "decimalPointBtn";
            this.decimalPointBtn.Size = new System.Drawing.Size(52, 38);
            this.decimalPointBtn.TabIndex = 26;
            this.decimalPointBtn.Text = ".";
            this.decimalPointBtn.UseVisualStyleBackColor = false;
            this.decimalPointBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plusBtn.Location = new System.Drawing.Point(187, 303);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(52, 38);
            this.plusBtn.TabIndex = 27;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.easternOperatorsBtns_Click);
            // 
            // equalsBtn
            // 
            this.equalsBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.equalsBtn.Location = new System.Drawing.Point(245, 259);
            this.equalsBtn.Name = "equalsBtn";
            this.equalsBtn.Size = new System.Drawing.Size(52, 82);
            this.equalsBtn.TabIndex = 28;
            this.equalsBtn.Text = "=";
            this.equalsBtn.UseVisualStyleBackColor = false;
            this.equalsBtn.Click += new System.EventHandler(this.equalsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(311, 356);
            this.Controls.Add(this.equalsBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.decimalPointBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.reciprocalBtn);
            this.Controls.Add(this.multiplicationBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.percentBtn);
            this.Controls.Add(this.divisionBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.rootBtn);
            this.Controls.Add(this.changeSignBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.clearEntryBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.backspaceBtn);
            this.Controls.Add(this.SubtractFromMomoryBtn);
            this.Controls.Add(this.AddToMemoryBtn);
            this.Controls.Add(this.memorySaveBtn);
            this.Controls.Add(this.memoryReadBtn);
            this.Controls.Add(this.memoryClearBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.Button memoryClearBtn;
        private System.Windows.Forms.Button memoryReadBtn;
        private System.Windows.Forms.Button memorySaveBtn;
        private System.Windows.Forms.Button AddToMemoryBtn;
        private System.Windows.Forms.Button SubtractFromMomoryBtn;
        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button changeSignBtn;
        private System.Windows.Forms.Button rootBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button divisionBtn;
        private System.Windows.Forms.Button percentBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button multiplicationBtn;
        private System.Windows.Forms.Button reciprocalBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button decimalPointBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button equalsBtn;
    }
}

