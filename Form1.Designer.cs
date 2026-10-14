namespace autok
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
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.btnRendez = new System.Windows.Forms.Button();
            this.btnLegregebbi = new System.Windows.Forms.Button();
            this.btnLegujabb = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btnKeres = new System.Windows.Forms.Button();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(254, 72);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(75, 23);
            this.btnBeolvas.TabIndex = 0;
            this.btnBeolvas.Text = "Beolvas";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            this.btnBeolvas.Click += new System.EventHandler(this.btnBeolvas_Click);
            // 
            // btnRendez
            // 
            this.btnRendez.Location = new System.Drawing.Point(337, 72);
            this.btnRendez.Name = "btnRendez";
            this.btnRendez.Size = new System.Drawing.Size(75, 23);
            this.btnRendez.TabIndex = 1;
            this.btnRendez.Text = "Rendezés";
            this.btnRendez.UseVisualStyleBackColor = true;
            this.btnRendez.Click += new System.EventHandler(this.btnRendez_Click);
            // 
            // btnLegregebbi
            // 
            this.btnLegregebbi.Location = new System.Drawing.Point(435, 72);
            this.btnLegregebbi.Name = "btnLegregebbi";
            this.btnLegregebbi.Size = new System.Drawing.Size(75, 23);
            this.btnLegregebbi.TabIndex = 2;
            this.btnLegregebbi.Text = "Legrégebbi";
            this.btnLegregebbi.UseVisualStyleBackColor = true;
            this.btnLegregebbi.Click += new System.EventHandler(this.btnLegregebbi_Click);
            // 
            // btnLegujabb
            // 
            this.btnLegujabb.Location = new System.Drawing.Point(538, 72);
            this.btnLegujabb.Name = "btnLegujabb";
            this.btnLegujabb.Size = new System.Drawing.Size(75, 23);
            this.btnLegujabb.TabIndex = 3;
            this.btnLegujabb.Text = "Legujabb";
            this.btnLegujabb.UseVisualStyleBackColor = true;
            this.btnLegujabb.Click += new System.EventHandler(this.btnLegujabb_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 44);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(170, 394);
            this.ListBox1.TabIndex = 4;
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(632, 72);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 5;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(432, 202);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(54, 13);
            this.lblEredmeny.TabIndex = 6;
            this.lblEredmeny.Text = "Eredmény";
            this.lblEredmeny.Click += new System.EventHandler(this.lblEredmeny_Click);
            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(491, 343);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(100, 20);
            this.txtEv.TabIndex = 7;
            this.txtEv.TextChanged += new System.EventHandler(this.txtEv_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Keress egy autot évszám szerint:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.btnLegujabb);
            this.Controls.Add(this.btnLegregebbi);
            this.Controls.Add(this.btnRendez);
            this.Controls.Add(this.btnBeolvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnRendez;
        private System.Windows.Forms.Button btnLegregebbi;
        private System.Windows.Forms.Button btnLegujabb;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Label lblEredmeny;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.Label label1;
    }
}

