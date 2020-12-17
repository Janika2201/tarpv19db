namespace tarpv19db
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lisa_Data = new System.Windows.Forms.Button();
            this.update_Data = new System.Windows.Forms.Button();
            this.delete_Data = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choose_Foto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tel_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gm_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(544, 247);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 20);
            this.name_txt.TabIndex = 4;
            // 
            // surname_txt
            // 
            this.surname_txt.Location = new System.Drawing.Point(594, 284);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(100, 20);
            this.surname_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Perekonnanimi";
            // 
            // lisa_Data
            // 
            this.lisa_Data.Location = new System.Drawing.Point(513, 444);
            this.lisa_Data.Name = "lisa_Data";
            this.lisa_Data.Size = new System.Drawing.Size(75, 23);
            this.lisa_Data.TabIndex = 16;
            this.lisa_Data.Text = "Lisa";
            this.lisa_Data.UseVisualStyleBackColor = true;
            this.lisa_Data.Click += new System.EventHandler(this.lisa_Data_Click);
            // 
            // update_Data
            // 
            this.update_Data.Location = new System.Drawing.Point(629, 444);
            this.update_Data.Name = "update_Data";
            this.update_Data.Size = new System.Drawing.Size(75, 23);
            this.update_Data.TabIndex = 17;
            this.update_Data.Text = "Muuda";
            this.update_Data.UseVisualStyleBackColor = true;
            this.update_Data.Click += new System.EventHandler(this.update_Data_Click);
            // 
            // delete_Data
            // 
            this.delete_Data.Location = new System.Drawing.Point(734, 444);
            this.delete_Data.Name = "delete_Data";
            this.delete_Data.Size = new System.Drawing.Size(75, 23);
            this.delete_Data.TabIndex = 18;
            this.delete_Data.Text = "Kustuta";
            this.delete_Data.UseVisualStyleBackColor = true;
            this.delete_Data.Click += new System.EventHandler(this.delete_Data_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(35, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // choose_Foto
            // 
            this.choose_Foto.Location = new System.Drawing.Point(163, 458);
            this.choose_Foto.Name = "choose_Foto";
            this.choose_Foto.Size = new System.Drawing.Size(75, 23);
            this.choose_Foto.TabIndex = 20;
            this.choose_Foto.Text = "Vali fail...";
            this.choose_Foto.UseVisualStyleBackColor = true;
            this.choose_Foto.Click += new System.EventHandler(this.choose_Foto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 172);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tel";
            // 
            // tel_txt
            // 
            this.tel_txt.Location = new System.Drawing.Point(594, 326);
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(100, 20);
            this.tel_txt.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gmail";
            // 
            // gm_txt
            // 
            this.gm_txt.Location = new System.Drawing.Point(594, 367);
            this.gm_txt.Name = "gm_txt";
            this.gm_txt.Size = new System.Drawing.Size(100, 20);
            this.gm_txt.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 514);
            this.Controls.Add(this.gm_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tel_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.choose_Foto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delete_Data);
            this.Controls.Add(this.update_Data);
            this.Controls.Add(this.lisa_Data);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "Form1";
            this.Text = "LoginForms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lisa_Data;
        private System.Windows.Forms.Button update_Data;
        private System.Windows.Forms.Button delete_Data;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button choose_Foto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gm_txt;
    }
}

