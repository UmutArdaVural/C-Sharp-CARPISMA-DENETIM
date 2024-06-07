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
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çarpışma_denetimi_başlangıç
{
    // denetim kısmı 
    public static class denetimcapıs
    {
        // 1. cisim için olanlar 
        public static int x1;
        public static int y1;
        public static int z1;
        public static int genişlik1;
        public static int yukseklik1;
        public static int derinlik1;
        public static int cap1;

        // 2. cisim için olanlar 

        public static int x2;
        public static int y2;
        public static int z2;
        public static int genişlik2;
        public static int yukseklik2;
        public static int derinlik2;
        public static int cap2;

        public static bool olasılık1;
        public static bool olasılık2;
        public static bool olasılık3;
        public static bool olasılık4;

        public static void noktadikdörtgendenetim(int X1, int Y1, int Y2, int X2, int Genişlik2, int Yukseklik2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; genişlik2 = Genişlik2; yukseklik2 = Yukseklik2;

            int dikdörtgenmerkez_x = x2 + genişlik2 / 2;  
            int dikdörtgenmerkez_y = y2 + yukseklik2 / 2;
            int xuzaklık = Math.Abs(dikdörtgenmerkez_x - x1);
            int yuzaklık = Math.Abs(dikdörtgenmerkez_y - y1);

            olasılık1 = xuzaklık <= genişlik2 / 2;
            olasılık2 = yuzaklık <= yukseklik2 / 2;

            if (olasılık1 && olasılık2)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void noktaçemberdenetim(int X1, int Y1, int Y2, int X2, int Cap2)
        {           
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; cap2 = Cap2;

            olasılık1 = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) == Math.Pow(cap2, 2);

            if (olasılık1==true)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        public static void DİKDÖRTGENdikrdötgencarpısma(int X1, int Y1, int genisliik1, int yuksekliik1, int Y2, int X2, int Genişlik2, int Yukseklik2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; genişlik2 = Genişlik2; yukseklik2 = Yukseklik2; genişlik1 = genisliik1; yukseklik1 = yuksekliik1;



            // birinci durum 
            olasılık1 = x1 <= genişlik2 + x2 && x1 + genişlik1 >= x2 && y1 <= yukseklik2 + y2 && y1 + yukseklik1 >= y2;

            olasılık2 = x2 <= genişlik1 + x1 && x2 + genişlik2 >= x1 && y2 <= yukseklik1 + y1 && y2 + yukseklik2 >= y1;


            if (olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (olasılık2)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        public static void dikdörtgencember(int X1, int Y1, int genisliik1, int yuksekliik1, int Y2, int X2, int Cap2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; genişlik1 = genisliik1; yukseklik1 = yuksekliik1; cap2 = Cap2;

            olasılık1 = x2 + cap2 >= x1 && x2 - cap2 <= x1 + genisliik1;

            olasılık2 = y2 + cap2 >= y1 && y2 - cap2 <= y1 + yuksekliik1;

            if (olasılık1 && olasılık2)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public static void cembercember(int X1, int Y1, int Cap1, int Cap2, int Y2, int X2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; ; cap1 = Cap1; cap2 = Cap2;

            double merkezleruzaklık = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            int caplartoplamı = cap1 + cap2;

            olasılık1 = merkezleruzaklık <= caplartoplamı;

            if (merkezleruzaklık <= caplartoplamı)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public static void noktakure(int X1, int Y1, int Y2, int X2, int Cap2, int Z1, int Z2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            // *************** unutma küreye burda z1 konulcak 3 boyuttan ötürü *******
            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; ; z1 = Z1; z2 = Z2; cap2 = Cap2;


            double uzaklık = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(z1 - z2, 2) + Math.Pow(y1 - y2, 2));
            olasılık1 = uzaklık <= cap2;

            if (olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }


        public static void noktaprizma(int X1, int Y1, int Y2, int X2, int Genişlik2, int Yukseklik2, int Derinlik2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; genişlik2 = Genişlik2; derinlik2 = Derinlik2; yukseklik2 = Yukseklik2;

            olasılık1 = x1 >= x2 && x1 <= x2 + derinlik2 + yukseklik2;

            olasılık2 = y1 >= y2 && y1 <= y2 + yukseklik2 + derinlik2;

            if (olasılık1 && olasılık2)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public static void noktasilindir(int X1, int Y1, int Y2, int X2, int Cap2, int Yukseklik2,int Z1,int Z2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; yukseklik2 = Yukseklik2; cap2 = Cap2; z1 = Z1; z2 = Z2;

            int xuzaklık = Math.Abs(x1 - x2);
            int yuzaklık = Math.Abs(y1 - y2);
            int zuzaklık = Math.Abs(z1 - z2);

            olasılık1 = xuzaklık <= cap2;
            olasılık2 = yuzaklık <= yukseklik2;
            olasılık3 = zuzaklık <= cap2;

            if (olasılık3 && olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static void silindirsilindir(int X1, int Y1, int Y2, int X2, int Cap2, int Yukseklik2, int Z1, int Z2, int yuksekliik1 , int Cap1)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; yukseklik2 = Yukseklik2; cap2 = Cap2; z1 = Z1; z2 = Z2; yukseklik1=yuksekliik1;  cap1=Cap1;

         
            double zxmerkezuzaklık = Math.Sqrt( Math.Pow(x1-x2,2) + Math.Pow(z1-z2 ,2) );

            double ymerkezuzaklık = Math.Abs(y1 - y2);

            olasılık1 = zxmerkezuzaklık <= cap1 + cap2  ;
            olasılık2 = ymerkezuzaklık <= yukseklik1/2 +yukseklik2/2 ;
            
            if (olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static  void kurekure(int X1, int Y1, int Y2, int X2, int Cap2, int Z1, int Z2,int Cap1)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; ; z1 = Z1; z2 = Z2; cap2 = Cap2; cap1=Cap1;

            double uzaklık = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2)  );

            olasılık1= uzaklık <= Cap1 + cap2 ;

            if ( olasılık1==true)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        public static void kuresilindir(int X1, int Y1, int Y2, int X2, int Cap2, int Z1, int Z2, int Cap1, int Yukseklik2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; ; z1 = Z1; z2 = Z2; cap2 = Cap2; cap1 = Cap1; yukseklik2 = Yukseklik2;

            double zxmerkezuzaklık = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(z1 - z2, 2));

            double ymerkezuzaklık = Math.Abs(y1 - y2);

            olasılık1 = zxmerkezuzaklık <= cap1 + cap2;

            olasılık2 = ymerkezuzaklık <= yukseklik2 / 2 + cap1;

            if (olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public static void yuzeykure(int X1, int Y1, int Y2, int X2, int Cap2, int Genişlik1 ,  int Derinlik1)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


            x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; ;  cap2 = Cap2; yukseklik1 = 1; genişlik1= Genişlik1 ;     derinlik1 = Derinlik1;



            olasılık1 = x1 - cap2 <=x2 && x1+ genişlik1 + derinlik1 + cap2 >=x2;
            olasılık2 = y1 - cap2 - derinlik1 <=y2 && y1 + cap2 >= y2 ;

            if (olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public static void yuzeysilindir(int X1, int Y1, int Y2, int X2,  int Genişlik1, int Derinlik1, int yukseklik22, int Cap2)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 


            yukseklik2 = yukseklik22; x1 = X1; y1 = Y1; y2 = Y2; x2 = X2;  yukseklik1 = 1; genişlik1 = Genişlik1; derinlik1 = Derinlik1;  cap2 = Cap2;

            olasılık1 = x1 -cap2 <= x2 && x1 + genişlik1 + derinlik1 + cap2 >=x2;
            olasılık2 = y1 - yukseklik2/2 - derinlik1 <= y2 && y1+ yukseklik2/2 >= y2 ;

            if (olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        public static void yuzeyprizma(int X1, int Y1, int Y2, int X2, int Genişlik2, int Genişlik1, int Derinlik1, int yukseklik22 )
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            yukseklik2 = yukseklik22;    x1 = X1; y1 = Y1; y2 = Y2; x2 = X2;  genişlik2 = Genişlik2 ;  yukseklik1 = 1; genişlik1 = Genişlik1; derinlik1 = Derinlik1;

            olasılık1 =  x1 - genişlik2 <=x2 && x1+genişlik1+derinlik1 >= x2  ;
            olasılık2 =   y2 + yukseklik2 >=y1 -derinlik1 && y2 <=y1;


            if (olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static void kureprizma(int X1, int Y1, int Y2, int X2, int Genişlik2,  int yukseklik22, int cap11,int Derinlik22)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            yukseklik2 = yukseklik22; x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; genişlik2 = Genişlik2;    cap1=cap11 ; derinlik2=Derinlik22 ;

            olasılık1 = x2 - cap1 <=x1 && x2 +derinlik2+ genişlik2 >= x1 ;
            olasılık2 = y1 +cap1 >= y2  && y1 -cap1 <= y2 +yukseklik2 + derinlik2;

            if (olasılık2 && olasılık1)
            {
                MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
            else
            {
                MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public static void prizmaprizma(int X1, int Y1, int Y2, int X2, int Genişlik2, int Genişlik1, int Derinlik1, int yukseklik22,int Derinlik22,int derinlik11)
        {
            // denendi hata yok yorum satırını kendim için yazıyorum test yaparken 

            yukseklik2 = yukseklik22; x1 = X1; y1 = Y1; y2 = Y2; x2 = X2; genişlik2 = Genişlik2; genişlik1 = Genişlik1;  derinlik2 = Derinlik22; int derinlik1 = derinlik11;

            


             olasılık1 = x1 <= x2 + genişlik2 && x1 + genişlik1 >= x2 && y1 <= y2 + yukseklik2 && y1 + yukseklik1 >= y2 && x1 + derinlik1 <= x2 + genişlik2 + derinlik2 && x1 + derinlik1 + genişlik1 >= x2 + derinlik2 && y1 + derinlik1 <= y2 + derinlik2 + yukseklik2 && y1 + derinlik1 + yukseklik1 >= y2 + derinlik2;
              
            olasılık2 = x2 <= x1 + genişlik1 && x2 + genişlik2 >= x1 && y2 <= y1 + yukseklik1 && y2 + yukseklik2 >= y1&& x2 + derinlik2 <= x1 + genişlik1 + derinlik1 && x2 + derinlik2 + genişlik2 >= x1 + derinlik1 && y2 + derinlik2 <= y1 + derinlik1 + yukseklik1 && y2 + derinlik2 + yukseklik2 >= y1 + derinlik1;

               if (olasılık2 || olasılık1)
               {
                   MessageBox.Show("Çarpışma Gerçekleşir ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               else
               {
                   MessageBox.Show("Çarpışma Gerçekleşmez ", " BİLGİLENDİRME ", MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
        }


    }





    // Çizdirme kısmı 

    public class NESNELER<NESNE>
    {
        // 1. cisim için olanlar 
        public int x1;
        public int y1;
        public int z1;
        public int genişlik1;
        public int yukseklik1;
        public int derinlik1;
        public int cap1;

        // 2. cisim için olanlar 

        public int x2;
        public int y2;
        public int z2;
        public int genişlik2;
        public int yukseklik2;
        public int derinlik2;
        public int cap2;

    }

    class NOKTA <NESNE> : NESNELER<NESNE>
    {
        public void noktacizim(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();
            Pen kalem =new Pen( Color.DarkRed);
            graf.DrawEllipse(kalem, x1, y1, 1, 1);
        }

    }
    class DİKDÖRTGEN <NESNE> : NESNELER<NESNE>
    {
        public void soldadikdörtgencizim(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            SolidBrush kalem2 = new SolidBrush(Color.FromArgb(128, Color.Red));
            Pen kalem = new Pen(Color.WhiteSmoke);

            graf.FillRectangle(kalem2, x1, y1, genişlik1, yukseklik1);
            
        }
        public  void sagdadikdörtgencizim(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            SolidBrush kalem2 = new SolidBrush(Color.FromArgb(128, Color.Cyan));

            Pen kalem = new Pen(Color.AliceBlue);

            graf.FillRectangle(kalem2, x2, y2, genişlik2, yukseklik2);
        }
    }
    class CEMBER<NESNE> : NESNELER<NESNE>
    {
        public void solacemberciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Black));

            // burda r1 çıkarmamın sebebi merkezin orta noktasının x1 ve y1 olması 

            graf.DrawEllipse(kalem, x1-cap1 ,y1-cap1,2*cap1,2*cap1); // dikkat et 
           
        }
        public void sagacemberciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.FromArgb(128, Color.Black));

            // burda r1 çıkarmamın sebebi merkezin orta noktasının x1 ve y1 olması 

             graf.DrawEllipse(kalem, x2-cap2 , y2-cap2 , 2*cap2, 2*cap2); // dikkat et 
        }
    }
    class KURE<NESNE> : NESNELER<NESNE>
    {
        public void solackureciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.Red);
            SolidBrush kalem2 = new SolidBrush(Color.FromArgb(128,Color.Blue));
            // burda r1 çıkarmamın sebebi merkezin orta noktasının x1 ve y1 olması 

            graf.FillEllipse(kalem2, x1 - cap1, y1 - cap1, 2 * cap1, 2 * cap1);
            graf.DrawEllipse(kalem, x1 - cap1, y1 - cap1/3, 2 * cap1, cap1/2);  
        }
        public void sagackureciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            Pen kalem = new Pen(Color.Red);
            SolidBrush kalem2 = new SolidBrush(Color.FromArgb(128, Color.Gray));
            // burda r1 çıkarmamın sebebi merkezin orta noktasının x1 ve y1 olması 

            graf.FillEllipse(kalem2, x2 - cap2, y2 - cap2, 2 * cap2, 2 * cap2);
            // içerdeki daire için 
            graf.DrawEllipse(kalem, x2 - cap2, y2 - cap2/3, 2 * cap2,   cap2/2);
        }

    }
    class PRİZMA <NESNE> : NESNELER<NESNE>
    {
        public void solaprizmaciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            // SolidBrush kalem2 = new SolidBrush();
            Pen kalem = new Pen(Color.FromArgb(128,Color.Red));

            // ön ve arka dikdörtgenler 
            // ön ve arka dikdörtgenler 
            graf.DrawRectangle(kalem, x1, y1, genişlik1, yukseklik1);
            graf.DrawRectangle(kalem, x1 + derinlik1, y1 + derinlik1, genişlik1, yukseklik1);
            // çizgiler 
            graf.DrawLine(kalem, x1, y1, x1 + derinlik1, y1 + derinlik1);
            graf.DrawLine(kalem, x1 + genişlik1, y1, x1 + derinlik1 + genişlik1, y1 + derinlik1);
            graf.DrawLine(kalem, x1, y1 + yukseklik1, x1 + derinlik1, y1 + yukseklik1 + derinlik1);
            graf.DrawLine(kalem, x1 + genişlik1, y1 + yukseklik1, x1 + genişlik1 + derinlik1, y1 + yukseklik1 + derinlik1);
        }
        public void sagaprizmaciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            // SolidBrush kalem2 = new SolidBrush();
            Pen kalem = new Pen(Color.FromArgb(128, Color.Red));

            // ön ve arka dikdörtgenler 
            graf.DrawRectangle(kalem, x2, y2, genişlik2, yukseklik2);
            graf.DrawRectangle(kalem, x2 + derinlik2, y2 + derinlik2, genişlik2, yukseklik2);
            // çizgiler 
            graf.DrawLine(kalem, x2, y2, x2 + derinlik2, y2 + derinlik2);
            graf.DrawLine(kalem, x2 + genişlik2, y2, x2 + derinlik2 + genişlik2, y2 + derinlik2);
            graf.DrawLine(kalem, x2, y2 + yukseklik2, x2 + derinlik2, y2 + yukseklik2 + derinlik2);
            graf.DrawLine(kalem, x2 + genişlik2, y2 + yukseklik2, x2 + genişlik2 + derinlik2, y2 + yukseklik2 + derinlik2);
        }
    }
    class SİLİNDİR <NESNE> : NESNELER<NESNE>
    {
        public void solasilindirciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();

            Pen kalemm = new Pen(Color.FromArgb(128, Color.Black));

            // ALT DAİRE 
            graf.DrawEllipse(kalemm, x1-cap1, y1+yukseklik1/2 ,cap1*2 , cap1/2);
            // ÜST DAİRE 
            graf.DrawEllipse(kalemm, x1 - cap1, y1 - yukseklik1 / 2, cap1 * 2, cap1 / 2);
            //SOL ÇİZGİ 
            graf.DrawLine(kalemm, x1 - cap1,y1-yukseklik1/2 +cap1/4,x1-cap1,y1+yukseklik1/2 + cap1/4);
            //SOL ÇİZGİ 
            graf.DrawLine(kalemm, x1 + cap1, y1 - yukseklik1 / 2 + cap1 / 4, x1 + cap1, y1 + yukseklik1 / 2 + cap1 / 4);

        }

        public void sagasilindirciz(PictureBox pictureBox)
        {
            Graphics graf = pictureBox.CreateGraphics();
            Pen kalemm = new Pen(Color.FromArgb(128, Color.Black));
            // ALT DAİRE 
            graf.DrawEllipse(kalemm, x2 - cap2, y2 + yukseklik2 / 2, cap2 * 2, cap2 / 2);
            // ÜST DAİRE 
            graf.DrawEllipse(kalemm, x2 - cap2, y2 - yukseklik2 / 2, cap2 * 2, cap2 / 2);
            //SOL ÇİZGİ 
            graf.DrawLine(kalemm, x2 - cap2, y2 - yukseklik2 / 2 + cap2 / 4, x2 - cap2, y2 + yukseklik2 / 2 + cap2 / 4);
            //SOL ÇİZGİ 
            graf.DrawLine(kalemm, x2 + cap2, y2 - yukseklik2 / 2 + cap2 / 4, x2 + cap2, y2 + yukseklik2 / 2 + cap2 / 4);



        }
    }

    class YUZEY <NESNE>:NESNELER<NESNE>
    {   public void solyuzeyçiz(PictureBox pictureBox)
        {
            yukseklik1 = 1;

            Graphics graf = pictureBox.CreateGraphics();

            Pen kalemm = new Pen(Color.Aqua);   

            graf.DrawRectangle(kalemm,x1,y1,genişlik1,yukseklik1);      
            graf.DrawLine(kalemm, x1, y1, derinlik1+x1, y1-derinlik1);
            graf.DrawLine(kalemm, x1 + genişlik1, y1, genişlik1 + x1 + derinlik1, y1 - derinlik1);
            graf.DrawLine(kalemm, x1 + derinlik1, y1- derinlik1, genişlik1 + x1+derinlik1, y1 - derinlik1);

             
             // yüzeyin çizgileri belli olması için 
            graf.DrawLine(kalemm, x1+ genişlik1/3 , y1, x1+ derinlik1 + genişlik1/3, y1 - derinlik1);
            graf.DrawLine(kalemm, x1 + 2 * genişlik1 / 3, y1, x1 + derinlik1 + 2 * genişlik1 / 3, y1 - derinlik1);
            graf.DrawLine(kalemm, x1 +  derinlik1 / 2, y1-derinlik1/2 , x1  +  genişlik1 + derinlik1 / 2, y1 - derinlik1/2); 







        }



    }
}
