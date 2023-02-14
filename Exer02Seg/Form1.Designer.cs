namespace Exer02Seg
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.lblGrauspconver = new System.Windows.Forms.Label();
            this.lblgrausconvertidos = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.txtGrauspconverter = new System.Windows.Forms.TextBox();
            this.txtGrausconvertidos = new System.Windows.Forms.TextBox();
            this.cboGraus = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(235, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Conversão de Graus";
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // lblGrauspconver
            // 
            this.lblGrauspconver.AutoSize = true;
            this.lblGrauspconver.Location = new System.Drawing.Point(29, 98);
            this.lblGrauspconver.Name = "lblGrauspconver";
            this.lblGrauspconver.Size = new System.Drawing.Size(270, 31);
            this.lblGrauspconver.TabIndex = 1;
            this.lblGrauspconver.Text = "Graus para converter";
            // 
            // lblgrausconvertidos
            // 
            this.lblgrausconvertidos.AutoSize = true;
            this.lblgrausconvertidos.Location = new System.Drawing.Point(29, 328);
            this.lblgrausconvertidos.Name = "lblgrausconvertidos";
            this.lblgrausconvertidos.Size = new System.Drawing.Size(235, 31);
            this.lblgrausconvertidos.TabIndex = 2;
            this.lblgrausconvertidos.Text = "Graus convertidos";
            this.lblgrausconvertidos.Click += new System.EventHandler(this.lblgrausconvertidos_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(495, 189);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(167, 50);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtGrauspconverter
            // 
            this.txtGrauspconverter.Location = new System.Drawing.Point(495, 91);
            this.txtGrauspconverter.Name = "txtGrauspconverter";
            this.txtGrauspconverter.Size = new System.Drawing.Size(167, 38);
            this.txtGrauspconverter.TabIndex = 4;
            // 
            // txtGrausconvertidos
            // 
            this.txtGrausconvertidos.Location = new System.Drawing.Point(495, 325);
            this.txtGrausconvertidos.Name = "txtGrausconvertidos";
            this.txtGrausconvertidos.ReadOnly = true;
            this.txtGrausconvertidos.Size = new System.Drawing.Size(167, 38);
            this.txtGrausconvertidos.TabIndex = 5;
            // 
            // cboGraus
            // 
            this.cboGraus.FormattingEnabled = true;
            this.cboGraus.Items.AddRange(new object[] {
            "Celsius p/ Fahreinheit",
            "Fahreinheit p/ Celsius"});
            this.cboGraus.Location = new System.Drawing.Point(35, 196);
            this.cboGraus.Name = "cboGraus";
            this.cboGraus.Size = new System.Drawing.Size(300, 39);
            this.cboGraus.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(261, 410);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(166, 45);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 467);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cboGraus);
            this.Controls.Add(this.txtGrausconvertidos);
            this.Controls.Add(this.txtGrauspconverter);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblgrausconvertidos);
            this.Controls.Add(this.lblGrauspconver);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txtGrausconvertidos;
        private System.Windows.Forms.TextBox txtGrauspconverter;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblgrausconvertidos;
        private System.Windows.Forms.Label lblGrauspconver;
        private System.Windows.Forms.Label lblTitulo;
        private System.IO.FileSystemWatcher fileSystemWatcher2;
        private System.Windows.Forms.ComboBox cboGraus;
        private System.Windows.Forms.Button btnLimpar;
    }
}

