namespace Projeto
{
    partial class Form1
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
            this.Tabelao = new System.Windows.Forms.ListView();
            this.textsenha = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbtele = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttele = new System.Windows.Forms.MaskedTextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncad = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tabelao
            // 
            this.Tabelao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Tabelao.HideSelection = false;
            this.Tabelao.Location = new System.Drawing.Point(394, 533);
            this.Tabelao.Name = "Tabelao";
            this.Tabelao.Size = new System.Drawing.Size(697, 151);
            this.Tabelao.TabIndex = 0;
            this.Tabelao.UseCompatibleStateImageBehavior = false;
            this.Tabelao.View = System.Windows.Forms.View.Details;
            // 
            // textsenha
            // 
            this.textsenha.Location = new System.Drawing.Point(12, 602);
            this.textsenha.Name = "textsenha";
            this.textsenha.Size = new System.Drawing.Size(248, 20);
            this.textsenha.TabIndex = 1;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(12, 495);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(248, 20);
            this.textemail.TabIndex = 2;
            this.textemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(12, 445);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(248, 20);
            this.textname.TabIndex = 4;
            this.textname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(12, 429);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(42, 14);
            this.lbnome.TabIndex = 5;
            this.lbnome.Text = "Nome:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.BackColor = System.Drawing.Color.Transparent;
            this.lbemail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbemail.Location = new System.Drawing.Point(12, 479);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(39, 14);
            this.lbemail.TabIndex = 6;
            this.lbemail.Text = "Email:";
            // 
            // lbtele
            // 
            this.lbtele.AutoSize = true;
            this.lbtele.BackColor = System.Drawing.Color.Transparent;
            this.lbtele.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtele.Location = new System.Drawing.Point(12, 533);
            this.lbtele.Name = "lbtele";
            this.lbtele.Size = new System.Drawing.Size(55, 14);
            this.lbtele.TabIndex = 7;
            this.lbtele.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha:";
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(12, 550);
            this.txttele.Mask = "(00) 00000-0000";
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(248, 20);
            this.txttele.TabIndex = 9;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefone";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Senha";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 180;
            // 
            // btncad
            // 
            this.btncad.Location = new System.Drawing.Point(12, 628);
            this.btncad.Name = "btncad";
            this.btncad.Size = new System.Drawing.Size(75, 23);
            this.btncad.TabIndex = 10;
            this.btncad.Text = "Entrar";
            this.btncad.UseVisualStyleBackColor = true;
            this.btncad.Click += new System.EventHandler(this.btncad_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(93, 628);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Editar";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnapagar
            // 
            this.btnapagar.Location = new System.Drawing.Point(174, 628);
            this.btnapagar.Name = "btnapagar";
            this.btnapagar.Size = new System.Drawing.Size(75, 23);
            this.btnapagar.TabIndex = 12;
            this.btnapagar.Text = "Apagar";
            this.btnapagar.UseVisualStyleBackColor = true;
            this.btnapagar.Click += new System.EventHandler(this.btnapagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projetinho.Properties.Resources.Olá__sou_o_Carlos_Gama___1_;
            this.ClientSize = new System.Drawing.Size(1088, 682);
            this.Controls.Add(this.btnapagar);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btncad);
            this.Controls.Add(this.txttele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtele);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textsenha);
            this.Controls.Add(this.Tabelao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Tabelao;
        private System.Windows.Forms.TextBox textsenha;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbtele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txttele;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btncad;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnapagar;
    }
}

