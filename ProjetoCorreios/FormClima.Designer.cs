namespace ProjetoCorreios
{
    partial class FormClima
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
            pictureBox1 = new PictureBox();
            txtCidade = new TextBox();
            label1 = new Label();
            btnBuscar = new Button();
            label3 = new Label();
            txtClima = new TextBox();
            label2 = new Label();
            txtTemp = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._74b39b053ba4443240a862be7e7b805d_fgraphic;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 172);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtCidade.Location = new Point(12, 227);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(230, 29);
            txtCidade.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 202);
            label1.Name = "label1";
            label1.Size = new Size(150, 22);
            label1.TabIndex = 3;
            label1.Text = "Insira sua cidade";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(64, 262);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(12, 326);
            label3.Name = "label3";
            label3.Size = new Size(164, 34);
            label3.TabIndex = 7;
            label3.Text = "RESULTADO";
            // 
            // txtClima
            // 
            txtClima.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtClima.Location = new Point(12, 408);
            txtClima.Name = "txtClima";
            txtClima.Size = new Size(230, 29);
            txtClima.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(12, 383);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 8;
            label2.Text = "Clima";
            // 
            // txtTemp
            // 
            txtTemp.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtTemp.Location = new Point(12, 465);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(230, 29);
            txtTemp.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(12, 440);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 10;
            label4.Text = "Temperatura";
            // 
            // FormClima
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 101, 174);
            ClientSize = new Size(1513, 647);
            Controls.Add(txtTemp);
            Controls.Add(label4);
            Controls.Add(txtClima);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnBuscar);
            Controls.Add(txtCidade);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormClima";
            Text = "FormClima";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtCidade;
        private Label label1;
        private Button btnBuscar;
        private Label label3;
        private TextBox txtClima;
        private Label label2;
        private TextBox txtTemp;
        private Label label4;
    }
}