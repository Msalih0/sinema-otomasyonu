namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            char[] satirlar = { 'A', 'B', 'C', 'D', 'E' };
            for (int d = 0; d < 5; d++) 
            {
                for (int y = 1; y <= 10; y++) 
                {
                    Button btnKoltuk = new Button();
                    btnKoltuk.Text = satirlar[d] + y.ToString(); 
                    btnKoltuk.Width = 50;  
                    btnKoltuk.Height = 50; 

                    
                    btnKoltuk.Left = ((y - 1) * 55) + 12;
                    btnKoltuk.Top = (d * 55) + 12;

                    btnKoltuk.BackColor = Color.White; 
                                                       
                    btnKoltuk.Click += Koltuk_Tiklandi;
                    
                    this.Controls.Add(btnKoltuk);
                }
            }
        }
        private void Koltuk_Tiklandi(object sender, EventArgs e)
        {
            Button basilanKoltuk = (Button)sender;
            if (basilanKoltuk.BackColor == Color.White)
                basilanKoltuk.BackColor = Color.Green; 

            else if (basilanKoltuk.BackColor == Color.Green)
                basilanKoltuk.BackColor = Color.White; 

            else if (basilanKoltuk.BackColor == Color.Red)
                basilanKoltuk.BackColor = Color.Orange; 

            else if (basilanKoltuk.BackColor == Color.Orange)
                basilanKoltuk.BackColor = Color.Red; 
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control nesne = this.Controls[i];
                if (nesne is Button && nesne.Width == 50 && nesne.BackColor == Color.Green)
                {
                    nesne.BackColor = Color.Red; 
                }
            }
            MessageBox.Show("Biletler başarıyla onaylandı!");
        }

        private void sil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control nesne = this.Controls[i];
                if (nesne is Button && nesne.Width == 50 && nesne.BackColor == Color.Orange)
                {
                    nesne.BackColor = Color.White; 
                }
            }
        }
    }
}
    
