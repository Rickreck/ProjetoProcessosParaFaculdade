namespace ProjetoProcessos
{
    partial class FormProcess
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcess));
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.maskedtextPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.DateFinal = new System.Windows.Forms.Label();
            this.textDateFinal = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AccessibleName = "lblName";
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblName.Location = new System.Drawing.Point(14, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome do Processo: ";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.AccessibleName = "lblLocal";
            this.lblLocal.AutoSize = true;
            this.lblLocal.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblLocal.Location = new System.Drawing.Point(14, 103);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(90, 13);
            this.lblLocal.TabIndex = 1;
            this.lblLocal.Text = "Local do Projeto: ";
            this.lblLocal.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AccessibleName = "lblPhone";
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lblPhone.Location = new System.Drawing.Point(12, 137);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(118, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefone para contato: ";
            this.lblPhone.Click += new System.EventHandler(this.label3_Click);
            // 
            // textName
            // 
            this.textName.AccessibleName = "txtName";
            this.textName.Enabled = false;
            this.textName.Location = new System.Drawing.Point(138, 66);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(239, 20);
            this.textName.TabIndex = 3;
            this.textName.TextChanged += new System.EventHandler(this.textBoxName);
            // 
            // textLocal
            // 
            this.textLocal.AccessibleName = "textLocal";
            this.textLocal.Enabled = false;
            this.textLocal.Location = new System.Drawing.Point(138, 100);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(239, 20);
            this.textLocal.TabIndex = 4;
            this.textLocal.TextChanged += new System.EventHandler(this.textBoxLocal);
            // 
            // maskedtextPhone
            // 
            this.maskedtextPhone.AccessibleName = "textPhone";
            this.maskedtextPhone.Enabled = false;
            this.maskedtextPhone.Location = new System.Drawing.Point(138, 137);
            this.maskedtextPhone.Mask = "(00)00000-0000";
            this.maskedtextPhone.Name = "maskedtextPhone";
            this.maskedtextPhone.Size = new System.Drawing.Size(87, 20);
            this.maskedtextPhone.TabIndex = 5;
            this.maskedtextPhone.TextChanged += new System.EventHandler(this.textBoxPhone);
            // 
            // label4
            // 
            this.label4.AccessibleName = "lblName";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(246, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Criação de Processos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // newButton
            // 
            this.newButton.AccessibleName = "newButton";
            this.newButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.newButton.Location = new System.Drawing.Point(17, 218);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 7;
            this.newButton.Text = "Novo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.AccessibleName = "saveButton";
            this.saveButton.Enabled = false;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Location = new System.Drawing.Point(98, 218);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AccessibleName = "cancelButton";
            this.cancelButton.Enabled = false;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(341, 218);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AccessibleName = "deleteButton";
            this.deleteButton.Enabled = false;
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteButton.Location = new System.Drawing.Point(260, 218);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Excluir";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblDate";
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(14, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data de inicio: ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.AccessibleName = "textPhone";
            this.maskedTextBoxDate.Enabled = false;
            this.maskedTextBoxDate.Location = new System.Drawing.Point(138, 175);
            this.maskedTextBoxDate.Mask = "00/00/0000";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(64, 20);
            this.maskedTextBoxDate.TabIndex = 13;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxDateFinal_MaskInputRejected);
            // 
            // editButton
            // 
            this.editButton.AccessibleName = "editButton";
            this.editButton.Enabled = false;
            this.editButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editButton.Location = new System.Drawing.Point(179, 218);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label2
            // 
            this.label2.AccessibleName = "lblSearch";
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(445, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Buscar Processo: ";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textSearch
            // 
            this.textSearch.AccessibleName = "textSearch";
            this.textSearch.Location = new System.Drawing.Point(544, 119);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(246, 20);
            this.textSearch.TabIndex = 16;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // gridData
            // 
            this.gridData.AccessibleName = "gridData";
            this.gridData.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Location = new System.Drawing.Point(17, 247);
            this.gridData.Name = "gridData";
            this.gridData.Size = new System.Drawing.Size(642, 191);
            this.gridData.TabIndex = 17;
            this.gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellClick);
            this.gridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellContentClick);
            // 
            // DateFinal
            // 
            this.DateFinal.AccessibleName = "lblDateFinal";
            this.DateFinal.AutoSize = true;
            this.DateFinal.ForeColor = System.Drawing.Color.LavenderBlush;
            this.DateFinal.Location = new System.Drawing.Point(233, 178);
            this.DateFinal.Name = "DateFinal";
            this.DateFinal.Size = new System.Drawing.Size(61, 13);
            this.DateFinal.TabIndex = 18;
            this.DateFinal.Text = "Data Final: ";
            // 
            // textDateFinal
            // 
            this.textDateFinal.AccessibleName = "textDateFinal";
            this.textDateFinal.Enabled = false;
            this.textDateFinal.Location = new System.Drawing.Point(300, 175);
            this.textDateFinal.Mask = "00/00/0000";
            this.textDateFinal.Name = "textDateFinal";
            this.textDateFinal.Size = new System.Drawing.Size(77, 20);
            this.textDateFinal.TabIndex = 19;
            this.textDateFinal.ValidatingType = typeof(System.DateTime);
            this.textDateFinal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.textDateFinal);
            this.Controls.Add(this.DateFinal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gridData);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.maskedTextBoxDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedtextPhone);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProcess";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.MaskedTextBox maskedtextPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.Label DateFinal;
        private System.Windows.Forms.MaskedTextBox textDateFinal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

