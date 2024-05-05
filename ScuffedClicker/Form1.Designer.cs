namespace ScuffedClicker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPSTrackbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.CPSValue = new System.Windows.Forms.Label();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.randomTB = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.bindBtn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Binding = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Extremely Scuffed Clicker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Left Click CPS";
            // 
            // CPSTrackbar
            // 
            this.CPSTrackbar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPSTrackbar.FillColor = System.Drawing.Color.White;
            this.CPSTrackbar.Location = new System.Drawing.Point(18, 57);
            this.CPSTrackbar.Maximum = 20;
            this.CPSTrackbar.Minimum = 6;
            this.CPSTrackbar.Name = "CPSTrackbar";
            this.CPSTrackbar.Size = new System.Drawing.Size(278, 23);
            this.CPSTrackbar.TabIndex = 2;
            this.CPSTrackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.CPSTrackbar.Value = 10;
            this.CPSTrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSTrackbar_Scroll);
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPSValue.ForeColor = System.Drawing.Color.White;
            this.CPSValue.Location = new System.Drawing.Point(301, 60);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(51, 16);
            this.CPSValue.TabIndex = 3;
            this.CPSValue.Text = "10 CPS";
            // 
            // Autoclicker
            // 
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.CheckedState.FillColor = System.Drawing.Color.Red;
            this.btnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnToggle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Location = new System.Drawing.Point(304, 162);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.btnToggle.Size = new System.Drawing.Size(88, 87);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Enable";
            this.btnToggle.TextChanged += new System.EventHandler(this.btnToggle_TextChanged);
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Random
            // 
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // randomTB
            // 
            this.randomTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.randomTB.FillColor = System.Drawing.Color.White;
            this.randomTB.Location = new System.Drawing.Point(10, 195);
            this.randomTB.Maximum = 30;
            this.randomTB.Name = "randomTB";
            this.randomTB.Size = new System.Drawing.Size(278, 23);
            this.randomTB.TabIndex = 5;
            this.randomTB.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.randomTB.Value = 10;
            this.randomTB.Visible = false;
            // 
            // bindBtn
            // 
            this.bindBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bindBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bindBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bindBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bindBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.bindBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindBtn.ForeColor = System.Drawing.Color.White;
            this.bindBtn.Location = new System.Drawing.Point(318, 126);
            this.bindBtn.Name = "bindBtn";
            this.bindBtn.Size = new System.Drawing.Size(62, 30);
            this.bindBtn.TabIndex = 6;
            this.bindBtn.Text = "none";
            this.bindBtn.Click += new System.EventHandler(this.bindBtn_Click);
            this.bindBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bindBtn_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(252, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key Bind:";
            // 
            // Binding
            // 
            this.Binding.Enabled = true;
            this.Binding.Tick += new System.EventHandler(this.Binding_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bindBtn);
            this.Controls.Add(this.randomTB);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.CPSTrackbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ScuffedClicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackbar;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Timer Autoclicker;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton btnToggle;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar randomTB;
        private Siticone.Desktop.UI.WinForms.SiticoneButton bindBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Binding;
    }
}

