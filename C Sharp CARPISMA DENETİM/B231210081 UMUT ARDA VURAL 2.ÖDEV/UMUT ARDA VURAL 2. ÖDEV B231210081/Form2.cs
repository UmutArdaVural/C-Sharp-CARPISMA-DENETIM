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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic;

namespace Çarpışma_denetimi_başlangıç
{

    public partial class Form2 : Form
    {


        public Form2()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = 0;
            cisim1radiobtn.Checked = true;

        }


        /*nesnelerimizi liste ekledik ve neseler clasından nesneleri çağırdık  */


        NESNELER<int> nesne = new NESNELER<int>();

        PRİZMA<int> prizma1 = new PRİZMA<int>();

        SİLİNDİR<int> SİLİNDİR = new SİLİNDİR<int>();

        CEMBER<int> cember = new CEMBER<int>();

        NOKTA<int> NOKTA = new NOKTA<int>();

        DİKDÖRTGEN<int> DİKDÖRTGEN = new DİKDÖRTGEN<int>();

        KURE<int> KURE = new KURE<int>();

        PRİZMA<int> PRİZMA = new PRİZMA<int>();

        YUZEY<int> yuzey = new YUZEY<int>();



        private void button1_Click(object sender, EventArgs e)
        {

            // önceki çizilenler gitmesi için temizleriz 

            pictureBox1.Refresh();





            if (comboBox1.SelectedIndex == 0)
            {
                // kontrol edildi  


                //    a) Nokta, dİKDÖRTGEN  çarpışma denetimi
                NOKTA.x1 = Convert.ToInt32(Xkor1.Text);
                NOKTA.y1 = Convert.ToInt32(ykor1.Text);

                DİKDÖRTGEN.x2 = Convert.ToInt32(xkor2.Text);
                DİKDÖRTGEN.y2 = Convert.ToInt32(ykor2.Text);
                DİKDÖRTGEN.genişlik2 = Convert.ToInt32(genislik2.Text);
                DİKDÖRTGEN.yukseklik2 = Convert.ToInt32(yukseklik2.Text);

                NOKTA.noktacizim(pictureBox1);

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktadikdörtgendenetim(NOKTA.x1, NOKTA.y1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                // kontrol edildi  

                // b) Nokta, çember çarpışma denetimi
                NOKTA.x1 = Convert.ToInt32(Xkor1.Text);
                NOKTA.y1 = Convert.ToInt32(ykor1.Text);


                cember.x2 = Convert.ToInt32(xkor2.Text);
                cember.y2 = Convert.ToInt32(ykor2.Text);
                cember.cap2 = Convert.ToInt32(cap2.Text);

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                cember.sagacemberciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktaçemberdenetim(NOKTA.x1, NOKTA.y1, cember.y2, cember.x2, cember.cap2);

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


                // c) Dikdörtgen, dikdörtgen çarpışma denetimi

                DİKDÖRTGEN.x1 = Convert.ToInt32(Xkor1.Text);
                DİKDÖRTGEN.y1 = Convert.ToInt32(ykor1.Text);
                DİKDÖRTGEN.genişlik1 = Convert.ToInt32(genişlik1.Text);
                DİKDÖRTGEN.yukseklik1 = Convert.ToInt32(yükseklik1.Text);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);

                DİKDÖRTGEN.x2 = Convert.ToInt32(xkor2.Text);
                DİKDÖRTGEN.y2 = Convert.ToInt32(ykor2.Text);
                DİKDÖRTGEN.genişlik2 = Convert.ToInt32(genislik2.Text);
                DİKDÖRTGEN.yukseklik2 = Convert.ToInt32(yukseklik2.Text);

                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);

                denetimcapıs.DİKDÖRTGENdikrdötgencarpısma(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //   d) Dikdörtgen, çember çarpışma denetimi
                DİKDÖRTGEN.x1 = Convert.ToInt32(Xkor1.Text);
                DİKDÖRTGEN.y1 = Convert.ToInt32(ykor1.Text);
                DİKDÖRTGEN.genişlik1 = Convert.ToInt32(genişlik1.Text);
                DİKDÖRTGEN.yukseklik1 = Convert.ToInt32(yükseklik1.Text);

                cember.x2 = Convert.ToInt32(xkor2.Text);
                cember.y2 = Convert.ToInt32(ykor2.Text);
                cember.cap2 = Convert.ToInt32(cap2.Text);
                // cizdirme kısmı 
                cember.sagacemberciz(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.dikdörtgencember(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, cember.y2, cember.x2, cember.cap2);
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                // e) Çember, çember çarpışma denetimi
                cember.x1 = Convert.ToInt32(Xkor1.Text);
                cember.y1 = Convert.ToInt32(ykor1.Text);
                cember.cap1 = Convert.ToInt32(cap1.Text);

                cember.solacemberciz(pictureBox1);


                cember.x2 = Convert.ToInt32(xkor2.Text);
                cember.y2 = Convert.ToInt32(ykor2.Text);
                cember.cap2 = Convert.ToInt32(cap2.Text);
                // cizdirme  kısmı 
                cember.solacemberciz(pictureBox1);
                cember.sagacemberciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.cembercember(cember.x1, cember.y1, cember.cap1, cember.cap2, cember.y2, cember.x2);

            }

            else if (comboBox1.SelectedIndex == 5)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                // f) Nokta, Küre çarpışma denetimi
                NOKTA.x1 = Convert.ToInt32(Xkor1.Text);
                NOKTA.y1 = Convert.ToInt32(ykor1.Text);
                NOKTA.z1 = Convert.ToInt32(zkor1.Text);

                KURE.cap2 = Convert.ToInt32(cap2.Text);
                KURE.x2 = Convert.ToInt32(xkor2.Text);
                KURE.y2 = Convert.ToInt32(ykor2.Text);
                KURE.z2 = Convert.ToInt32(zkor2.Text);

                // CİZDİRME KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                KURE.sagackureciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktakure(NOKTA.x1, NOKTA.y1, KURE.y2, KURE.x2, KURE.cap2, NOKTA.z1, KURE.z2);
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


                //  g) Nokta, dikdörtgen prizma çarpışma denetimi
                NOKTA.x1 = Convert.ToInt32(Xkor1.Text);
                NOKTA.y1 = Convert.ToInt32(ykor1.Text);

                PRİZMA.x2 = Convert.ToInt32(xkor2.Text);
                PRİZMA.y2 = Convert.ToInt32(ykor2.Text);
                PRİZMA.yukseklik2 = Convert.ToInt32(yukseklik2.Text);
                PRİZMA.genişlik2 = Convert.ToInt32(genislik2.Text);
                PRİZMA.derinlik2 = Convert.ToInt32(cap2.Text);

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                PRİZMA.sagaprizmaciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktaprizma(NOKTA.x1, NOKTA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //     h) Nokta, Silindir çarpışma denetimi
                NOKTA.x1 = Convert.ToInt32(Xkor1.Text);
                NOKTA.y1 = Convert.ToInt32(ykor1.Text);
                NOKTA.z1 = Convert.ToInt32(zkor1.Text);

                SİLİNDİR.x2 = Convert.ToInt32(xkor2.Text);
                SİLİNDİR.y2 = Convert.ToInt32(ykor2.Text);
                SİLİNDİR.z2 = Convert.ToInt32(zkor2.Text);
                SİLİNDİR.cap2 = Convert.ToInt32(cap2.Text);
                SİLİNDİR.yukseklik2 = Convert.ToInt32(yukseklik2.Text);

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                SİLİNDİR.sagasilindirciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktasilindir(NOKTA.x1, NOKTA.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, NOKTA.z1, SİLİNDİR.z2);


            }

            else if (comboBox1.SelectedIndex == 8)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //    i) Silindir, silindir çarpışma denetimi

                SİLİNDİR.x1 = Convert.ToInt32(Xkor1.Text);
                SİLİNDİR.y1 = Convert.ToInt32(ykor1.Text);
                SİLİNDİR.cap1 = Convert.ToInt32(cap1.Text);
                SİLİNDİR.yukseklik1 = Convert.ToInt32(yükseklik1.Text);
                SİLİNDİR.z1 = Convert.ToInt32(zkor1.Text);


                SİLİNDİR.x2 = Convert.ToInt32(xkor2.Text);
                SİLİNDİR.y2 = Convert.ToInt32(ykor2.Text);
                SİLİNDİR.cap2 = Convert.ToInt32(cap2.Text);
                SİLİNDİR.z2 = Convert.ToInt32(zkor2.Text);
                SİLİNDİR.yukseklik2 = Convert.ToInt32(yukseklik2.Text);

                // cizdirme kısmı
                SİLİNDİR.solasilindirciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.silindirsilindir(SİLİNDİR.x1, SİLİNDİR.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, SİLİNDİR.z1, SİLİNDİR.z2, SİLİNDİR.yukseklik1, SİLİNDİR.cap1);

            }

            else if (comboBox1.SelectedIndex == 9)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //    j) Küre, küre çarpışma denetimi

                KURE.cap1 = Convert.ToInt32(cap1.Text);
                KURE.x1 = Convert.ToInt32(Xkor1.Text);
                KURE.y1 = Convert.ToInt32(ykor1.Text);
                KURE.z1 = Convert.ToInt32(zkor1.Text);
                KURE.solackureciz(pictureBox1);

                KURE.cap2 = Convert.ToInt32(cap2.Text);
                KURE.x2 = Convert.ToInt32(xkor2.Text);
                KURE.y2 = Convert.ToInt32(ykor2.Text);
                KURE.z2 = Convert.ToInt32(zkor2.Text);
                KURE.sagackureciz(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.kurekure(KURE.x1, KURE.y1, KURE.y2, KURE.x2, KURE.cap2, KURE.z1, KURE.z2, KURE.cap1);
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //     k) Küre silindir çarpışma denetimi

                KURE.cap1 = Convert.ToInt32(cap1.Text);
                KURE.x1 = Convert.ToInt32(Xkor1.Text);
                KURE.y1 = Convert.ToInt32(ykor1.Text);
                KURE.z1 = Convert.ToInt32(zkor1.Text);
                KURE.solackureciz(pictureBox1);

                SİLİNDİR.x2 = Convert.ToInt32(xkor2.Text);
                SİLİNDİR.y2 = Convert.ToInt32(ykor2.Text);
                SİLİNDİR.cap2 = Convert.ToInt32(cap2.Text);
                SİLİNDİR.yukseklik2 = Convert.ToInt32(yukseklik2.Text);
                SİLİNDİR.z2 = Convert.ToInt32(zkor2.Text);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                //  carpısma denetim
                denetimcapıs.kuresilindir(KURE.x1, KURE.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, KURE.z1, SİLİNDİR.z2, KURE.cap1, SİLİNDİR.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 11)
            {            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //  l) Yüzey, küre çarpışma denetimi
                yuzey.derinlik1 = Convert.ToInt32(Derinlik.Text);
                yuzey.x1 = Convert.ToInt32(Xkor1.Text);
                yuzey.y1 = Convert.ToInt32(ykor1.Text);
                yuzey.genişlik1 = Convert.ToInt32(genişlik1.Text); ;
                yuzey.solyuzeyçiz(pictureBox1);

                KURE.cap2 = Convert.ToInt32(cap2.Text);
                KURE.x2 = Convert.ToInt32(xkor2.Text);
                KURE.y2 = Convert.ToInt32(ykor2.Text);
                KURE.sagackureciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeykure(yuzey.x1, yuzey.y1, KURE.y2, KURE.x2, KURE.cap2, yuzey.genişlik1, yuzey.derinlik1);

            }

            else if (comboBox1.SelectedIndex == 12)
            {            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


                // m) Yüzey, dikdörtgen prizma çarpışma denetimi
                yuzey.derinlik1 = Convert.ToInt32(Derinlik.Text);
                yuzey.x1 = Convert.ToInt32(Xkor1.Text);
                yuzey.y1 = Convert.ToInt32(ykor1.Text);
                yuzey.genişlik1 = Convert.ToInt32(genişlik1.Text); ;
                yuzey.solyuzeyçiz(pictureBox1);

                PRİZMA.x2 = Convert.ToInt32(xkor2.Text);
                PRİZMA.y2 = Convert.ToInt32(ykor2.Text);
                PRİZMA.yukseklik2 = Convert.ToInt32(yukseklik2.Text);
                PRİZMA.genişlik2 = Convert.ToInt32(genislik2.Text);
                PRİZMA.derinlik2 = Convert.ToInt32(cap2.Text);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeyprizma(yuzey.x1, yuzey.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, yuzey.genişlik1, yuzey.derinlik1, PRİZMA.yukseklik2);
            }

            else if (comboBox1.SelectedIndex == 13)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //  n) Yüzey silindir çarpışma denetimi
                yuzey.derinlik1 = Convert.ToInt32(Derinlik.Text);
                yuzey.x1 = Convert.ToInt32(Xkor1.Text);
                yuzey.y1 = Convert.ToInt32(ykor1.Text);
                yuzey.genişlik1 = Convert.ToInt32(genişlik1.Text); ;
                yuzey.solyuzeyçiz(pictureBox1);

                SİLİNDİR.x2 = Convert.ToInt32(xkor2.Text);
                SİLİNDİR.y2 = Convert.ToInt32(ykor2.Text);
                SİLİNDİR.cap2 = Convert.ToInt32(cap2.Text);
                SİLİNDİR.yukseklik2 = Convert.ToInt32(yukseklik2.Text);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeysilindir(yuzey.x1, yuzey.y1, SİLİNDİR.y2, SİLİNDİR.x2, yuzey.genişlik1, yuzey.derinlik1, SİLİNDİR.yukseklik2, SİLİNDİR.cap2);

            }

            else if (comboBox1.SelectedIndex == 14)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //     o) Küre, dikdörtgen prizma çarpışma denetimi

                KURE.cap1 = Convert.ToInt32(cap1.Text);
                KURE.x1 = Convert.ToInt32(Xkor1.Text);
                KURE.y1 = Convert.ToInt32(ykor1.Text);
                KURE.solackureciz(pictureBox1);

                PRİZMA.x2 = Convert.ToInt32(xkor2.Text);
                PRİZMA.y2 = Convert.ToInt32(ykor2.Text);
                PRİZMA.yukseklik2 = Convert.ToInt32(yukseklik2.Text);
                PRİZMA.genişlik2 = Convert.ToInt32(genislik2.Text);
                PRİZMA.derinlik2 = Convert.ToInt32(cap2.Text);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.kureprizma(KURE.x1, KURE.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, KURE.cap1, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 15)
            {
                // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

                //    p) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi*/
                PRİZMA.x1 = Convert.ToInt32(Xkor1.Text);
                PRİZMA.y1 = Convert.ToInt32(ykor1.Text);
                PRİZMA.yukseklik1 = Convert.ToInt32(yükseklik1.Text);
                PRİZMA.genişlik1 = Convert.ToInt32(genişlik1.Text);
                PRİZMA.derinlik1 = Convert.ToInt32(Derinlik.Text);
                PRİZMA.solaprizmaciz(pictureBox1);

                PRİZMA.x2 = Convert.ToInt32(xkor2.Text);
                PRİZMA.y2 = Convert.ToInt32(ykor2.Text);
                PRİZMA.yukseklik2 = Convert.ToInt32(yukseklik2.Text);
                PRİZMA.genişlik2 = Convert.ToInt32(genislik2.Text);
                PRİZMA.derinlik2 = Convert.ToInt32(cap2.Text);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.prizmaprizma(PRİZMA.x1, PRİZMA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.genişlik1, PRİZMA.derinlik1, PRİZMA.yukseklik2, PRİZMA.derinlik2, PRİZMA.derinlik1);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            companentayarla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }




        public void companentayarla()
        {
            if (comboBox1.SelectedIndex == 0)
            {
                //Nokta, Dörtgen çarpışma denetimi
                groupBox1.Text = "Nokta";
                groupBox2.Text = "Dörtgen";

                // nokta için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false; zkor1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true;
                LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // dörtgen için olanlar
                zkor2.Visible = false; labelzkor2.Visible = false;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = true; genislik2.Visible = true;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = false; labelcap2.Visible = false;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                //Nokta, Çember çarpışma denetimi
                groupBox1.Text = "Nokta";
                groupBox2.Text = "Çember";

                // nokta için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false; zkor1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true;
                LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // Çember  için olanlar
                zkor2.Visible = false; labelzkor2.Visible = false;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = false; labelyukseklik2.Visible = false;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";


            }
            else if (comboBox1.SelectedIndex == 2)
            { //Dikdörtgen, Dikdörtgen çarpışma denetimi
                groupBox1.Text = "Dikdörtgen";
                groupBox2.Text = "Dikdörtgen";

                // Dikdörtgen için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = true; labelgenişlik1.Visible = true;
                yükseklik1.Visible = true; labelyükseklik1.Visible = true;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // Dikdörtgen 2 için olanlar
                zkor2.Visible = false; labelzkor2.Visible = false;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = true; genislik2.Visible = true;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = false; labelcap2.Visible = false;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 3)
            {//Dikdörtgen, Çember çarpışma denetimi
                groupBox1.Text = "Dikdörtgen";
                groupBox2.Text = "Çember";

                // Dikdörtgen için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = true; labelgenişlik1.Visible = true;
                yükseklik1.Visible = true; labelyükseklik1.Visible = true;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                //Çember 2 için olanalar 
                zkor2.Visible = false; labelzkor2.Visible = false;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = false; labelyukseklik2.Visible = false;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 4)
            {   // Çember, Çember çarpışma denetimi
                groupBox1.Text = "Çember";
                groupBox2.Text = "Çember";

                // Çember için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = true; cap1label.Visible = true;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                //Çember 2  için olanalar 
                zkor2.Visible = false; labelzkor2.Visible = false;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = false; labelyukseklik2.Visible = false;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 5)
            {
                // Nokta, Küre çarpışma denetimi
                groupBox1.Text = "Nokta";
                groupBox2.Text = "Küre";

                // Nokta için olanlar 
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true;
                LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // Küre için olanlar 
                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = false; labelyukseklik2.Visible = false;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 6)
            { // Nokta, Dikdörtgen Prizma  çarpışma denetimi
                groupBox1.Text = "Nokta";
                groupBox2.Text = "Dikdörtgen Prizma";

                // Nokta için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false; zkor1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true;
                LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // Dikdörtgen Prizma 

                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = true; genislik2.Visible = true;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Derinlik";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                // Nokta, Dikdörtgen Prizma  çarpışma denetimi
                groupBox1.Text = "Nokta";
                groupBox2.Text = "Silindir";

                // Nokta için olanlar 
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true;
                LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // silindir 

                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 8)
            {
                // Silindir, Silindir çarpışma denetimi
                groupBox1.Text = "Silindir";
                groupBox2.Text = "Silindir";

                // Silindir için olanlar 
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = true; labelyükseklik1.Visible = true;
                cap1.Visible = true; cap1label.Visible = true;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                //Silindir 2  için olanalar 
                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                // Küre, Küre çarpışma denetimi
                groupBox1.Text = "Küre";
                groupBox2.Text = "Küre";

                // Küre için olanlar 
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = true; cap1label.Visible = true;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // Küre için olanlar 
                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = false; labelyukseklik2.Visible = false;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";

            }
            else if (comboBox1.SelectedIndex == 10)
            {
                // Küre, Silindir çarpışma denetimi
                groupBox1.Text = "Küre";
                groupBox2.Text = "Silindir";

                // Küre için olanlar 
                Derinlik.Visible = false; Derinliklabel.Visible = false;
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = true; cap1label.Visible = true;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                //Silindir 2  için olanalar 
                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";
            }
            else if (comboBox1.SelectedIndex == 11)
            {
                // Yüzey, Silindir çarpışma denetimi
                groupBox1.Text = "Yüzey";
                groupBox2.Text = "Küre";

                // Yüzey için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = true; labelgenişlik1.Visible = true;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = true; Derinliklabel.Visible = true;

                // Küre için olanlar 
                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = false; labelyukseklik2.Visible = false;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";
            }
            else if (comboBox1.SelectedIndex == 12)
            {
                // Yüzey, Silindir çarpışma denetimi
                groupBox1.Text = "Yüzey";
                groupBox2.Text = "Dikdörtgen Prizma ";

                // Yüzey için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = true; labelgenişlik1.Visible = true;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = true; Derinliklabel.Visible = true;

                // Dikdörtgen Prizma 

                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = true; genislik2.Visible = true;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Derinlik";
            }
            else if (comboBox1.SelectedIndex == 13)
            {
                // Yüzey, Silindir çarpışma denetimi
                groupBox1.Text = "Yüzey";
                groupBox2.Text = "Silindir";

                // Yüzey için olanlar 
                zkor1.Visible = false; zlabel1.Visible = false;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = true; labelgenişlik1.Visible = true;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = true; Derinliklabel.Visible = true;

                //Silindir   için olanalar 
                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = false; genislik2.Visible = false;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Çap";
            }
            else if (comboBox1.SelectedIndex == 14)
            {
                // Küre, Dikdörtgen Prizma  çarpışma denetimi
                groupBox1.Text = "Küre";
                groupBox2.Text = "Dikdörtgen Prizma ";

                // Küre için olanlar 
                Derinlik.Visible = false; Derinliklabel.Visible = false;
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = false; labelgenişlik1.Visible = false;
                yükseklik1.Visible = false; labelyükseklik1.Visible = false;
                cap1.Visible = true; cap1label.Visible = true;
                Derinlik.Visible = false; Derinliklabel.Visible = false;

                // Dikdörtgen Prizma 

                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = true; genislik2.Visible = true;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Derinlik";


            }
            else if (comboBox1.SelectedIndex == 15)
            {
                // Dikdörtgen Prizma , Dikdörtgen Prizma  çarpışma denetimi
                groupBox1.Text = "Dikdörtgen Prizma";
                groupBox2.Text = "Dikdörtgen Prizma ";

                // Dikdörtgen Prizma için olanlar 
                Derinlik.Visible = false; Derinliklabel.Visible = false;
                zkor1.Visible = true; zlabel1.Visible = true;
                Xkor1.Visible = true; labelx.Visible = true;
                ykor1.Visible = true; LABELy1.Visible = true;
                genişlik1.Visible = true; labelgenişlik1.Visible = true;
                yükseklik1.Visible = true; labelyükseklik1.Visible = true;
                cap1.Visible = false; cap1label.Visible = false;
                Derinlik.Visible = true; Derinliklabel.Visible = true;

                // Dikdörtgen Prizma 2

                zkor2.Visible = true; labelzkor2.Visible = true;
                labelykor2.Visible = true; ykor2.Visible = true;
                labelgenislik2.Visible = true; genislik2.Visible = true;
                yukseklik2.Visible = true; labelyukseklik2.Visible = true;
                cap2.Visible = true; labelcap2.Visible = true;
                labelcap2.Text = "Derinlik";
            }
        }

        private void solabutton_Click(object sender, EventArgs e)
        {
            // PİCTRURE BOX IN TEMZİLENMESİ İÇİN 
            pictureBox1.Refresh();

            if (comboBox1.SelectedIndex == 0)
            {


                //    a) Nokta, dİKDÖRTGEN  çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 - 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x2 = DİKDÖRTGEN.x2 - 5;
                    xkor2.Text = Convert.ToString(DİKDÖRTGEN.x2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                NOKTA.noktacizim(pictureBox1);
                // denetim kısmı 
                denetimcapıs.noktadikdörtgendenetim(NOKTA.x1, NOKTA.y1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                // b) Nokta, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 - 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.x2 = cember.x2 - 5;
                    xkor2.Text = Convert.ToString(cember.x2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                cember.sagacemberciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktaçemberdenetim(NOKTA.x1, NOKTA.y1, cember.x2, cember.y2, cember.cap2);

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                // c) Dikdörtgen, dikdörtgen çarpışma denetimi


                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x1 = DİKDÖRTGEN.x1 - 5;
                    Xkor1.Text = Convert.ToString(DİKDÖRTGEN.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x2 = DİKDÖRTGEN.x2 - 5;
                    xkor2.Text = Convert.ToString(DİKDÖRTGEN.x2);
                }


                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);


                denetimcapıs.DİKDÖRTGENdikrdötgencarpısma(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 3)
            {

                //   d) Dikdörtgen, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x1 = DİKDÖRTGEN.x1 - 5;
                    Xkor1.Text = Convert.ToString(DİKDÖRTGEN.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.x2 = cember.x2 - 5;
                    xkor2.Text = Convert.ToString(cember.x2);
                }

                // cizdirme kısmı 
                cember.sagacemberciz(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.dikdörtgencember(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, cember.y2, cember.x2, cember.cap2);
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                // e) Çember, çember çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    cember.x1 = cember.x1 - 5;
                    Xkor1.Text = Convert.ToString(cember.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.x2 = cember.x2 - 5;
                    xkor2.Text = Convert.ToString(cember.x2);
                }

                // cizdirme  kısmı 
                cember.solacemberciz(pictureBox1);
                cember.sagacemberciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.cembercember(cember.x1, cember.y1, cember.cap1, cember.cap2, cember.y2, cember.x2);

            }

            else if (comboBox1.SelectedIndex == 5)
            {
                // f) Nokta, Küre çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 - 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.x2 = KURE.x2 - 5;
                    xkor2.Text = Convert.ToString(KURE.x2);
                }

                // CİZDİRME KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                KURE.sagackureciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktakure(NOKTA.x1, NOKTA.y1, KURE.y2, KURE.x2, KURE.cap2, NOKTA.z1, KURE.z2);
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                //  g) Nokta, dikdörtgen prizma çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 - 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 - 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                PRİZMA.sagaprizmaciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktaprizma(NOKTA.x1, NOKTA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                //     h) Nokta, Silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 - 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 - 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                SİLİNDİR.sagasilindirciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktasilindir(NOKTA.x1, NOKTA.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, NOKTA.z1, SİLİNDİR.z2);


            }

            else if (comboBox1.SelectedIndex == 8)
            {
                //    i) Silindir, silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    SİLİNDİR.x1 = SİLİNDİR.x1 - 5;
                    Xkor1.Text = Convert.ToString(SİLİNDİR.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 - 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }


                // cizdirme kısmı
                SİLİNDİR.solasilindirciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.silindirsilindir(SİLİNDİR.x1, SİLİNDİR.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, SİLİNDİR.z1, SİLİNDİR.z2, SİLİNDİR.yukseklik1, SİLİNDİR.cap1);

            }

            else if (comboBox1.SelectedIndex == 9)
            {
                //    j) Küre, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.x1 = KURE.x1 - 5;
                    Xkor1.Text = Convert.ToString(KURE.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.x2 = KURE.x2 - 5;
                    xkor2.Text = Convert.ToString(KURE.x2);
                }

                KURE.solackureciz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.kurekure(KURE.x1, KURE.y1, KURE.y2, KURE.x2, KURE.cap2, KURE.z1, KURE.z2, KURE.cap1);
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                //     k) Küre silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.x1 = KURE.x1 - 5;
                    Xkor1.Text = Convert.ToString(KURE.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 - 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }

                KURE.solackureciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                //  carpısma denetim
                denetimcapıs.kuresilindir(KURE.x1, KURE.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, KURE.z1, SİLİNDİR.z2, KURE.cap1, SİLİNDİR.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 11)
            {
                //  l) Yüzey, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.x1 = yuzey.x1 - 5;
                    Xkor1.Text = Convert.ToString(yuzey.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.x2 = KURE.x2 - 5;
                    xkor2.Text = Convert.ToString(KURE.x2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeykure(yuzey.x1, yuzey.y1, KURE.y2, KURE.x2, KURE.cap2, yuzey.genişlik1, yuzey.derinlik1);

            }

            else if (comboBox1.SelectedIndex == 12)
            {
                // m) Yüzey, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.x1 = yuzey.x1 - 5;
                    Xkor1.Text = Convert.ToString(yuzey.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 - 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }

                yuzey.solyuzeyçiz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeyprizma(yuzey.x1, yuzey.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, yuzey.genişlik1, yuzey.derinlik1, PRİZMA.yukseklik2);
            }

            else if (comboBox1.SelectedIndex == 13)
            {
                //  n) Yüzey silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.x1 = yuzey.x1 - 5;
                    Xkor1.Text = Convert.ToString(yuzey.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 - 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeysilindir(yuzey.x1, yuzey.y1, SİLİNDİR.y2, SİLİNDİR.x2, yuzey.genişlik1, yuzey.derinlik1, SİLİNDİR.yukseklik2, SİLİNDİR.cap2);

            }

            else if (comboBox1.SelectedIndex == 14)
            {
                //     o) Küre, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.x1 = KURE.x1 - 5;
                    Xkor1.Text = Convert.ToString(KURE.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 - 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }


                KURE.solackureciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.kureprizma(KURE.x1, KURE.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, KURE.cap1, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 15)
            {
                //    p) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi*/
                if (cisim1radiobtn.Checked == true)
                {
                    PRİZMA.x1 = PRİZMA.x1 - 5;
                    Xkor1.Text = Convert.ToString(PRİZMA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 - 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }


                PRİZMA.solaprizmaciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.prizmaprizma(PRİZMA.x1, PRİZMA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.genişlik1, PRİZMA.derinlik1, PRİZMA.yukseklik2, PRİZMA.derinlik2, PRİZMA.derinlik1);
            }
        }

        private void sagabutton_Click(object sender, EventArgs e)
        {

            // PİCTRURE BOX IN TEMZİLENMESİ İÇİN 
            pictureBox1.Refresh();

            if (comboBox1.SelectedIndex == 0)
            {


                //    a) Nokta, dİKDÖRTGEN  çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 + 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x2 = DİKDÖRTGEN.x2 + 5;
                    xkor2.Text = Convert.ToString(DİKDÖRTGEN.x2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktadikdörtgendenetim(NOKTA.x1, NOKTA.y1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                // b) Nokta, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 + 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.x2 = cember.x2 + 5;
                    xkor2.Text = Convert.ToString(cember.x2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                cember.sagacemberciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktaçemberdenetim(NOKTA.x1, NOKTA.y1, cember.x2, cember.y2, cember.cap2);

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                // c) Dikdörtgen, dikdörtgen çarpışma denetimi


                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x1 = DİKDÖRTGEN.x1 + 5;
                    Xkor1.Text = Convert.ToString(DİKDÖRTGEN.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x2 = DİKDÖRTGEN.x2 + 5;
                    xkor2.Text = Convert.ToString(DİKDÖRTGEN.x2);
                }


                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);


                denetimcapıs.DİKDÖRTGENdikrdötgencarpısma(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 3)
            {

                //   d) Dikdörtgen, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.x1 = DİKDÖRTGEN.x1 + 5;
                    Xkor1.Text = Convert.ToString(DİKDÖRTGEN.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.x2 = cember.x2 + 5;
                    xkor2.Text = Convert.ToString(cember.x2);
                }

                // cizdirme kısmı 
                cember.sagacemberciz(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.dikdörtgencember(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, cember.y2, cember.x2, cember.cap2);
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                // e) Çember, çember çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    cember.x1 = cember.x1 + 5;
                    Xkor1.Text = Convert.ToString(cember.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.x2 = cember.x2 + 5;
                    xkor2.Text = Convert.ToString(cember.x2);
                }

                // cizdirme  kısmı 
                cember.solacemberciz(pictureBox1);
                cember.sagacemberciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.cembercember(cember.x1, cember.y1, cember.cap1, cember.cap2, cember.y2, cember.x2);

            }

            else if (comboBox1.SelectedIndex == 5)
            {
                // f) Nokta, Küre çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 + 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.x2 = KURE.x2 + 5;
                    xkor2.Text = Convert.ToString(KURE.x2);
                }

                // CİZDİRME KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                KURE.sagackureciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktakure(NOKTA.x1, NOKTA.y1, KURE.y2, KURE.x2, KURE.cap2, NOKTA.z1, KURE.z2);
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                //  g) Nokta, dikdörtgen prizma çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 + 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 + 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                PRİZMA.sagaprizmaciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktaprizma(NOKTA.x1, NOKTA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                //     h) Nokta, Silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.x1 = NOKTA.x1 + 5;
                    Xkor1.Text = Convert.ToString(NOKTA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 + 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                SİLİNDİR.sagasilindirciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktasilindir(NOKTA.x1, NOKTA.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, NOKTA.z1, SİLİNDİR.z2);


            }

            else if (comboBox1.SelectedIndex == 8)
            {
                //    i) Silindir, silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    SİLİNDİR.x1 = SİLİNDİR.x1 + 5;
                    Xkor1.Text = Convert.ToString(SİLİNDİR.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 + 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }


                // cizdirme kısmı
                SİLİNDİR.solasilindirciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.silindirsilindir(SİLİNDİR.x1, SİLİNDİR.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, SİLİNDİR.z1, SİLİNDİR.z2, SİLİNDİR.yukseklik1, SİLİNDİR.cap1);

            }

            else if (comboBox1.SelectedIndex == 9)
            {
                //    j) Küre, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.x1 = KURE.x1 + 5;
                    Xkor1.Text = Convert.ToString(KURE.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.x2 = KURE.x2 + 5;
                    xkor2.Text = Convert.ToString(KURE.x2);
                }

                KURE.solackureciz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.kurekure(KURE.x1, KURE.y1, KURE.y2, KURE.x2, KURE.cap2, KURE.z1, KURE.z2, KURE.cap1);
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                //     k) Küre silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.x1 = KURE.x1 + 5;
                    Xkor1.Text = Convert.ToString(KURE.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 + 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }

                KURE.solackureciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                //  carpısma denetim
                denetimcapıs.kuresilindir(KURE.x1, KURE.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, KURE.z1, SİLİNDİR.z2, KURE.cap1, SİLİNDİR.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 11)
            {
                //  l) Yüzey, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.x1 = yuzey.x1 + 5;
                    Xkor1.Text = Convert.ToString(yuzey.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.x2 = KURE.x2 + 5;
                    xkor2.Text = Convert.ToString(KURE.x2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeykure(yuzey.x1, yuzey.y1, KURE.y2, KURE.x2, KURE.cap2, yuzey.genişlik1, yuzey.derinlik1);

            }

            else if (comboBox1.SelectedIndex == 12)
            {
                // m) Yüzey, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.x1 = yuzey.x1 + 5;
                    Xkor1.Text = Convert.ToString(yuzey.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 + 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }

                yuzey.solyuzeyçiz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeyprizma(yuzey.x1, yuzey.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, yuzey.genişlik1, yuzey.derinlik1, PRİZMA.yukseklik2);
            }

            else if (comboBox1.SelectedIndex == 13)
            {
                //  n) Yüzey silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.x1 = yuzey.x1 + 5;
                    Xkor1.Text = Convert.ToString(yuzey.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.x2 = SİLİNDİR.x2 + 5;
                    xkor2.Text = Convert.ToString(SİLİNDİR.x2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeysilindir(yuzey.x1, yuzey.y1, SİLİNDİR.y2, SİLİNDİR.x2, yuzey.genişlik1, yuzey.derinlik1, SİLİNDİR.yukseklik2, SİLİNDİR.cap2);

            }

            else if (comboBox1.SelectedIndex == 14)
            {
                //     o) Küre, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.x1 = KURE.x1 + 5;
                    Xkor1.Text = Convert.ToString(KURE.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 + 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }


                KURE.solackureciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.kureprizma(KURE.x1, KURE.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, KURE.cap1, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 15)
            {
                //    p) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi*/
                if (cisim1radiobtn.Checked == true)
                {
                    PRİZMA.x1 = PRİZMA.x1 + 5;
                    Xkor1.Text = Convert.ToString(PRİZMA.x1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.x2 = PRİZMA.x2 + 5;
                    xkor2.Text = Convert.ToString(PRİZMA.x2);
                }


                PRİZMA.solaprizmaciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.prizmaprizma(PRİZMA.x1, PRİZMA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.genişlik1, PRİZMA.derinlik1, PRİZMA.yukseklik2, PRİZMA.derinlik2, PRİZMA.derinlik1);
            }
        }

        private void asagıbutton_Click(object sender, EventArgs e)
        {
            // PİCTRURE BOX IN TEMZİLENMESİ İÇİN 
            pictureBox1.Refresh();

            if (comboBox1.SelectedIndex == 0)
            {


                //    a) Nokta, dİKDÖRTGEN  çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 + 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y2 = DİKDÖRTGEN.y2 + 5;
                    ykor2.Text = Convert.ToString(DİKDÖRTGEN.y2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktadikdörtgendenetim(NOKTA.x1, NOKTA.y1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                // b) Nokta, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 + 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.y2 = cember.y2 + 5;
                    ykor2.Text = Convert.ToString(cember.y2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                cember.sagacemberciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktaçemberdenetim(NOKTA.x1, NOKTA.y1, cember.x2, cember.y2, cember.cap2);

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                // c) Dikdörtgen, dikdörtgen çarpışma denetimi


                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y1 = DİKDÖRTGEN.y1 + 5;
                    ykor1.Text = Convert.ToString(DİKDÖRTGEN.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y2 = DİKDÖRTGEN.y2 + 5;
                    ykor2.Text = Convert.ToString(DİKDÖRTGEN.y2);
                }


                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);


                denetimcapıs.DİKDÖRTGENdikrdötgencarpısma(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 3)
            {

                //   d) Dikdörtgen, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y1 = DİKDÖRTGEN.y1 + 5;
                    ykor1.Text = Convert.ToString(DİKDÖRTGEN.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.y2 = cember.y2 + 5;
                    ykor2.Text = Convert.ToString(cember.y2);
                }

                // cizdirme kısmı 
                cember.sagacemberciz(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.dikdörtgencember(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, cember.y2, cember.x2, cember.cap2);
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                // e) Çember, çember çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    cember.y1 = cember.y1 + 5;
                    ykor1.Text = Convert.ToString(cember.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.y2 = cember.y2 + 5;
                    ykor2.Text = Convert.ToString(cember.y2);
                }

                // cizdirme  kısmı 
                cember.solacemberciz(pictureBox1);
                cember.sagacemberciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.cembercember(cember.x1, cember.y1, cember.cap1, cember.cap2, cember.y2, cember.x2);

            }

            else if (comboBox1.SelectedIndex == 5)
            {
                // f) Nokta, Küre çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 + 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.y2 = KURE.y2 + 5;
                    ykor2.Text = Convert.ToString(KURE.y2);
                }

                // CİZDİRME KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                KURE.sagackureciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktakure(NOKTA.x1, NOKTA.y1, KURE.y2, KURE.x2, KURE.cap2, NOKTA.z1, KURE.z2);
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                //  g) Nokta, dikdörtgen prizma çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 + 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 + 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                PRİZMA.sagaprizmaciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktaprizma(NOKTA.x1, NOKTA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                //     h) Nokta, Silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 + 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 + 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                SİLİNDİR.sagasilindirciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktasilindir(NOKTA.x1, NOKTA.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, NOKTA.z1, SİLİNDİR.z2);


            }

            else if (comboBox1.SelectedIndex == 8)
            {
                //    i) Silindir, silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    SİLİNDİR.y1 = SİLİNDİR.y1 + 5;
                    ykor1.Text = Convert.ToString(SİLİNDİR.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 + 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }


                // cizdirme kısmı
                SİLİNDİR.solasilindirciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.silindirsilindir(SİLİNDİR.x1, SİLİNDİR.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, SİLİNDİR.z1, SİLİNDİR.z2, SİLİNDİR.yukseklik1, SİLİNDİR.cap1);

            }

            else if (comboBox1.SelectedIndex == 9)
            {
                //    j) Küre, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.y1 = KURE.y1 + 5;
                    ykor1.Text = Convert.ToString(KURE.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.y2 = KURE.y2 + 5;
                    ykor2.Text = Convert.ToString(KURE.y2);
                }

                KURE.solackureciz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.kurekure(KURE.x1, KURE.y1, KURE.y2, KURE.x2, KURE.cap2, KURE.z1, KURE.z2, KURE.cap1);
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                //     k) Küre silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.y1 = KURE.y1 + 5;
                    ykor1.Text = Convert.ToString(KURE.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 + 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }

                KURE.solackureciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                //  carpısma denetim
                denetimcapıs.kuresilindir(KURE.x1, KURE.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, KURE.z1, SİLİNDİR.z2, KURE.cap1, SİLİNDİR.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 11)
            {
                //  l) Yüzey, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.y1 = yuzey.y1 + 5;
                    ykor1.Text = Convert.ToString(yuzey.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.y2 = KURE.y2 + 5;
                    ykor2.Text = Convert.ToString(KURE.y2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeykure(yuzey.x1, yuzey.y1, KURE.y2, KURE.x2, KURE.cap2, yuzey.genişlik1, yuzey.derinlik1);

            }

            else if (comboBox1.SelectedIndex == 12)
            {
                // m) Yüzey, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.y1 = yuzey.y1 + 5;
                    ykor1.Text = Convert.ToString(yuzey.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 + 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }

                yuzey.solyuzeyçiz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeyprizma(yuzey.x1, yuzey.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, yuzey.genişlik1, yuzey.derinlik1, PRİZMA.yukseklik2);
            }

            else if (comboBox1.SelectedIndex == 13)
            {
                //  n) Yüzey silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.y1 = yuzey.y1 + 5;
                    ykor1.Text = Convert.ToString(yuzey.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 + 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeysilindir(yuzey.x1, yuzey.y1, SİLİNDİR.y2, SİLİNDİR.x2, yuzey.genişlik1, yuzey.derinlik1, SİLİNDİR.yukseklik2, SİLİNDİR.cap2);

            }

            else if (comboBox1.SelectedIndex == 14)
            {
                //     o) Küre, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.y1 = KURE.y1 + 5;
                    ykor1.Text = Convert.ToString(KURE.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 + 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }


                KURE.solackureciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.kureprizma(KURE.x1, KURE.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, KURE.cap1, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 15)
            {
                //    p) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi*/
                if (cisim1radiobtn.Checked == true)
                {
                    PRİZMA.y1 = PRİZMA.y1 + 5;
                    ykor1.Text = Convert.ToString(PRİZMA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 + 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }


                PRİZMA.solaprizmaciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.prizmaprizma(PRİZMA.x1, PRİZMA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.genişlik1, PRİZMA.derinlik1, PRİZMA.yukseklik2, PRİZMA.derinlik2, PRİZMA.derinlik1);
            }
        }

        private void yukarıbutton_Click(object sender, EventArgs e)
        {
            // PİCTRURE BOX IN TEMZİLENMESİ İÇİN 
            pictureBox1.Refresh();

            if (comboBox1.SelectedIndex == 0)
            {


                //    a) Nokta, dİKDÖRTGEN  çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 - 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y2 = DİKDÖRTGEN.y2 - 5;
                    ykor2.Text = Convert.ToString(DİKDÖRTGEN.y2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktadikdörtgendenetim(NOKTA.x1, NOKTA.y1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                // b) Nokta, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 - 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.y2 = cember.y2 - 5;
                    ykor2.Text = Convert.ToString(cember.y2);
                }

                // Çizdirme kısmı  nokta gözüksün diye sonra çizdiriyorum 
                cember.sagacemberciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktaçemberdenetim(NOKTA.x1, NOKTA.y1, cember.x2, cember.y2, cember.cap2);

            }

            else if (comboBox1.SelectedIndex == 2)
            {
                // c) Dikdörtgen, dikdörtgen çarpışma denetimi


                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y1 = DİKDÖRTGEN.y1 - 5;
                    ykor1.Text = Convert.ToString(DİKDÖRTGEN.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y2 = DİKDÖRTGEN.y2 - 5;
                    ykor2.Text = Convert.ToString(DİKDÖRTGEN.y2);
                }


                DİKDÖRTGEN.sagdadikdörtgencizim(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);


                denetimcapıs.DİKDÖRTGENdikrdötgencarpısma(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, DİKDÖRTGEN.y2, DİKDÖRTGEN.x2, DİKDÖRTGEN.genişlik2, DİKDÖRTGEN.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 3)
            {

                //   d) Dikdörtgen, çember çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    DİKDÖRTGEN.y1 = DİKDÖRTGEN.y1 - 5;
                    ykor1.Text = Convert.ToString(DİKDÖRTGEN.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.y2 = cember.y2 - 5;
                    ykor2.Text = Convert.ToString(cember.y2);
                }

                // cizdirme kısmı 
                cember.sagacemberciz(pictureBox1);
                DİKDÖRTGEN.soldadikdörtgencizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.dikdörtgencember(DİKDÖRTGEN.x1, DİKDÖRTGEN.y1, DİKDÖRTGEN.genişlik1, DİKDÖRTGEN.yukseklik1, cember.y2, cember.x2, cember.cap2);
            }

            else if (comboBox1.SelectedIndex == 4)
            {
                // e) Çember, çember çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    cember.y1 = cember.y1 - 5;
                    ykor1.Text = Convert.ToString(cember.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    cember.y2 = cember.y2 - 5;
                    ykor2.Text = Convert.ToString(cember.y2);
                }

                // cizdirme  kısmı 
                cember.solacemberciz(pictureBox1);
                cember.sagacemberciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.cembercember(cember.x1, cember.y1, cember.cap1, cember.cap2, cember.y2, cember.x2);

            }

            else if (comboBox1.SelectedIndex == 5)
            {
                // f) Nokta, Küre çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 - 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.y2 = KURE.y2 - 5;
                    ykor2.Text = Convert.ToString(KURE.y2);
                }

                // CİZDİRME KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                KURE.sagackureciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktakure(NOKTA.x1, NOKTA.y1, KURE.y2, KURE.x2, KURE.cap2, NOKTA.z1, KURE.z2);
            }

            else if (comboBox1.SelectedIndex == 6)
            {
                //  g) Nokta, dikdörtgen prizma çarpışma denetimi

                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 - 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 - 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                PRİZMA.sagaprizmaciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.noktaprizma(NOKTA.x1, NOKTA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 7)
            {
                //     h) Nokta, Silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    NOKTA.y1 = NOKTA.y1 - 5;
                    ykor1.Text = Convert.ToString(NOKTA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 - 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }

                // CİZİM KISMI  NOKTA GÖZÜKSÜN DİYE SONRADAN ÇİZDİRDİM 
                SİLİNDİR.sagasilindirciz(pictureBox1);
                NOKTA.noktacizim(pictureBox1);

                // denetim kısmı 
                denetimcapıs.noktasilindir(NOKTA.x1, NOKTA.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, NOKTA.z1, SİLİNDİR.z2);


            }

            else if (comboBox1.SelectedIndex == 8)
            {
                //    i) Silindir, silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    SİLİNDİR.y1 = SİLİNDİR.y1 - 5;
                    ykor1.Text = Convert.ToString(SİLİNDİR.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 - 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }


                // cizdirme kısmı
                SİLİNDİR.solasilindirciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.silindirsilindir(SİLİNDİR.x1, SİLİNDİR.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, SİLİNDİR.yukseklik2, SİLİNDİR.z1, SİLİNDİR.z2, SİLİNDİR.yukseklik1, SİLİNDİR.cap1);

            }

            else if (comboBox1.SelectedIndex == 9)
            {
                //    j) Küre, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.y1 = KURE.y1 - 5;
                    ykor1.Text = Convert.ToString(KURE.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.y2 = KURE.y2 - 5;
                    ykor2.Text = Convert.ToString(KURE.y2);
                }

                KURE.solackureciz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // DENETİM KISMI 
                denetimcapıs.kurekure(KURE.x1, KURE.y1, KURE.y2, KURE.x2, KURE.cap2, KURE.z1, KURE.z2, KURE.cap1);
            }

            else if (comboBox1.SelectedIndex == 10)
            {
                //     k) Küre silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.y1 = KURE.y1 - 5;
                    ykor1.Text = Convert.ToString(KURE.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 - 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }

                KURE.solackureciz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                //  carpısma denetim
                denetimcapıs.kuresilindir(KURE.x1, KURE.y1, SİLİNDİR.y2, SİLİNDİR.x2, SİLİNDİR.cap2, KURE.z1, SİLİNDİR.z2, KURE.cap1, SİLİNDİR.yukseklik2);

            }

            else if (comboBox1.SelectedIndex == 11)
            {
                //  l) Yüzey, küre çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.y1 = yuzey.y1 - 5;
                    ykor1.Text = Convert.ToString(yuzey.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    KURE.y2 = KURE.y2 - 5;
                    ykor2.Text = Convert.ToString(KURE.y2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                KURE.sagackureciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeykure(yuzey.x1, yuzey.y1, KURE.y2, KURE.x2, KURE.cap2, yuzey.genişlik1, yuzey.derinlik1);

            }

            else if (comboBox1.SelectedIndex == 12)
            {
                // m) Yüzey, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.y1 = yuzey.y1 - 5;
                    ykor1.Text = Convert.ToString(yuzey.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 - 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }

                yuzey.solyuzeyçiz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeyprizma(yuzey.x1, yuzey.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, yuzey.genişlik1, yuzey.derinlik1, PRİZMA.yukseklik2);
            }

            else if (comboBox1.SelectedIndex == 13)
            {
                //  n) Yüzey silindir çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    yuzey.y1 = yuzey.y1 - 5;
                    ykor1.Text = Convert.ToString(yuzey.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    SİLİNDİR.y2 = SİLİNDİR.y2 - 5;
                    ykor2.Text = Convert.ToString(SİLİNDİR.y2);
                }


                yuzey.solyuzeyçiz(pictureBox1);
                SİLİNDİR.sagasilindirciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.yuzeysilindir(yuzey.x1, yuzey.y1, SİLİNDİR.y2, SİLİNDİR.x2, yuzey.genişlik1, yuzey.derinlik1, SİLİNDİR.yukseklik2, SİLİNDİR.cap2);

            }

            else if (comboBox1.SelectedIndex == 14)
            {
                //     o) Küre, dikdörtgen prizma çarpışma denetimi
                if (cisim1radiobtn.Checked == true)
                {
                    KURE.y1 = KURE.y1 - 5;
                    ykor1.Text = Convert.ToString(KURE.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 - 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }


                KURE.solackureciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.kureprizma(KURE.x1, KURE.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.yukseklik2, KURE.cap1, PRİZMA.derinlik2);
            }

            else if (comboBox1.SelectedIndex == 15)
            {
                //    p) Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi*/
                if (cisim1radiobtn.Checked == true)
                {
                    PRİZMA.y1 = PRİZMA.y1 - 5;
                    ykor1.Text = Convert.ToString(PRİZMA.y1);

                }

                else if (cisim2radiobtn.Checked == true)
                {
                    PRİZMA.y2 = PRİZMA.y2 - 5;
                    ykor2.Text = Convert.ToString(PRİZMA.y2);
                }


                PRİZMA.solaprizmaciz(pictureBox1);
                PRİZMA.sagaprizmaciz(pictureBox1);

                // denetim kısmı 
                denetimcapıs.prizmaprizma(PRİZMA.x1, PRİZMA.y1, PRİZMA.y2, PRİZMA.x2, PRİZMA.genişlik2, PRİZMA.genişlik1, PRİZMA.derinlik1, PRİZMA.yukseklik2, PRİZMA.derinlik2, PRİZMA.derinlik1);
            }
        }
    }

}
