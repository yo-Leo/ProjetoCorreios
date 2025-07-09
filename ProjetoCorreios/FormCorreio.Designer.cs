
namespace ProjetoCorreios
{
    partial class FormCorreio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCorreio));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtCEP = new TextBox();
            btnBuscar = new Button();
            txtLogradouro = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            txtEstado = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 103);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(129, 22);
            label1.TabIndex = 1;
            label1.Text = "Insira seu CEP";
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtCEP.Location = new Point(12, 159);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(230, 29);
            txtCEP.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(64, 194);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtLogradouro.Location = new Point(12, 321);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(230, 29);
            txtLogradouro.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(12, 296);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 4;
            label2.Text = "Logradouro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiBold", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(164, 34);
            label3.TabIndex = 6;
            label3.Text = "RESULTADO";
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtBairro.Location = new Point(12, 380);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(230, 29);
            txtBairro.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(12, 355);
            label4.Name = "label4";
            label4.Size = new Size(63, 22);
            label4.TabIndex = 7;
            label4.Text = "Bairro";
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtCidade.Location = new Point(12, 439);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(230, 29);
            txtCidade.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(12, 414);
            label5.Name = "label5";
            label5.Size = new Size(66, 22);
            label5.TabIndex = 9;
            label5.Text = "Cidade";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold);
            txtEstado.Location = new Point(12, 498);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(230, 29);
            txtEstado.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(12, 473);
            label6.Name = "label6";
            label6.Size = new Size(66, 22);
            label6.TabIndex = 11;
            label6.Text = "Estado";
            // 
            // FormCorreio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 214, 38);
            ClientSize = new Size(1513, 647);
            Controls.Add(txtEstado);
            Controls.Add(label6);
            Controls.Add(txtCidade);
            Controls.Add(label5);
            Controls.Add(txtBairro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLogradouro);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtCEP);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormCorreio";
            Text = "FormCorreio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ad(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtCEP;
        private Button btnBuscar;
        private TextBox txtLogradouro;
        private Label label2;
        private Label label3;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtEstado;
        private Label label6;
    }
}
