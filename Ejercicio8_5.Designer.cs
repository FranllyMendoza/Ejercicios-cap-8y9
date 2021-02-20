
namespace Ejercicios_cap_8y9
{
    partial class Ejercicio8_5
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
            this.listaDecadenaslist = new System.Windows.Forms.ListBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Cadena1TextBox = new System.Windows.Forms.TextBox();
            this.Cadena2TextBox = new System.Windows.Forms.TextBox();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaDecadenaslist
            // 
            this.listaDecadenaslist.FormattingEnabled = true;
            this.listaDecadenaslist.ItemHeight = 25;
            this.listaDecadenaslist.Location = new System.Drawing.Point(268, 22);
            this.listaDecadenaslist.Margin = new System.Windows.Forms.Padding(4);
            this.listaDecadenaslist.Name = "listaDecadenaslist";
            this.listaDecadenaslist.Size = new System.Drawing.Size(186, 254);
            this.listaDecadenaslist.TabIndex = 6;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(13, 240);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(141, 36);
            this.NuevoButton.TabIndex = 6;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // Cadena1TextBox
            // 
            this.Cadena1TextBox.Location = new System.Drawing.Point(13, 38);
            this.Cadena1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Cadena1TextBox.Name = "Cadena1TextBox";
            this.Cadena1TextBox.Size = new System.Drawing.Size(215, 31);
            this.Cadena1TextBox.TabIndex = 1;
            // 
            // Cadena2TextBox
            // 
            this.Cadena2TextBox.Location = new System.Drawing.Point(13, 115);
            this.Cadena2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Cadena2TextBox.Name = "Cadena2TextBox";
            this.Cadena2TextBox.Size = new System.Drawing.Size(214, 31);
            this.Cadena2TextBox.TabIndex = 2;
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(13, 181);
            this.AceptarButton.Margin = new System.Windows.Forms.Padding(4);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(141, 36);
            this.AceptarButton.TabIndex = 5;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadena 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadena 2:";
            // 
            // Ejercicio8_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 315);
            this.Controls.Add(this.listaDecadenaslist);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Cadena2TextBox);
            this.Controls.Add(this.Cadena1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ejercicio8_5";
            this.Text = "Ejercicio8_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaDecadenaslist;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox Cadena1TextBox;
        private System.Windows.Forms.TextBox Cadena2TextBox;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}