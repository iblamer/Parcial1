namespace Parcial1
{
    partial class Consulta
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
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.filtroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Location = new System.Drawing.Point(40, 90);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.Size = new System.Drawing.Size(685, 334);
            this.DatosdataGridView.TabIndex = 0;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(515, 34);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 39);
            this.buscarBtn.TabIndex = 1;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Nombre",
            "Id"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(40, 43);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // filtroTextBox
            // 
            this.filtroTextBox.Location = new System.Drawing.Point(180, 44);
            this.filtroTextBox.Name = "filtroTextBox";
            this.filtroTextBox.Size = new System.Drawing.Size(315, 20);
            this.filtroTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtroTextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.DatosdataGridView);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Label label1;
    }
}