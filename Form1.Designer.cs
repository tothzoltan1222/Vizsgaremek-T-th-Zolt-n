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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBeolvas = new System.Windows.Forms.Button();
            this.btnRendez = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLegregebbi = new System.Windows.Forms.Button();
            this.btnLegújabb = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.txtEv = new System.Windows.Forms.TextBox();
            this.lblEredmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(106, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 290);
            this.listBox1.TabIndex = 0;
            // 
            // btnBeolvas
            // 
            this.btnBeolvas.Location = new System.Drawing.Point(380, 141);
            this.btnBeolvas.Name = "btnBeolvas";
            this.btnBeolvas.Size = new System.Drawing.Size(172, 23);
            this.btnBeolvas.TabIndex = 1;
            this.btnBeolvas.Text = "Autok beolvasása";
            this.btnBeolvas.UseVisualStyleBackColor = true;
            // 
            // btnRendez
            // 
            this.btnRendez.Location = new System.Drawing.Point(398, 170);
            this.btnRendez.Name = "btnRendez";
            this.btnRendez.Size = new System.Drawing.Size(154, 23);
            this.btnRendez.TabIndex = 2;
            this.btnRendez.Text = "Rendezés Évszám";
            this.btnRendez.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autok nyilvántartás";
            // 
            // btnLegregebbi
            // 
            this.btnLegregebbi.Location = new System.Drawing.Point(573, 244);
            this.btnLegregebbi.Name = "btnLegregebbi";
            this.btnLegregebbi.Size = new System.Drawing.Size(75, 23);
            this.btnLegregebbi.TabIndex = 4;
            this.btnLegregebbi.Text = "Legrégebbi auto";
            this.btnLegregebbi.UseVisualStyleBackColor = true;
            // 
            // btnLegújabb
            // 
            this.btnLegújabb.Location = new System.Drawing.Point(491, 90);
            this.btnLegújabb.Name = "btnLegújabb";
            this.btnLegújabb.Size = new System.Drawing.Size(75, 23);
            this.btnLegújabb.TabIndex = 5;
            this.btnLegújabb.Text = "Legujabb Auto";
            this.btnLegújabb.UseVisualStyleBackColor = true;
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(475, 296);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(75, 23);
            this.btnKeres.TabIndex = 6;
            this.btnKeres.Text = "Keres";
            this.btnKeres.UseVisualStyleBackColor = true;
            // 
            // txtEv
            // 
            this.txtEv.Location = new System.Drawing.Point(603, 393);
            this.txtEv.Name = "txtEv";
            this.txtEv.Size = new System.Drawing.Size(100, 20);
            this.txtEv.TabIndex = 7;
            // 
            // lblEredmeny
            // 
            this.lblEredmeny.AutoSize = true;
            this.lblEredmeny.Location = new System.Drawing.Point(425, 352);
            this.lblEredmeny.Name = "lblEredmeny";
            this.lblEredmeny.Size = new System.Drawing.Size(54, 13);
            this.lblEredmeny.TabIndex = 8;
            this.lblEredmeny.Text = "Eredmény";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEredmeny);
            this.Controls.Add(this.txtEv);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnLegújabb);
            this.Controls.Add(this.btnLegregebbi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRendez);
            this.Controls.Add(this.btnBeolvas);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBeolvas;
        private System.Windows.Forms.Button btnRendez;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLegregebbi;
        private System.Windows.Forms.Button btnLegújabb;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.TextBox txtEv;
        private System.Windows.Forms.Label lblEredmeny;
    }
}

