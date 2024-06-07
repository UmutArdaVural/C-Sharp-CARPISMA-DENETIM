/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				        NESNEYEDAYALI  PROGRAMLAMA   DERSİ 
**	
**				ÖDEV NUMARASI…...: 2
**				ÖĞRENCİ ADI......: UMUT ARDA VURAL
**				ÖĞRENCİ NUMARASI.: B231210081
**				DERS GRUBU………...…:  B
****************************************************************************/


using System.Security.Cryptography.X509Certificates;

namespace Çarpışma_denetimi_başlangıç
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac == 2)
            {
                this.Hide();
                Form2 form2aç = new Form2();
                form2aç.Show();
                timer1.Stop();  
            }
        }
    }
}
