namespace ProjetoAlanTI20N
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cadastrar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.cnsultar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrar.Font = new System.Drawing.Font("Schadow BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrar.ForeColor = System.Drawing.Color.Black;
            this.cadastrar.Location = new System.Drawing.Point(79, 149);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(159, 79);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "CADASTRAR";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizar.Font = new System.Drawing.Font("Schadow BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(326, 149);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(156, 79);
            this.atualizar.TabIndex = 1;
            this.atualizar.Text = "ATUALIZAR";
            this.atualizar.UseVisualStyleBackColor = false;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // cnsultar
            // 
            this.cnsultar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnsultar.Font = new System.Drawing.Font("Schadow BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnsultar.Location = new System.Drawing.Point(79, 282);
            this.cnsultar.Name = "cnsultar";
            this.cnsultar.Size = new System.Drawing.Size(159, 79);
            this.cnsultar.TabIndex = 2;
            this.cnsultar.Text = "CONSULTAR";
            this.cnsultar.UseVisualStyleBackColor = false;
            this.cnsultar.Click += new System.EventHandler(this.cnsultar_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluir.Font = new System.Drawing.Font("Schadow BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.Location = new System.Drawing.Point(323, 282);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(159, 79);
            this.excluir.TabIndex = 3;
            this.excluir.Text = "EXCLUIR";
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.cnsultar);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.cadastrar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "AQUATECH";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button cnsultar;
        private System.Windows.Forms.Button excluir;
    }
}

