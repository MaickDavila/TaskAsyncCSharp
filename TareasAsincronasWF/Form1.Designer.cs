namespace TareasAsincronasWF
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
            this.progreso1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblprogreso = new System.Windows.Forms.TextBox();
            this.lblprogreso2 = new System.Windows.Forms.TextBox();
            this.progreso2 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progreso1
            // 
            this.progreso1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progreso1.Location = new System.Drawing.Point(12, 57);
            this.progreso1.Name = "progreso1";
            this.progreso1.Size = new System.Drawing.Size(773, 23);
            this.progreso1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblprogreso
            // 
            this.lblprogreso.BackColor = System.Drawing.SystemColors.Control;
            this.lblprogreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblprogreso.Location = new System.Drawing.Point(725, 86);
            this.lblprogreso.Name = "lblprogreso";
            this.lblprogreso.Size = new System.Drawing.Size(60, 13);
            this.lblprogreso.TabIndex = 6;
            this.lblprogreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblprogreso2
            // 
            this.lblprogreso2.BackColor = System.Drawing.SystemColors.Control;
            this.lblprogreso2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblprogreso2.Location = new System.Drawing.Point(725, 134);
            this.lblprogreso2.Name = "lblprogreso2";
            this.lblprogreso2.Size = new System.Drawing.Size(60, 13);
            this.lblprogreso2.TabIndex = 8;
            this.lblprogreso2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progreso2
            // 
            this.progreso2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progreso2.Location = new System.Drawing.Point(12, 105);
            this.progreso2.Name = "progreso2";
            this.progreso2.Size = new System.Drawing.Size(773, 23);
            this.progreso2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(133, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ejecutar 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblprogreso2);
            this.Controls.Add(this.progreso2);
            this.Controls.Add(this.lblprogreso);
            this.Controls.Add(this.progreso1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas Asincronas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progreso1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblprogreso;
        private System.Windows.Forms.TextBox lblprogreso2;
        private System.Windows.Forms.ProgressBar progreso2;
        private System.Windows.Forms.Button button2;
    }
}

