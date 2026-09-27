namespace WinFormsApp2
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
            ekle = new Button();
            sil = new Button();
            SuspendLayout();
            // 
            // ekle
            // 
            ekle.Location = new Point(582, 102);
            ekle.Name = "ekle";
            ekle.Size = new Size(119, 107);
            ekle.TabIndex = 0;
            ekle.Text = "ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // sil
            // 
            sil.Location = new Point(582, 225);
            sil.Name = "sil";
            sil.Size = new Size(119, 107);
            sil.TabIndex = 1;
            sil.Text = "sil";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sil);
            Controls.Add(ekle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ekle;
        private Button sil;
    }
}
