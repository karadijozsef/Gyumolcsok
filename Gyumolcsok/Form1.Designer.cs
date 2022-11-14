namespace Gyumolcsok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_gyum = new System.Windows.Forms.ListBox();
            this.groupBox_gyumo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.textBox_egysegar = new System.Windows.Forms.TextBox();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.groupBox_gyumo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_gyum
            // 
            this.listBox_gyum.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_gyum.FormattingEnabled = true;
            this.listBox_gyum.Location = new System.Drawing.Point(0, 0);
            this.listBox_gyum.Name = "listBox_gyum";
            this.listBox_gyum.Size = new System.Drawing.Size(159, 453);
            this.listBox_gyum.TabIndex = 0;
            // 
            // groupBox_gyumo
            // 
            this.groupBox_gyumo.Controls.Add(this.delete);
            this.groupBox_gyumo.Controls.Add(this.update);
            this.groupBox_gyumo.Controls.Add(this.insert);
            this.groupBox_gyumo.Controls.Add(this.numericUpDown_mennyiseg);
            this.groupBox_gyumo.Controls.Add(this.textBox_egysegar);
            this.groupBox_gyumo.Controls.Add(this.textBox_nev);
            this.groupBox_gyumo.Controls.Add(this.textBox_id);
            this.groupBox_gyumo.Controls.Add(this.label4);
            this.groupBox_gyumo.Controls.Add(this.label3);
            this.groupBox_gyumo.Controls.Add(this.label2);
            this.groupBox_gyumo.Controls.Add(this.label1);
            this.groupBox_gyumo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_gyumo.Location = new System.Drawing.Point(159, 0);
            this.groupBox_gyumo.Name = "groupBox_gyumo";
            this.groupBox_gyumo.Size = new System.Drawing.Size(296, 453);
            this.groupBox_gyumo.TabIndex = 1;
            this.groupBox_gyumo.TabStop = false;
            this.groupBox_gyumo.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Egységár";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mennyiség";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(122, 65);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(91, 20);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(122, 110);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(134, 20);
            this.textBox_nev.TabIndex = 5;
            // 
            // textBox_egysegar
            // 
            this.textBox_egysegar.Location = new System.Drawing.Point(122, 158);
            this.textBox_egysegar.Name = "textBox_egysegar";
            this.textBox_egysegar.Size = new System.Drawing.Size(91, 20);
            this.textBox_egysegar.TabIndex = 6;
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(122, 209);
            this.numericUpDown_mennyiseg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_mennyiseg.TabIndex = 7;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(55, 270);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(122, 38);
            this.insert.TabIndex = 8;
            this.insert.Text = "Új gyümölcs";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(55, 328);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(122, 38);
            this.update.TabIndex = 9;
            this.update.Text = "Módosít";
            this.update.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(55, 383);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(122, 38);
            this.delete.TabIndex = 10;
            this.delete.Text = "Töröl";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 453);
            this.Controls.Add(this.groupBox_gyumo);
            this.Controls.Add(this.listBox_gyum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gyümölcsök";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_gyumo.ResumeLayout(false);
            this.groupBox_gyumo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_gyum;
        private System.Windows.Forms.GroupBox groupBox_gyumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.TextBox textBox_egysegar;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button insert;
    }
}

