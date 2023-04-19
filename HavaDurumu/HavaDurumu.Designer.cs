namespace HavaDurumuUI
{
    partial class FrmHavaDurumu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHavaDurumu));
            lblSehir = new Label();
            txtSehir = new TextBox();
            btnGoster = new Button();
            lblSonuc = new Label();
            pbox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbox).BeginInit();
            SuspendLayout();
            // 
            // lblSehir
            // 
            lblSehir.AutoSize = true;
            lblSehir.Location = new Point(21, 25);
            lblSehir.Name = "lblSehir";
            lblSehir.Size = new Size(73, 32);
            lblSehir.TabIndex = 0;
            lblSehir.Text = "Şehir:";
            // 
            // txtSehir
            // 
            txtSehir.Location = new Point(103, 22);
            txtSehir.Name = "txtSehir";
            txtSehir.Size = new Size(291, 38);
            txtSehir.TabIndex = 1;
            txtSehir.KeyDown += TxtSehir_KeyDown;
            // 
            // btnGoster
            // 
            btnGoster.Location = new Point(400, 18);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(142, 44);
            btnGoster.TabIndex = 2;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += BtnGoster_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.Location = new Point(21, 82);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(525, 497);
            lblSonuc.TabIndex = 3;
            // 
            // pbox
            // 
            pbox.BackColor = SystemColors.ButtonHighlight;
            pbox.Location = new Point(409, 124);
            pbox.Name = "pbox";
            pbox.Size = new Size(133, 95);
            pbox.SizeMode = PictureBoxSizeMode.CenterImage;
            pbox.TabIndex = 4;
            pbox.TabStop = false;
            // 
            // FrmHavaDurumu
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 590);
            Controls.Add(pbox);
            Controls.Add(lblSonuc);
            Controls.Add(btnGoster);
            Controls.Add(txtSehir);
            Controls.Add(lblSehir);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHavaDurumu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hava Durumu";
            ((System.ComponentModel.ISupportInitialize)pbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSehir;
        private TextBox txtSehir;
        private Button btnGoster;
        private Label lblSonuc;
        private PictureBox pbox;
    }
}