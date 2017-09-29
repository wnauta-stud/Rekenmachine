namespace Week3_Opgave_2
{
    partial class Rekenmachine
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
            this.zeven = new System.Windows.Forms.Button();
            this.acht = new System.Windows.Forms.Button();
            this.negen = new System.Windows.Forms.Button();
            this.delen = new System.Windows.Forms.Button();
            this.maal = new System.Windows.Forms.Button();
            this.zes = new System.Windows.Forms.Button();
            this.vijf = new System.Windows.Forms.Button();
            this.vier = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.drie = new System.Windows.Forms.Button();
            this.twee = new System.Windows.Forms.Button();
            this.een = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.macht = new System.Windows.Forms.Button();
            this.komma = new System.Windows.Forms.Button();
            this.nul = new System.Windows.Forms.Button();
            this.berekenen = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.sluitingshaak = new System.Windows.Forms.Button();
            this.openingshaak = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zeven
            // 
            this.zeven.BackColor = System.Drawing.Color.Silver;
            this.zeven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zeven.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.zeven.ForeColor = System.Drawing.Color.RoyalBlue;
            this.zeven.Location = new System.Drawing.Point(25, 164);
            this.zeven.Name = "zeven";
            this.zeven.Size = new System.Drawing.Size(180, 105);
            this.zeven.TabIndex = 1;
            this.zeven.Text = "7";
            this.zeven.UseVisualStyleBackColor = false;
            this.zeven.Click += new System.EventHandler(this.number_Click);
            // 
            // acht
            // 
            this.acht.BackColor = System.Drawing.Color.Silver;
            this.acht.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.acht.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.acht.ForeColor = System.Drawing.Color.RoyalBlue;
            this.acht.Location = new System.Drawing.Point(231, 164);
            this.acht.Name = "acht";
            this.acht.Size = new System.Drawing.Size(180, 105);
            this.acht.TabIndex = 2;
            this.acht.Text = "8";
            this.acht.UseVisualStyleBackColor = false;
            this.acht.Click += new System.EventHandler(this.number_Click);
            // 
            // negen
            // 
            this.negen.BackColor = System.Drawing.Color.Silver;
            this.negen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.negen.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.negen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.negen.Location = new System.Drawing.Point(435, 164);
            this.negen.Name = "negen";
            this.negen.Size = new System.Drawing.Size(180, 105);
            this.negen.TabIndex = 3;
            this.negen.Text = "9";
            this.negen.UseVisualStyleBackColor = false;
            this.negen.Click += new System.EventHandler(this.number_Click);
            // 
            // delen
            // 
            this.delen.BackColor = System.Drawing.Color.Moccasin;
            this.delen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delen.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.delen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.delen.Location = new System.Drawing.Point(640, 164);
            this.delen.Name = "delen";
            this.delen.Size = new System.Drawing.Size(180, 105);
            this.delen.TabIndex = 4;
            this.delen.Text = "/";
            this.delen.UseVisualStyleBackColor = false;
            this.delen.Click += new System.EventHandler(this.tekens_Click);
            // 
            // maal
            // 
            this.maal.BackColor = System.Drawing.Color.Moccasin;
            this.maal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.maal.Font = new System.Drawing.Font("Impact", 50F);
            this.maal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.maal.Location = new System.Drawing.Point(640, 307);
            this.maal.Name = "maal";
            this.maal.Size = new System.Drawing.Size(180, 105);
            this.maal.TabIndex = 8;
            this.maal.Text = "*";
            this.maal.UseVisualStyleBackColor = false;
            this.maal.Click += new System.EventHandler(this.tekens_Click);
            // 
            // zes
            // 
            this.zes.BackColor = System.Drawing.Color.Silver;
            this.zes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.zes.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.zes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.zes.Location = new System.Drawing.Point(435, 307);
            this.zes.Name = "zes";
            this.zes.Size = new System.Drawing.Size(180, 105);
            this.zes.TabIndex = 7;
            this.zes.Text = "6";
            this.zes.UseVisualStyleBackColor = false;
            this.zes.Click += new System.EventHandler(this.number_Click);
            // 
            // vijf
            // 
            this.vijf.BackColor = System.Drawing.Color.Silver;
            this.vijf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.vijf.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.vijf.ForeColor = System.Drawing.Color.RoyalBlue;
            this.vijf.Location = new System.Drawing.Point(231, 307);
            this.vijf.Name = "vijf";
            this.vijf.Size = new System.Drawing.Size(180, 105);
            this.vijf.TabIndex = 6;
            this.vijf.Text = "5";
            this.vijf.UseVisualStyleBackColor = false;
            this.vijf.Click += new System.EventHandler(this.number_Click);
            // 
            // vier
            // 
            this.vier.BackColor = System.Drawing.Color.Silver;
            this.vier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.vier.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.vier.ForeColor = System.Drawing.Color.RoyalBlue;
            this.vier.Location = new System.Drawing.Point(25, 307);
            this.vier.Name = "vier";
            this.vier.Size = new System.Drawing.Size(180, 105);
            this.vier.TabIndex = 5;
            this.vier.Text = "4";
            this.vier.UseVisualStyleBackColor = false;
            this.vier.Click += new System.EventHandler(this.number_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.Moccasin;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.plus.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.plus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.plus.Location = new System.Drawing.Point(640, 451);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(180, 105);
            this.plus.TabIndex = 12;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.tekens_Click);
            // 
            // drie
            // 
            this.drie.BackColor = System.Drawing.Color.Silver;
            this.drie.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.drie.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.drie.ForeColor = System.Drawing.Color.RoyalBlue;
            this.drie.Location = new System.Drawing.Point(435, 451);
            this.drie.Name = "drie";
            this.drie.Size = new System.Drawing.Size(180, 105);
            this.drie.TabIndex = 11;
            this.drie.Text = "3";
            this.drie.UseVisualStyleBackColor = false;
            this.drie.Click += new System.EventHandler(this.number_Click);
            // 
            // twee
            // 
            this.twee.BackColor = System.Drawing.Color.Silver;
            this.twee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.twee.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.twee.ForeColor = System.Drawing.Color.RoyalBlue;
            this.twee.Location = new System.Drawing.Point(231, 451);
            this.twee.Name = "twee";
            this.twee.Size = new System.Drawing.Size(180, 105);
            this.twee.TabIndex = 10;
            this.twee.Text = "2";
            this.twee.UseVisualStyleBackColor = false;
            this.twee.Click += new System.EventHandler(this.number_Click);
            // 
            // een
            // 
            this.een.BackColor = System.Drawing.Color.Silver;
            this.een.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.een.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.een.ForeColor = System.Drawing.Color.RoyalBlue;
            this.een.Location = new System.Drawing.Point(25, 451);
            this.een.Name = "een";
            this.een.Size = new System.Drawing.Size(180, 105);
            this.een.TabIndex = 9;
            this.een.Text = "1";
            this.een.UseVisualStyleBackColor = false;
            this.een.Click += new System.EventHandler(this.number_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Moccasin;
            this.min.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.min.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.min.ForeColor = System.Drawing.Color.RoyalBlue;
            this.min.Location = new System.Drawing.Point(640, 592);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(180, 105);
            this.min.TabIndex = 16;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.tekens_Click);
            // 
            // macht
            // 
            this.macht.BackColor = System.Drawing.Color.Moccasin;
            this.macht.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.macht.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.macht.ForeColor = System.Drawing.Color.RoyalBlue;
            this.macht.Location = new System.Drawing.Point(435, 592);
            this.macht.Name = "macht";
            this.macht.Size = new System.Drawing.Size(180, 105);
            this.macht.TabIndex = 15;
            this.macht.Text = "^";
            this.macht.UseVisualStyleBackColor = false;
            this.macht.Click += new System.EventHandler(this.macht_Click);
            // 
            // komma
            // 
            this.komma.BackColor = System.Drawing.Color.Moccasin;
            this.komma.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.komma.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.komma.ForeColor = System.Drawing.Color.RoyalBlue;
            this.komma.Location = new System.Drawing.Point(231, 592);
            this.komma.Name = "komma";
            this.komma.Size = new System.Drawing.Size(180, 105);
            this.komma.TabIndex = 14;
            this.komma.Text = ",";
            this.komma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.komma.UseVisualStyleBackColor = false;
            this.komma.Click += new System.EventHandler(this.komma_Click);
            // 
            // nul
            // 
            this.nul.BackColor = System.Drawing.Color.Silver;
            this.nul.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nul.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.nul.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nul.Location = new System.Drawing.Point(25, 592);
            this.nul.Name = "nul";
            this.nul.Size = new System.Drawing.Size(180, 105);
            this.nul.TabIndex = 13;
            this.nul.Text = "0";
            this.nul.UseVisualStyleBackColor = false;
            this.nul.Click += new System.EventHandler(this.number_Click);
            // 
            // berekenen
            // 
            this.berekenen.BackColor = System.Drawing.Color.DarkOrange;
            this.berekenen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.berekenen.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.berekenen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.berekenen.Location = new System.Drawing.Point(640, 732);
            this.berekenen.Name = "berekenen";
            this.berekenen.Size = new System.Drawing.Size(180, 105);
            this.berekenen.TabIndex = 20;
            this.berekenen.Text = "=";
            this.berekenen.UseVisualStyleBackColor = false;
            this.berekenen.Click += new System.EventHandler(this.berekenen_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DarkOrange;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.clear.ForeColor = System.Drawing.Color.RoyalBlue;
            this.clear.Location = new System.Drawing.Point(435, 732);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(180, 105);
            this.clear.TabIndex = 19;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // sluitingshaak
            // 
            this.sluitingshaak.BackColor = System.Drawing.Color.Moccasin;
            this.sluitingshaak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sluitingshaak.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.sluitingshaak.ForeColor = System.Drawing.Color.RoyalBlue;
            this.sluitingshaak.Location = new System.Drawing.Point(231, 732);
            this.sluitingshaak.Name = "sluitingshaak";
            this.sluitingshaak.Size = new System.Drawing.Size(180, 105);
            this.sluitingshaak.TabIndex = 18;
            this.sluitingshaak.Text = ")";
            this.sluitingshaak.UseVisualStyleBackColor = false;
            this.sluitingshaak.Click += new System.EventHandler(this.tekens_Click);
            // 
            // openingshaak
            // 
            this.openingshaak.BackColor = System.Drawing.Color.Moccasin;
            this.openingshaak.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openingshaak.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Bold);
            this.openingshaak.ForeColor = System.Drawing.Color.RoyalBlue;
            this.openingshaak.Location = new System.Drawing.Point(25, 732);
            this.openingshaak.Name = "openingshaak";
            this.openingshaak.Size = new System.Drawing.Size(180, 105);
            this.openingshaak.TabIndex = 17;
            this.openingshaak.Text = "(";
            this.openingshaak.UseVisualStyleBackColor = false;
            this.openingshaak.Click += new System.EventHandler(this.tekens_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.DarkCyan;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.Font = new System.Drawing.Font("Impact", 35F);
            this.output.Location = new System.Drawing.Point(0, -2);
            this.output.Margin = new System.Windows.Forms.Padding(0);
            this.output.MinimumSize = new System.Drawing.Size(846, 127);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.output.Size = new System.Drawing.Size(846, 114);
            this.output.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(844, 874);
            this.Controls.Add(this.output);
            this.Controls.Add(this.berekenen);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.sluitingshaak);
            this.Controls.Add(this.openingshaak);
            this.Controls.Add(this.min);
            this.Controls.Add(this.macht);
            this.Controls.Add(this.komma);
            this.Controls.Add(this.nul);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.drie);
            this.Controls.Add(this.twee);
            this.Controls.Add(this.een);
            this.Controls.Add(this.maal);
            this.Controls.Add(this.zes);
            this.Controls.Add(this.vijf);
            this.Controls.Add(this.vier);
            this.Controls.Add(this.delen);
            this.Controls.Add(this.negen);
            this.Controls.Add(this.acht);
            this.Controls.Add(this.zeven);
            this.Name = "Form1";
            this.Text = "Rekenmachine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zeven;
        private System.Windows.Forms.Button acht;
        private System.Windows.Forms.Button negen;
        private System.Windows.Forms.Button delen;
        private System.Windows.Forms.Button maal;
        private System.Windows.Forms.Button zes;
        private System.Windows.Forms.Button vijf;
        private System.Windows.Forms.Button vier;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button drie;
        private System.Windows.Forms.Button twee;
        private System.Windows.Forms.Button een;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button macht;
        private System.Windows.Forms.Button komma;
        private System.Windows.Forms.Button nul;
        private System.Windows.Forms.Button berekenen;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button sluitingshaak;
        private System.Windows.Forms.Button openingshaak;
        private System.Windows.Forms.TextBox output;
    }
}

