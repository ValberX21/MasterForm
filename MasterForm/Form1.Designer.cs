
namespace MasterForm
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
            this.createTxtandPath = new System.Windows.Forms.Button();
            this.txtWithSql = new System.Windows.Forms.Button();
            this.savesql = new System.Windows.Forms.Button();
            this.txtNomeFant = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.callproc = new System.Windows.Forms.Button();
            this.txtFilterNome = new System.Windows.Forms.TextBox();
            this.txtFilterCnpj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTxtandPath
            // 
            this.createTxtandPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTxtandPath.Location = new System.Drawing.Point(12, 12);
            this.createTxtandPath.Name = "createTxtandPath";
            this.createTxtandPath.Size = new System.Drawing.Size(198, 49);
            this.createTxtandPath.TabIndex = 0;
            this.createTxtandPath.Text = "Create txt and path";
            this.createTxtandPath.UseVisualStyleBackColor = true;
            this.createTxtandPath.Click += new System.EventHandler(this.createTxtandPath_Click);
            // 
            // txtWithSql
            // 
            this.txtWithSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithSql.Location = new System.Drawing.Point(216, 12);
            this.txtWithSql.Name = "txtWithSql";
            this.txtWithSql.Size = new System.Drawing.Size(198, 49);
            this.txtWithSql.TabIndex = 1;
            this.txtWithSql.Text = "Create txt with SQL";
            this.txtWithSql.UseVisualStyleBackColor = true;
            this.txtWithSql.Click += new System.EventHandler(this.txtWithSql_Click);
            // 
            // savesql
            // 
            this.savesql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesql.Location = new System.Drawing.Point(12, 87);
            this.savesql.Name = "savesql";
            this.savesql.Size = new System.Drawing.Size(198, 49);
            this.savesql.TabIndex = 2;
            this.savesql.Text = "Save in SQL";
            this.savesql.UseVisualStyleBackColor = true;
            this.savesql.Click += new System.EventHandler(this.savesql_Click);
            // 
            // txtNomeFant
            // 
            this.txtNomeFant.AccessibleDescription = "";
            this.txtNomeFant.Location = new System.Drawing.Point(349, 87);
            this.txtNomeFant.Name = "txtNomeFant";
            this.txtNomeFant.Size = new System.Drawing.Size(198, 20);
            this.txtNomeFant.TabIndex = 3;
            this.txtNomeFant.Tag = "";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(349, 116);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(198, 20);
            this.txtRazaoSocial.TabIndex = 4;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(349, 142);
            this.txtCNPJ.MaxLength = 14;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(198, 20);
            this.txtCNPJ.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Razão Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNPJ";
            // 
            // callproc
            // 
            this.callproc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callproc.Location = new System.Drawing.Point(12, 207);
            this.callproc.Name = "callproc";
            this.callproc.Size = new System.Drawing.Size(198, 49);
            this.callproc.TabIndex = 9;
            this.callproc.Text = "Call proc";
            this.callproc.UseVisualStyleBackColor = true;
            this.callproc.Click += new System.EventHandler(this.callproc_Click);
            // 
            // txtFilterNome
            // 
            this.txtFilterNome.AccessibleDescription = "";
            this.txtFilterNome.Location = new System.Drawing.Point(349, 207);
            this.txtFilterNome.Name = "txtFilterNome";
            this.txtFilterNome.Size = new System.Drawing.Size(198, 20);
            this.txtFilterNome.TabIndex = 10;
            this.txtFilterNome.Tag = "";
            // 
            // txtFilterCnpj
            // 
            this.txtFilterCnpj.AccessibleDescription = "";
            this.txtFilterCnpj.Location = new System.Drawing.Point(349, 233);
            this.txtFilterCnpj.Name = "txtFilterCnpj";
            this.txtFilterCnpj.Size = new System.Drawing.Size(198, 20);
            this.txtFilterCnpj.TabIndex = 11;
            this.txtFilterCnpj.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome Fantasia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "CNPJ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilterCnpj);
            this.Controls.Add(this.txtFilterNome);
            this.Controls.Add(this.callproc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtNomeFant);
            this.Controls.Add(this.savesql);
            this.Controls.Add(this.txtWithSql);
            this.Controls.Add(this.createTxtandPath);
            this.Name = "Form1";
            this.Text = "Master Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTxtandPath;
        private System.Windows.Forms.Button txtWithSql;
        private System.Windows.Forms.Button savesql;
        private System.Windows.Forms.TextBox txtNomeFant;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button callproc;
        private System.Windows.Forms.TextBox txtFilterNome;
        private System.Windows.Forms.TextBox txtFilterCnpj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

