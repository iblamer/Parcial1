namespace Parcial1
{
    partial class Registro
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
            this.buscarBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.LimitetextBox = new System.Windows.Forms.TextBox();
            this.FechamaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ConsultalinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(136, 24);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 0;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(174, 208);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(75, 23);
            this.modificarBtn.TabIndex = 1;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(93, 208);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 2;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(12, 208);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 3;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(12, 24);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(118, 20);
            this.IdtextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha De Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Limite de credito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre y apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Id";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(12, 75);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(196, 20);
            this.NombretextBox.TabIndex = 10;
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // LimitetextBox
            // 
            this.LimitetextBox.Location = new System.Drawing.Point(12, 177);
            this.LimitetextBox.Name = "LimitetextBox";
            this.LimitetextBox.Size = new System.Drawing.Size(196, 20);
            this.LimitetextBox.TabIndex = 11;
            // 
            // FechamaskedTextBox
            // 
            this.FechamaskedTextBox.Location = new System.Drawing.Point(15, 126);
            this.FechamaskedTextBox.Mask = "00/00/0000";
            this.FechamaskedTextBox.Name = "FechamaskedTextBox";
            this.FechamaskedTextBox.Size = new System.Drawing.Size(115, 20);
            this.FechamaskedTextBox.TabIndex = 12;
            this.FechamaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ConsultalinkLabel
            // 
            this.ConsultalinkLabel.AutoSize = true;
            this.ConsultalinkLabel.Location = new System.Drawing.Point(12, 240);
            this.ConsultalinkLabel.Name = "ConsultalinkLabel";
            this.ConsultalinkLabel.Size = new System.Drawing.Size(51, 13);
            this.ConsultalinkLabel.TabIndex = 13;
            this.ConsultalinkLabel.TabStop = true;
            this.ConsultalinkLabel.Text = "Consultar";
            this.ConsultalinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConsultalinkLabel_LinkClicked);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 262);
            this.Controls.Add(this.ConsultalinkLabel);
            this.Controls.Add(this.FechamaskedTextBox);
            this.Controls.Add(this.LimitetextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.buscarBtn);
            this.Name = "Registro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox LimitetextBox;
        private System.Windows.Forms.MaskedTextBox FechamaskedTextBox;
        private System.Windows.Forms.LinkLabel ConsultalinkLabel;
    }
}

