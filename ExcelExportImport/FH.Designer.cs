namespace ExcelExportImport
{
    partial class FH
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBlocNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(215, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Word";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(215, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 57);
            this.button2.TabIndex = 0;
            this.button2.Text = "Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(19, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 57);
            this.button3.TabIndex = 0;
            this.button3.Text = "Powepoint";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBlocNote
            // 
            this.btnBlocNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlocNote.Location = new System.Drawing.Point(19, 20);
            this.btnBlocNote.Name = "btnBlocNote";
            this.btnBlocNote.Size = new System.Drawing.Size(190, 57);
            this.btnBlocNote.TabIndex = 0;
            this.btnBlocNote.Text = "Bloc de nota";
            this.btnBlocNote.UseVisualStyleBackColor = true;
            this.btnBlocNote.Click += new System.EventHandler(this.btnBlocNote_Click);
            // 
            // FH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(427, 160);
            this.Controls.Add(this.btnBlocNote);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FH";
            this.Text = "FH";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnBlocNote;
    }
}