namespace examenAchouri
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnParticulier = new System.Windows.Forms.Button();
            this.BtnEntre = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.PictureEdite = new System.Windows.Forms.PictureBox();
            this.PictureDelete = new System.Windows.Forms.PictureBox();
            this.PictureAdd = new System.Windows.Forms.PictureBox();
            this.ProfessionPart = new System.Windows.Forms.Label();
            this.RevenuePart = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdd)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnParticulier);
            this.panel1.Controls.Add(this.BtnEntre);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 84);
            this.panel1.TabIndex = 1;
            // 
            // BtnParticulier
            // 
            this.BtnParticulier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnParticulier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnParticulier.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnParticulier.ForeColor = System.Drawing.Color.White;
            this.BtnParticulier.Location = new System.Drawing.Point(828, 14);
            this.BtnParticulier.Name = "BtnParticulier";
            this.BtnParticulier.Size = new System.Drawing.Size(250, 53);
            this.BtnParticulier.TabIndex = 4;
            this.BtnParticulier.Text = "PARTICULIER";
            this.BtnParticulier.UseVisualStyleBackColor = false;
            this.BtnParticulier.Click += new System.EventHandler(this.BtnParticulier_Click);
            // 
            // BtnEntre
            // 
            this.BtnEntre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEntre.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnEntre.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntre.ForeColor = System.Drawing.Color.White;
            this.BtnEntre.Location = new System.Drawing.Point(422, 14);
            this.BtnEntre.Name = "BtnEntre";
            this.BtnEntre.Size = new System.Drawing.Size(250, 53);
            this.BtnEntre.TabIndex = 3;
            this.BtnEntre.Text = "ENTREPRISE";
            this.BtnEntre.UseVisualStyleBackColor = false;
            this.BtnEntre.UseWaitCursor = true;
            this.BtnEntre.Click += new System.EventHandler(this.BtnEntre_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(390, 23);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 450);
            this.panel3.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(60, 39);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(123, 28);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom Client:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(28, 86);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(155, 28);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prenom Client: ";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.Location = new System.Drawing.Point(43, 180);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(140, 28);
            this.lblAdress.TabIndex = 8;
            this.lblAdress.Text = "Adress Client:";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(50, 133);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(133, 28);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre Client:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERNAME,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(427, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 195);
            this.dataGridView1.TabIndex = 12;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(7, 274);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(176, 28);
            this.lblTelephone.TabIndex = 13;
            this.lblTelephone.Text = "Telephone Client:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(54, 227);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(129, 28);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email Client:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(189, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 30);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(189, 131);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 30);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(189, 178);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(180, 30);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Location = new System.Drawing.Point(189, 225);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(180, 30);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Location = new System.Drawing.Point(189, 272);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(180, 30);
            this.textBox5.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.Location = new System.Drawing.Point(189, 90);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 30);
            this.textBox6.TabIndex = 20;
            // 
            // PictureEdite
            // 
            this.PictureEdite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureEdite.ErrorImage = global::examenAchouri.Properties.Resources.add_user;
            this.PictureEdite.Image = global::examenAchouri.Properties.Resources.user_avatar;
            this.PictureEdite.Location = new System.Drawing.Point(165, 674);
            this.PictureEdite.Name = "PictureEdite";
            this.PictureEdite.Size = new System.Drawing.Size(52, 48);
            this.PictureEdite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureEdite.TabIndex = 21;
            this.PictureEdite.TabStop = false;
            // 
            // PictureDelete
            // 
            this.PictureDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureDelete.ErrorImage = global::examenAchouri.Properties.Resources.add_user;
            this.PictureDelete.Image = global::examenAchouri.Properties.Resources.remove_user1;
            this.PictureDelete.Location = new System.Drawing.Point(304, 674);
            this.PictureDelete.Name = "PictureDelete";
            this.PictureDelete.Size = new System.Drawing.Size(52, 48);
            this.PictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureDelete.TabIndex = 22;
            this.PictureDelete.TabStop = false;
            // 
            // PictureAdd
            // 
            this.PictureAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureAdd.ErrorImage = global::examenAchouri.Properties.Resources.add_user;
            this.PictureAdd.Image = global::examenAchouri.Properties.Resources.add_user;
            this.PictureAdd.Location = new System.Drawing.Point(33, 674);
            this.PictureAdd.Name = "PictureAdd";
            this.PictureAdd.Size = new System.Drawing.Size(52, 48);
            this.PictureAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureAdd.TabIndex = 23;
            this.PictureAdd.TabStop = false;
            // 
            // ProfessionPart
            // 
            this.ProfessionPart.AutoSize = true;
            this.ProfessionPart.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfessionPart.Location = new System.Drawing.Point(19, 343);
            this.ProfessionPart.Name = "ProfessionPart";
            this.ProfessionPart.Size = new System.Drawing.Size(160, 28);
            this.ProfessionPart.TabIndex = 26;
            this.ProfessionPart.Text = "Profession Part:";
            this.ProfessionPart.Click += new System.EventHandler(this.NomEmtrp_Click);
            // 
            // RevenuePart
            // 
            this.RevenuePart.AutoSize = true;
            this.RevenuePart.Font = new System.Drawing.Font("Leelawadee UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenuePart.Location = new System.Drawing.Point(36, 387);
            this.RevenuePart.Name = "RevenuePart";
            this.RevenuePart.Size = new System.Drawing.Size(142, 28);
            this.RevenuePart.TabIndex = 28;
            this.RevenuePart.Text = "Revenue Part:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox9.Location = new System.Drawing.Point(189, 338);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(180, 30);
            this.textBox9.TabIndex = 29;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.Location = new System.Drawing.Point(189, 385);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 30);
            this.textBox8.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.RevenuePart);
            this.panel2.Controls.Add(this.ProfessionPart);
            this.panel2.Controls.Add(this.PictureAdd);
            this.panel2.Controls.Add(this.PictureDelete);
            this.panel2.Controls.Add(this.PictureEdite);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblTelephone);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.lblGenre);
            this.panel2.Controls.Add(this.lblAdress);
            this.panel2.Controls.Add(this.lblPrenom);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(37, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1377, 496);
            this.panel2.TabIndex = 6;
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "info1";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Sylfaen", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME.DefaultCellStyle = dataGridViewCellStyle4;
            this.USERNAME.FillWeight = 85.5615F;
            this.USERNAME.HeaderText = "Num Client";
            this.USERNAME.MinimumWidth = 4;
            this.USERNAME.Name = "USERNAME";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adress Client";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email Client";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Telephone Client";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom Client";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prenom Client ";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Genre Client";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Profession Part";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Revenue Part";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 652);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAdd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnParticulier;
        private System.Windows.Forms.Button BtnEntre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.PictureBox PictureEdite;
        private System.Windows.Forms.PictureBox PictureDelete;
        private System.Windows.Forms.PictureBox PictureAdd;
        private System.Windows.Forms.Label ProfessionPart;
        private System.Windows.Forms.Label RevenuePart;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}