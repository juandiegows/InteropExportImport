namespace ExcelExportImport
{
    partial class FNoteblock
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
            this.btnBlocNote = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnOpenText = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.chkGetFirstLine = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBlocNote
            // 
            this.btnBlocNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlocNote.ForeColor = System.Drawing.Color.Blue;
            this.btnBlocNote.Location = new System.Drawing.Point(12, 12);
            this.btnBlocNote.Name = "btnBlocNote";
            this.btnBlocNote.Size = new System.Drawing.Size(193, 36);
            this.btnBlocNote.TabIndex = 1;
            this.btnBlocNote.Text = "Abrir programa";
            this.btnBlocNote.UseVisualStyleBackColor = true;
            this.btnBlocNote.Click += new System.EventHandler(this.btnBlocNote_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Blue;
            this.btnCerrar.Location = new System.Drawing.Point(211, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(193, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar programa";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTexto.Location = new System.Drawing.Point(12, 68);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(776, 318);
            this.txtTexto.TabIndex = 2;
            // 
            // btnOpenText
            // 
            this.btnOpenText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenText.ForeColor = System.Drawing.Color.Blue;
            this.btnOpenText.Location = new System.Drawing.Point(410, 12);
            this.btnOpenText.Name = "btnOpenText";
            this.btnOpenText.Size = new System.Drawing.Size(193, 36);
            this.btnOpenText.TabIndex = 3;
            this.btnOpenText.Text = "Abrir Texto";
            this.btnOpenText.UseVisualStyleBackColor = true;
            this.btnOpenText.Click += new System.EventHandler(this.btnOpenText_Click);
            // 
            // openFile
            // 
            this.openFile.Filter = "Archivo Texto|*.txt|Archivo CSV|*.csv";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(12, 392);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(193, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.Blue;
            this.btnActualizar.Location = new System.Drawing.Point(223, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(193, 36);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Archivo texto|*.txt|Archivo CSV|*.csv";
            // 
            // chkGetFirstLine
            // 
            this.chkGetFirstLine.AutoSize = true;
            this.chkGetFirstLine.Location = new System.Drawing.Point(668, 399);
            this.chkGetFirstLine.Name = "chkGetFirstLine";
            this.chkGetFirstLine.Size = new System.Drawing.Size(120, 25);
            this.chkGetFirstLine.TabIndex = 4;
            this.chkGetFirstLine.Text = "Get first line";
            this.chkGetFirstLine.UseVisualStyleBackColor = true;
            // 
            // FNoteblock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkGetFirstLine);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnOpenText);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnBlocNote);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FNoteblock";
            this.Text = "FNoteblock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBlocNote;
        private Button btnCerrar;
        private TextBox txtTexto;
        private Button btnOpenText;
        private OpenFileDialog openFile;
        private Button btnGuardar;
        private Button btnActualizar;
        private SaveFileDialog saveFile;
        private CheckBox chkGetFirstLine;
    }
}