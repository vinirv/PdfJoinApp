namespace WindowsFormsApp1
{
    partial class Home
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
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxDestino = new System.Windows.Forms.TextBox();
            this.btnDestino = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Location = new System.Drawing.Point(12, 12);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(409, 41);
            this.btnAddFiles.TabIndex = 0;
            this.btnAddFiles.Text = "Adicionar PDFs";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(13, 60);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(408, 238);
            this.listBox.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(409, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar PDF";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxDestino
            // 
            this.tbxDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbxDestino.Location = new System.Drawing.Point(122, 333);
            this.tbxDestino.Name = "tbxDestino";
            this.tbxDestino.Size = new System.Drawing.Size(299, 23);
            this.tbxDestino.TabIndex = 3;
            // 
            // btnDestino
            // 
            this.btnDestino.Location = new System.Drawing.Point(13, 333);
            this.btnDestino.Name = "btnDestino";
            this.btnDestino.Size = new System.Drawing.Size(104, 23);
            this.btnDestino.TabIndex = 4;
            this.btnDestino.Text = "Selecionar destino";
            this.btnDestino.UseVisualStyleBackColor = true;
            this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(13, 304);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(69, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Acima";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(88, 304);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(69, 23);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Abaixo";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(301, 304);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 427);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDestino);
            this.Controls.Add(this.tbxDestino);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnAddFiles);
            this.Name = "Home";
            this.Text = "Juntar PDFs App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxDestino;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

