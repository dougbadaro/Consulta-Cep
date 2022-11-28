namespace ConsultaCep
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(64, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(256, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consulta de Endereço";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(62, 67);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(41, 18);
            this.lblCep.TabIndex = 2;
            this.lblCep.Text = "CEP: ";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(63, 102);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(40, 18);
            this.lblRua.TabIndex = 3;
            this.lblRua.Text = "Rua: ";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(109, 61);
            this.txtCep.Multiline = true;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(223, 30);
            this.txtCep.TabIndex = 4;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(43, 175);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 5;
            this.lblCidade.Text = "Cidade: ";
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUf.Location = new System.Drawing.Point(71, 211);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(32, 18);
            this.lblUf.TabIndex = 6;
            this.lblUf.Text = "UF: ";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(50, 138);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(53, 18);
            this.lblBairro.TabIndex = 7;
            this.lblBairro.Text = "Bairro: ";
            // 
            // txtRua
            // 
            this.txtRua.Enabled = false;
            this.txtRua.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(109, 97);
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(223, 30);
            this.txtRua.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(109, 133);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(223, 30);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(109, 169);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(223, 30);
            this.txtCidade.TabIndex = 10;
            // 
            // txtUf
            // 
            this.txtUf.Enabled = false;
            this.txtUf.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUf.Location = new System.Drawing.Point(109, 205);
            this.txtUf.Multiline = true;
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(223, 30);
            this.txtUf.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = global::ConsultaCep.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(351, 66);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(401, 268);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblUf);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Button btnSearch;
    }
}

