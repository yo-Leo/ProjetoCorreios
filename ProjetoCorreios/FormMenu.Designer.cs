namespace ProjetoCorreios
{
    partial class FormMenu
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
            label3 = new Label();
            btnCorreios = new Button();
            btnClimatempo = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 23F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(543, 9);
            label3.Name = "label3";
            label3.Size = new Size(389, 55);
            label3.TabIndex = 7;
            label3.Text = "MENU PRINCIPAL";
            // 
            // btnCorreios
            // 
            btnCorreios.Location = new Point(302, 267);
            btnCorreios.Name = "btnCorreios";
            btnCorreios.Size = new Size(185, 88);
            btnCorreios.TabIndex = 8;
            btnCorreios.Text = "CORREIOS";
            btnCorreios.UseVisualStyleBackColor = true;
            btnCorreios.Click += btnCorreios_Click;
            // 
            // btnClimatempo
            // 
            btnClimatempo.Location = new Point(986, 267);
            btnClimatempo.Name = "btnClimatempo";
            btnClimatempo.Size = new Size(185, 88);
            btnClimatempo.TabIndex = 9;
            btnClimatempo.Text = "CLIMA TEMPO";
            btnClimatempo.UseVisualStyleBackColor = true;
            btnClimatempo.Click += btnClimatempo_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1513, 647);
            Controls.Add(btnClimatempo);
            Controls.Add(btnCorreios);
            Controls.Add(label3);
            Name = "FormMenu";
            Text = "FormMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnCorreios;
        private Button btnClimatempo;
    }
}