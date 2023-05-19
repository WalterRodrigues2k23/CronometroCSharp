namespace Cronometro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnIniciar = new Button();
            btnParar = new Button();
            btnReiniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 205, 151);
            btnIniciar.FlatStyle = FlatStyle.Popup;
            btnIniciar.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(95, 159);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(160, 60);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnParar
            // 
            btnParar.BackColor = Color.FromArgb(247, 86, 91);
            btnParar.FlatStyle = FlatStyle.Popup;
            btnParar.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnParar.ForeColor = Color.White;
            btnParar.Location = new Point(321, 159);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(160, 60);
            btnParar.TabIndex = 0;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = false;
            btnParar.Click += btnParar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(25, 130, 196);
            btnReiniciar.FlatStyle = FlatStyle.Popup;
            btnReiniciar.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(546, 159);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(160, 60);
            btnReiniciar.TabIndex = 0;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("OCR A Extended", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 15);
            label2.Name = "label2";
            label2.Size = new Size(750, 99);
            label2.TabIndex = 3;
            label2.Text = "00:00:00:000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(786, 300);
            Controls.Add(label2);
            Controls.Add(btnReiniciar);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer By WalterRodrigues";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Button btnParar;
        private Button btnReiniciar;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
    }
}