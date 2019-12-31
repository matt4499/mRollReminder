namespace RollReminder
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.TimeLeftLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RollTimer = new System.Windows.Forms.Timer(this.components);
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.AutoRollInputText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AutoRollInputNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.AutoRollCountdown = new System.Windows.Forms.Timer(this.components);
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(129, 121);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(61, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 125);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Remind me in";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(196, 125);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "minutes to roll.";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(128, 154);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Start";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(128, 202);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(62, 36);
            this.materialFlatButton2.TabIndex = 5;
            this.materialFlatButton2.Text = "RESET";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(67, 300);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Reminding in:";
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.AutoSize = true;
            this.TimeLeftLabel.Depth = 0;
            this.TimeLeftLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TimeLeftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeLeftLabel.Location = new System.Drawing.Point(196, 300);
            this.TimeLeftLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(50, 19);
            this.TimeLeftLabel.TabIndex = 7;
            this.TimeLeftLabel.Text = "NONE";
            // 
            // RollTimer
            // 
            this.RollTimer.Tick += new System.EventHandler(this.RollTimer_Tick);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(432, 84);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "AutoRoll";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(125, 84);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Reminder";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(369, 135);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(97, 19);
            this.materialLabel7.TabIndex = 11;
            this.materialLabel7.Text = "What to type:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(340, 169);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(126, 19);
            this.materialLabel8.TabIndex = 12;
            this.materialLabel8.Text = "How many times:";
            // 
            // AutoRollInputText
            // 
            this.AutoRollInputText.Depth = 0;
            this.AutoRollInputText.Hint = "";
            this.AutoRollInputText.Location = new System.Drawing.Point(472, 135);
            this.AutoRollInputText.MaxLength = 32767;
            this.AutoRollInputText.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoRollInputText.Name = "AutoRollInputText";
            this.AutoRollInputText.PasswordChar = '\0';
            this.AutoRollInputText.SelectedText = "";
            this.AutoRollInputText.SelectionLength = 0;
            this.AutoRollInputText.SelectionStart = 0;
            this.AutoRollInputText.Size = new System.Drawing.Size(60, 23);
            this.AutoRollInputText.TabIndex = 13;
            this.AutoRollInputText.TabStop = false;
            this.AutoRollInputText.Text = "$w";
            this.AutoRollInputText.UseSystemPasswordChar = false;
            // 
            // AutoRollInputNumber
            // 
            this.AutoRollInputNumber.Depth = 0;
            this.AutoRollInputNumber.Hint = "";
            this.AutoRollInputNumber.Location = new System.Drawing.Point(472, 169);
            this.AutoRollInputNumber.MaxLength = 32767;
            this.AutoRollInputNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoRollInputNumber.Name = "AutoRollInputNumber";
            this.AutoRollInputNumber.PasswordChar = '\0';
            this.AutoRollInputNumber.SelectedText = "";
            this.AutoRollInputNumber.SelectionLength = 0;
            this.AutoRollInputNumber.SelectionStart = 0;
            this.AutoRollInputNumber.Size = new System.Drawing.Size(60, 23);
            this.AutoRollInputNumber.TabIndex = 14;
            this.AutoRollInputNumber.TabStop = false;
            this.AutoRollInputNumber.Text = "14";
            this.AutoRollInputNumber.UseSystemPasswordChar = false;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(396, 202);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(136, 36);
            this.materialFlatButton3.TabIndex = 15;
            this.materialFlatButton3.Text = "Start AutoRoll";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Icon = null;
            this.materialFlatButton4.Location = new System.Drawing.Point(410, 250);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(109, 36);
            this.materialFlatButton4.TabIndex = 16;
            this.materialFlatButton4.Text = "HOW TO USE?";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // AutoRollCountdown
            // 
            this.AutoRollCountdown.Interval = 1000;
            this.AutoRollCountdown.Tick += new System.EventHandler(this.AutoRollCountdown_Tick);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(373, 300);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(159, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "mRollReminder ver 0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 341);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.AutoRollInputNumber);
            this.Controls.Add(this.AutoRollInputText);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mRollReminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel TimeLeftLabel;
        private System.Windows.Forms.Timer RollTimer;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField AutoRollInputText;
        private MaterialSkin.Controls.MaterialSingleLineTextField AutoRollInputNumber;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private System.Windows.Forms.Timer AutoRollCountdown;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}

