
namespace DesktopApp.Forms
{
    partial class AddTrener
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_jmeno = new System.Windows.Forms.TextBox();
            this.tb_prijmeni = new System.Windows.Forms.TextBox();
            this.tb_pohlavi = new System.Windows.Forms.TextBox();
            this.dtp_datum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 74;
            this.label1.Text = "Jméno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Příjmení";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Datum narození";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(13, 107);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 17);
            this.label.TabIndex = 82;
            this.label.Text = "Pohlaví";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Uložit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(129, 14);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(200, 22);
            this.tb_id.TabIndex = 84;
            // 
            // tb_jmeno
            // 
            this.tb_jmeno.Location = new System.Drawing.Point(129, 42);
            this.tb_jmeno.Name = "tb_jmeno";
            this.tb_jmeno.Size = new System.Drawing.Size(200, 22);
            this.tb_jmeno.TabIndex = 85;
            // 
            // tb_prijmeni
            // 
            this.tb_prijmeni.Location = new System.Drawing.Point(129, 76);
            this.tb_prijmeni.Name = "tb_prijmeni";
            this.tb_prijmeni.Size = new System.Drawing.Size(200, 22);
            this.tb_prijmeni.TabIndex = 86;
            // 
            // tb_pohlavi
            // 
            this.tb_pohlavi.Location = new System.Drawing.Point(129, 104);
            this.tb_pohlavi.Name = "tb_pohlavi";
            this.tb_pohlavi.Size = new System.Drawing.Size(200, 22);
            this.tb_pohlavi.TabIndex = 87;
            // 
            // dtp_datum
            // 
            this.dtp_datum.Location = new System.Drawing.Point(129, 134);
            this.dtp_datum.Name = "dtp_datum";
            this.dtp_datum.Size = new System.Drawing.Size(200, 22);
            this.dtp_datum.TabIndex = 88;
            this.dtp_datum.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // AddTrener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 195);
            this.Controls.Add(this.dtp_datum);
            this.Controls.Add(this.tb_pohlavi);
            this.Controls.Add(this.tb_prijmeni);
            this.Controls.Add(this.tb_jmeno);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "AddTrener";
            this.Text = "AddTrener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_jmeno;
        private System.Windows.Forms.TextBox tb_prijmeni;
        private System.Windows.Forms.TextBox tb_pohlavi;
        private System.Windows.Forms.DateTimePicker dtp_datum;
    }
}