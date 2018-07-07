namespace WindowsFormView
{
    partial class menuPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadastrarAluno = new System.Windows.Forms.Button();
            this.listarAluno = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listarAluno);
            this.groupBox1.Controls.Add(this.cadastrarAluno);
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aluno";
            // 
            // cadastrarAluno
            // 
            this.cadastrarAluno.Location = new System.Drawing.Point(34, 35);
            this.cadastrarAluno.Name = "cadastrarAluno";
            this.cadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.cadastrarAluno.TabIndex = 0;
            this.cadastrarAluno.Text = "Cadastrar";
            this.cadastrarAluno.UseVisualStyleBackColor = true;
            this.cadastrarAluno.Click += new System.EventHandler(this.cadastrarAluno_Click);
            // 
            // listarAluno
            // 
            this.listarAluno.Location = new System.Drawing.Point(34, 85);
            this.listarAluno.Name = "listarAluno";
            this.listarAluno.Size = new System.Drawing.Size(75, 23);
            this.listarAluno.TabIndex = 1;
            this.listarAluno.Text = "Listar";
            this.listarAluno.UseVisualStyleBackColor = true;
            this.listarAluno.Click += new System.EventHandler(this.listarAluno_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 558);
            this.Controls.Add(this.groupBox1);
            this.Name = "menuPrincipal";
            this.Text = "menuPrincipal";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button listarAluno;
        private System.Windows.Forms.Button cadastrarAluno;
    }
}