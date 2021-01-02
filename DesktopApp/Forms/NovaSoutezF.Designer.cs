
namespace DesktopApp.Forms
{
    partial class NovaSoutezF
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
            this.tb_nezev = new System.Windows.Forms.TextBox();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_startovne = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_organizator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_nezev
            // 
            this.tb_nezev.Location = new System.Drawing.Point(152, 9);
            this.tb_nezev.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nezev.Name = "tb_nezev";
            this.tb_nezev.Size = new System.Drawing.Size(187, 22);
            this.tb_nezev.TabIndex = 10;
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(152, 39);
            this.dtp_datum.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(187, 22);
            this.dtp_datum.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kdy";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Název";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Cena startovného";
            // 
            // tb_startovne
            // 
            this.tb_startovne.Location = new System.Drawing.Point(152, 77);
            this.tb_startovne.Margin = new System.Windows.Forms.Padding(4);
            this.tb_startovne.Name = "tb_startovne";
            this.tb_startovne.Size = new System.Drawing.Size(187, 22);
            this.tb_startovne.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Vytvořit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 50;
            this.label6.Text = "ID Organizatora";
            // 
            // tb_organizator
            // 
            this.tb_organizator.Location = new System.Drawing.Point(152, 113);
            this.tb_organizator.Margin = new System.Windows.Forms.Padding(4);
            this.tb_organizator.Name = "tb_organizator";
            this.tb_organizator.Size = new System.Drawing.Size(187, 22);
            this.tb_organizator.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID Adresy";
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(152, 143);
            this.tb_adresa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(187, 22);
            this.tb_adresa.TabIndex = 53;
            // 
            // NovaSoutezF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 203);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_organizator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_startovne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.tb_nezev);
            this.Name = "NovaSoutezF";
            this.Text = "Nová soutěž";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nezev;
        private System.Windows.Forms.DateTimePicker dtp_datum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_startovne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_organizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_adresa;
    }
}