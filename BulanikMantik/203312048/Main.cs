using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YAPAY_ZEKA
{

    public partial class Main : Form


    {
       IsıtmaForm IsıtmaGrafik;
       NemForm NemGrafik;
       SıcaklıkForm sıcaklık;
       Üyelikler ÜyelikFonksiyonları;
     
        private void textBox_ÇÇ_TextChanged(object sender, EventArgs e)
        {

        }

        public void button_Üyelik_Click(object sender, EventArgs e)
        {

     
                ÜyelikFonksiyonları.Show();
              
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tablo tablo1 = new Tablo();
            tablo1.Show();

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public Main()
        {
            InitializeComponent();
             
            Load += new EventHandler(Form1_Load); 
        }
        private void Form1_Load(object sender, System.EventArgs e)

        {
                        
        }

        private void textBox_çoksoğukk_TextChanged(object sender, EventArgs e)
        {

        }

        public void button_Sıcaklık_Click(object sender, EventArgs e)
        {
            
            sıcaklık.Show();

        }

        private void button_Nem_Click(object sender, EventArgs e)
        {
            
            NemGrafik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsıtmaGrafik.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_kural_Click(object sender, EventArgs e)
        {
            Formkural formkural1 = new Formkural();
            formkural1.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        double Sıcaklık, Nem;
        double çokdüşükS, düşükS, ortaS, yüksekS, çokyüksekS;
        double çokdüşük, düşük, ortaN, yüksek, çokyüksek;
        double GirişxDeğerler, toplam, AğırlıklıOrtalama;
        double çokdüşükA, düşükA, ortaA, yüksekA, çokyüksekA;

        public void button_hesapla_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textBox_sicaklik.Text) && String.IsNullOrEmpty(textBox_sicaklik.Text))
            {
                MessageBox.Show("Sıcaklık değeri giriniz");
                return;
            }

            if (String.IsNullOrEmpty(textBox_Nem.Text) && String.IsNullOrEmpty(textBox_Nem.Text))
            {
                MessageBox.Show("Nem değeri giriniz");
                return;
            }
            Sıcaklık = Convert.ToDouble(textBox_sicaklik.Text);
            if (Sıcaklık > 50)
            {
                MessageBox.Show("Yüksek Sıcaklık Değer Girdiniz");

            }
            if (Sıcaklık < -10)
            {
                MessageBox.Show("Düşük Sıcaklık Değer Girdiniz");

            }

            if (Sıcaklık >= -10 && Sıcaklık <= 0)
            {
                çokdüşükS = 1;
            }
      
            else if (Sıcaklık >= 0 && Sıcaklık <= 10)
            {
                çokdüşükS = (10 - Sıcaklık) / (10);
            }
            else if (Sıcaklık > 10)
            {
                çokdüşükS = 0;
            }
            textBox1.Text = çokdüşükS.ToString();


            if (Sıcaklık > 15 || Sıcaklık < 0)
            {
                düşükS = 0;
            }
            else if (Sıcaklık >= 0 && Sıcaklık <= 7.5)
            {
                düşükS = (Sıcaklık - 0) / (7.5);


            }
            else if (Sıcaklık >= 7.5 && Sıcaklık <= 15)
            {
                düşükS = (15 - Sıcaklık) / (7.5);

            }
            textBox2.Text = düşükS.ToString();
            
            if (Sıcaklık > 26 || Sıcaklık < 14)
            {
                ortaS = 0;
            }
            else if (Sıcaklık >= 14 && Sıcaklık <= 20)
            {
                ortaS = (Sıcaklık - 14) / (6);

            }
            else if (Sıcaklık >= 20 && Sıcaklık <= 26)
            {
                ortaS = (26 - Sıcaklık) / (6);

            }
            textBox3.Text = ortaS.ToString();
  
            if (Sıcaklık > 40 || Sıcaklık < 20)
            {
                yüksekS = 0;
            }
            else if (Sıcaklık >= 20 && Sıcaklık <= 30)
            {
                yüksekS = (Sıcaklık - 20) / (10);

            }
            else if (Sıcaklık >= 30 && Sıcaklık <= 40)
            {
                yüksekS = (40 - Sıcaklık) / (10);

            }
            textBox4.Text = yüksekS.ToString();

         
            if (Sıcaklık > 50 || Sıcaklık < 30)
            {
                çokyüksekS = 0;
            }
            else if (Sıcaklık >= 30 && Sıcaklık <= 40)
            {
                çokyüksekS = (Sıcaklık - 30) / (10);

            }
            else if (Sıcaklık >= 40 && Sıcaklık <= 50)
            {
                çokyüksekS = 1;

            }
            textBox5.Text = çokyüksekS.ToString();
       
            Nem = Convert.ToDouble(textBox_Nem.Text);

            if (Nem >= 0 && Nem <= 20)
            {
                çokdüşük = 1;

            }
            else if (Nem >= 20 && Nem <= 40)
            {
                çokdüşük = (40 - Nem) / (20);
            }
            else if (Nem >= 40)
            {
                çokdüşük = 0;
            }
            textBox10.Text = çokdüşük.ToString();

         

            if (Nem < 0 || Nem > 59)
            {
                düşük = 0;

            }
            else if (Nem >= 20 && Nem <= 39.5)
            {
                düşük = (Nem - 20) / (19.5);
            }
            else if (Nem >= 39.5 && Nem <= 59)
            {
                düşük = (59 - Nem) / (19.5);
            }
            textBox9.Text = düşük.ToString();

         
            if (Nem < 50 || Nem > 70)
            {
                ortaN = 0;

            }
            else if (Nem >= 50 && Nem <= 60)
            {
                ortaN = (Nem - 50) / (10);
            }
            else if (Nem >= 60 && Nem <= 70)
            {
                ortaN = (70 - Nem) / (10);
            }
            textBox8.Text = ortaN.ToString();

            

            if (Nem < 60 || Nem > 90)
            {
                yüksek = 0;

            }
            else if (Nem >= 60 && Nem <= 75)
            {
                yüksek = (Nem - 60) / (15);
            }
            else if (Nem >= 75 && Nem <= 90)
            {
                yüksek = (90 - Nem) / (15);
            }
            textBox7.Text = yüksek.ToString();
            
            if (Nem < 80 || Nem > 100)
            {
                çokyüksek = 0;

            }
            else if (Nem >= 80 && Nem <= 90)
            {
                çokyüksek = (Nem - 80) / (10);
            }
            else if (Nem >= 90 && Nem <= 100)
            {
                çokyüksek = 1;
            }
            textBox6.Text = çokyüksek.ToString();



            if (Nem > 100)
            {
                MessageBox.Show("Yüksek Nem Değer Girdiniz");

            }
            if (Nem < 0)
            {
                MessageBox.Show("Düşük Nem Değer Girdiniz");

            }


            ÜyelikFonksiyonları = new Üyelikler(); 

            double çoksoğukçokdüşük = Math.Min(çokdüşükS, çokdüşük);
            ÜyelikFonksiyonları.textBox_Üylelik1.Text = çoksoğukçokdüşük.ToString();

            double çoksoğukdüşük = Math.Min(çokdüşükS, düşük);
            ÜyelikFonksiyonları.textBox_Üylelik2.Text = çoksoğukdüşük.ToString();

            double çoksoğukorta1 = Math.Min(çokdüşükS, ortaN);
            ÜyelikFonksiyonları.textBox_Üylelik3.Text = çoksoğukorta1.ToString();

            double çoksoğukyüksek = Math.Min(çokdüşükS, yüksek);
            ÜyelikFonksiyonları.textBox_Üylelik4.Text = çoksoğukyüksek.ToString();

            double çoksoğukçokyüksek = Math.Min(çokdüşükS, çokyüksek);
            ÜyelikFonksiyonları.textBox_Üylelik5.Text = çoksoğukçokyüksek.ToString();

            double soğukçokdüşük = Math.Min(düşükS, çokdüşük);
            ÜyelikFonksiyonları.textBox_Üylelik6.Text = soğukçokdüşük.ToString();

            double soğukdüşük = Math.Min(düşükS, düşük);
            ÜyelikFonksiyonları.textBox_Üylelik7.Text = soğukdüşük.ToString();

            double soğukorta1 = Math.Min(düşükS, ortaN);
            ÜyelikFonksiyonları.textBox_Üylelik8.Text = soğukorta1.ToString();

            double soğukyüksek = Math.Min(düşükS, yüksek);
            ÜyelikFonksiyonları.textBox_Üylelik9.Text = soğukyüksek.ToString();

            double soğukçokyüksek = Math.Min(düşükS, çokyüksek);
            ÜyelikFonksiyonları.textBox_Üylelik10.Text = soğukçokyüksek.ToString();

            double ortaçokdüşük = Math.Min(ortaS, çokdüşük);
            ÜyelikFonksiyonları.textBox_Üylelik11.Text = ortaçokdüşük.ToString();

            double ortadüşük = Math.Min(ortaS, düşük);
            ÜyelikFonksiyonları.textBox_Üylelik12.Text = ortadüşük.ToString();

            double ortaorta1 = Math.Min(ortaS, ortaN);
            ÜyelikFonksiyonları.textBox_Üylelik13.Text = ortaorta1.ToString();

            double ortayüksek = Math.Min(ortaS, yüksek);
            ÜyelikFonksiyonları.textBox_Üylelik14.Text = ortayüksek.ToString();

            double ortaçokyüksek = Math.Min(ortaS, çokyüksek);
            ÜyelikFonksiyonları.textBox_Üylelik15.Text = ortaçokyüksek.ToString();

            double sıcakçokdüşük = Math.Min(yüksekS, çokdüşük);
            ÜyelikFonksiyonları.textBox_Üylelik16.Text = sıcakçokdüşük.ToString();

            double sıcakdüşük = Math.Min(yüksekS, düşük);
            ÜyelikFonksiyonları.textBox_Üylelik17.Text = sıcakdüşük.ToString();

            double sıcakorta1 = Math.Min(yüksekS, ortaN);
            ÜyelikFonksiyonları.textBox_Üylelik18.Text = sıcakorta1.ToString();

            double sıcakyüksek = Math.Min(yüksekS, yüksek);
            ÜyelikFonksiyonları.textBox_Üylelik19.Text = sıcakyüksek.ToString();

            double sıcakçokyüksek = Math.Min(yüksekS, çokyüksek);
            ÜyelikFonksiyonları.textBox_Üylelik20.Text = sıcakçokyüksek.ToString();

            double çoksıcakçokdüşük = Math.Min(çokyüksekS, çokdüşük);
            ÜyelikFonksiyonları.textBox_Üylelik21.Text = çoksıcakçokdüşük.ToString();

            double çoksıcakdüşük = Math.Min(çokyüksekS, düşük);
            ÜyelikFonksiyonları.textBox_Üylelik22.Text = çoksıcakdüşük.ToString();

            double çoksıcakorta1 = Math.Min(çokyüksekS, ortaN);
            ÜyelikFonksiyonları.textBox_Üylelik23.Text = çoksıcakorta1.ToString();

            double çoksıcakyüksek = Math.Min(çokyüksekS, yüksek);
            ÜyelikFonksiyonları.textBox_Üylelik24.Text = çoksıcakyüksek.ToString();

            double çoksıcakçokyüksek = Math.Min(çokyüksekS, çokyüksek);
            ÜyelikFonksiyonları.textBox_Üylelik25.Text = çoksıcakçokyüksek.ToString();


           
            GirişxDeğerler = (çoksoğukçokdüşük * 5.25) + (çoksoğukdüşük * 5.25) + (çoksoğukorta1 * 4.25) + (çoksoğukyüksek * 4.25) + (çoksoğukçokyüksek * 4.25)
            + (soğukçokdüşük * 4.25) + (soğukdüşük * 4.25) + (soğukorta1 * 4.25) + (soğukyüksek * 3) + (soğukçokyüksek * 3) + (ortaçokdüşük * 3)
            + (ortadüşük * 3) + (ortaorta1 * 3) + (ortayüksek * 3) + (ortaçokyüksek * 1.5) + (sıcakçokdüşük * 1.5) + (sıcakdüşük * 1.5) + (sıcakorta1 * 1.5)
            + (sıcakyüksek * 1.5) + (sıcakçokyüksek * 1.5) + (çoksıcakçokdüşük * 0.5) + (çoksıcakdüşük * 0.5) + (çoksıcakorta1 * 0.5) + (çoksıcakyüksek * 0.5) + (çoksıcakçokyüksek * 0.5);
           
            toplam = çoksoğukçokdüşük + çoksoğukdüşük + çoksoğukorta1 + çoksoğukyüksek + çoksoğukçokyüksek + soğukçokdüşük + soğukdüşük + soğukorta1 + soğukyüksek + soğukçokyüksek +
             ortaçokdüşük + ortadüşük + ortaorta1 + ortayüksek + ortaçokyüksek + sıcakçokdüşük + sıcakdüşük + sıcakorta1 + sıcakyüksek + sıcakçokyüksek + çoksıcakçokdüşük
             + çoksıcakdüşük + çoksıcakorta1 + çoksıcakyüksek + çoksıcakçokyüksek;

            AğırlıklıOrtalama = GirişxDeğerler / toplam;
            textBox_Agırlık.Text = AğırlıklıOrtalama.ToString();

           
            if (AğırlıklıOrtalama <= 0.5 && AğırlıklıOrtalama >= 0)
            {
                çokdüşükA = 1;

            }
            else if (AğırlıklıOrtalama >= 0.5 && AğırlıklıOrtalama <= 1)
            {
                çokdüşükA = (1 - AğırlıklıOrtalama) / (0.5);

            }
            else if (AğırlıklıOrtalama > 1)
            {
                çokdüşükA = 0;
            }
            textBox_çoksoğukIsıtma.Text = çokdüşükA.ToString();

           
            if (AğırlıklıOrtalama > 3 || AğırlıklıOrtalama < 0)
            {
                düşükA = 0;

            }
            else if (AğırlıklıOrtalama >= 0 && AğırlıklıOrtalama <= 1.5)
            {
                düşükA = (AğırlıklıOrtalama - 0) / (1.5);

            }
            else if (AğırlıklıOrtalama >= 1.5 && AğırlıklıOrtalama <= 3)
            {
                düşükA = (3 - AğırlıklıOrtalama) / (1.5);
            }
            textBox_soğukIsıtma.Text = düşükA.ToString();


            
            if (AğırlıklıOrtalama < 2 || AğırlıklıOrtalama > 4)
            {
                ortaA = 0;

            }
            else if (AğırlıklıOrtalama >= 2 && AğırlıklıOrtalama <= 3)
            {
                ortaA = (AğırlıklıOrtalama - 2) / (1);

            }
            else if (AğırlıklıOrtalama >= 3 && AğırlıklıOrtalama <= 4)
            {
                ortaA = (4 - AğırlıklıOrtalama) / (1);
            }
            textBox_ortaIsıtma.Text = ortaA.ToString();
           

            if (AğırlıklıOrtalama > 5 || AğırlıklıOrtalama < 3.5)
            {
                yüksekA = 0;

            }
            else if (AğırlıklıOrtalama >= 3.5 && AğırlıklıOrtalama <= 4.25)
            {
                yüksekA = (AğırlıklıOrtalama - 3.5) / (0.75);

            }
            else if (AğırlıklıOrtalama >= 4.25 && AğırlıklıOrtalama <= 5)
            {
                yüksekA = (5 - AğırlıklıOrtalama) / (0.75);
            }
            textBox_sıcakIsıtma.Text = yüksekA.ToString();

        
            if (AğırlıklıOrtalama < 4.5 || AğırlıklıOrtalama > 6)
            {
                çokyüksekA = 0;

            }
            else if (AğırlıklıOrtalama >= 4.5 && AğırlıklıOrtalama <= 5.25)
            {
                çokyüksekA = (AğırlıklıOrtalama - 4.5) / (0.75);

            }
            else if (AğırlıklıOrtalama >= 5.25 && AğırlıklıOrtalama <= 6)
            {
                çokyüksekA = 1;
            }
            textBox_çoksıcakIsıtma.Text = çokyüksekA.ToString();

            NemGrafik = new NemForm();
            foreach (var series in Chart_Nem.Series)
                
            {
                NemGrafik.Chart_Nem.Series["çokdüşük1"].Points.AddXY(0, 1);
                NemGrafik.Chart_Nem.Series["çokdüşük1"].Points.AddXY(20, 1);
                NemGrafik.Chart_Nem.Series["çokdüşük1"].Points.AddXY(40, 0);
                NemGrafik.Chart_Nem.Series["çokdüşük1"].Points.AddXY(0, 0);


                NemGrafik.Chart_Nem.Series["düşük1"].Points.AddXY(20, 0);
                NemGrafik.Chart_Nem.Series["düşük1"].Points.AddXY(39.5, 1);
                NemGrafik.Chart_Nem.Series["düşük1"].Points.AddXY(59, 0);


                NemGrafik.Chart_Nem.Series["orta11"].Points.AddXY(50, 0);
                NemGrafik.Chart_Nem.Series["orta11"].Points.AddXY(60, 1);
                NemGrafik.Chart_Nem.Series["orta11"].Points.AddXY(70, 0);



                NemGrafik.Chart_Nem.Series["yüksek1"].Points.AddXY(60, 0);
                NemGrafik.Chart_Nem.Series["yüksek1"].Points.AddXY(75, 1);
                NemGrafik.Chart_Nem.Series["yüksek1"].Points.AddXY(90, 0);


                NemGrafik.Chart_Nem.Series["çokyüksek1"].Points.AddXY(80, 0);
                NemGrafik.Chart_Nem.Series["çokyüksek1"].Points.AddXY(90, 1);
                NemGrafik.Chart_Nem.Series["çokyüksek1"].Points.AddXY(100, 1);
                NemGrafik.Chart_Nem.Series["çokyüksek1"].Points.AddXY(100, 0);
                series.Points.Clear();
            }

            NemGrafik.Chart_Nem.Series["çokdüşük1"].Points.AddXY(Nem, 0);
            NemGrafik.Chart_Nem.Series["çokdüşük1"].Points.AddXY(Nem, çokdüşük);

            NemGrafik.Chart_Nem.Series["düşük1"].Points.AddXY(Nem, 0);
            NemGrafik.Chart_Nem.Series["düşük1"].Points.AddXY(Nem, düşük);

            NemGrafik.Chart_Nem.Series["orta11"].Points.AddXY(Nem, 0);
            NemGrafik.Chart_Nem.Series["orta11"].Points.AddXY(Nem, ortaN);

            NemGrafik.Chart_Nem.Series["yüksek1"].Points.AddXY(Nem, 0);
            NemGrafik.Chart_Nem.Series["yüksek1"].Points.AddXY(Nem, yüksek);

            NemGrafik.Chart_Nem.Series["çokyüksek1"].Points.AddXY(Nem, 0);
            NemGrafik.Chart_Nem.Series["çokyüksek1"].Points.AddXY(Nem, çokyüksek);
            //ısıtmaforeach
            IsıtmaGrafik = new IsıtmaForm();
            foreach (var series in Chart_Isıtma.Series)

            {
                IsıtmaGrafik.Chart_Isıtma.Series["çokdüşükIsıtma"].Points.AddXY(0, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["çokdüşükIsıtma"].Points.AddXY(0.5, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["çokdüşükIsıtma"].Points.AddXY(1, 0);
                IsıtmaGrafik.Chart_Isıtma.Series["çokdüşükIsıtma"].Points.AddXY(0, 0);


                IsıtmaGrafik.Chart_Isıtma.Series["düşükIsıtma"].Points.AddXY(0, 0);
                IsıtmaGrafik.Chart_Isıtma.Series["düşükIsıtma"].Points.AddXY(1.5, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["düşükIsıtma"].Points.AddXY(3, 0);


                IsıtmaGrafik.Chart_Isıtma.Series["ortaIsıtma"].Points.AddXY(2, 0);
                IsıtmaGrafik.Chart_Isıtma.Series["ortaIsıtma"].Points.AddXY(3, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["ortaIsıtma"].Points.AddXY(4, 0);



                IsıtmaGrafik.Chart_Isıtma.Series["yüksekIsıtma"].Points.AddXY(3.5, 0);
                IsıtmaGrafik.Chart_Isıtma.Series["yüksekIsıtma"].Points.AddXY(4.25, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["yüksekIsıtma"].Points.AddXY(5, 0);


                IsıtmaGrafik.Chart_Isıtma.Series["çokyüksekIsıtma"].Points.AddXY(4.5, 0);
                IsıtmaGrafik.Chart_Isıtma.Series["çokyüksekIsıtma"].Points.AddXY(5, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["çokyüksekIsıtma"].Points.AddXY(6, 1);
                IsıtmaGrafik.Chart_Isıtma.Series["çokyüksekIsıtma"].Points.AddXY(6, 0);
                series.Points.Clear();

               
            }




            IsıtmaGrafik.Chart_Isıtma.Series["çokdüşükIsıtma"].Points.AddXY(AğırlıklıOrtalama, 0);
            IsıtmaGrafik.Chart_Isıtma.Series["çokdüşükIsıtma"].Points.AddXY(AğırlıklıOrtalama, çokdüşükA);


            IsıtmaGrafik.Chart_Isıtma.Series["düşükIsıtma"].Points.AddXY(AğırlıklıOrtalama, 0);
            IsıtmaGrafik.Chart_Isıtma.Series["düşükIsıtma"].Points.AddXY(AğırlıklıOrtalama, düşükA);

            IsıtmaGrafik.Chart_Isıtma.Series["ortaIsıtma"].Points.AddXY(AğırlıklıOrtalama, 0);
            IsıtmaGrafik.Chart_Isıtma.Series["ortaIsıtma"].Points.AddXY(AğırlıklıOrtalama, ortaA);

            IsıtmaGrafik.Chart_Isıtma.Series["yüksekIsıtma"].Points.AddXY(AğırlıklıOrtalama, 0);
            IsıtmaGrafik.Chart_Isıtma.Series["yüksekIsıtma"].Points.AddXY(AğırlıklıOrtalama, yüksekA);

            IsıtmaGrafik.Chart_Isıtma.Series["çokyüksekIsıtma"].Points.AddXY(AğırlıklıOrtalama, 0);
            IsıtmaGrafik.Chart_Isıtma.Series["çokyüksekIsıtma"].Points.AddXY(AğırlıklıOrtalama, çokyüksekA);


           
            sıcaklık = new SıcaklıkForm();

            foreach (var series in Chart_Sıcaklık.Series)
            {
                sıcaklık.Chart_Sıcaklık.Series["çoksoğuk"].Points.AddXY(-10, 0);
                sıcaklık.Chart_Sıcaklık.Series["çoksoğuk"].Points.AddXY(-10, 1);
                sıcaklık.Chart_Sıcaklık.Series["çoksoğuk"].Points.AddXY(0, 1);
                sıcaklık.Chart_Sıcaklık.Series["çoksoğuk"].Points.AddXY(10, 0);


                sıcaklık.Chart_Sıcaklık.Series["soğuk"].Points.AddXY(0, 0);
                sıcaklık.Chart_Sıcaklık.Series["soğuk"].Points.AddXY(7.5, 1);
                sıcaklık.Chart_Sıcaklık.Series["soğuk"].Points.AddXY(15, 0);


                sıcaklık.Chart_Sıcaklık.Series["orta"].Points.AddXY(14, 0);
                sıcaklık.Chart_Sıcaklık.Series["orta"].Points.AddXY(20, 1);
                sıcaklık.Chart_Sıcaklık.Series["orta"].Points.AddXY(26, 0);


                sıcaklık.Chart_Sıcaklık.Series["sıcak"].Points.AddXY(20, 0);
                sıcaklık.Chart_Sıcaklık.Series["sıcak"].Points.AddXY(30, 1);
                sıcaklık.Chart_Sıcaklık.Series["sıcak"].Points.AddXY(40, 0);



                sıcaklık.Chart_Sıcaklık.Series["çoksıcak"].Points.AddXY(30, 0);
                sıcaklık.Chart_Sıcaklık.Series["çoksıcak"].Points.AddXY(40, 1);
                sıcaklık.Chart_Sıcaklık.Series["çoksıcak"].Points.AddXY(50, 1);
                sıcaklık.Chart_Sıcaklık.Series["çoksıcak"].Points.AddXY(50, 0);

                series.Points.Clear();
            }
            
            sıcaklık.Chart_Sıcaklık.Series["çoksoğuk"].Points.AddXY(Sıcaklık, 0);
            sıcaklık.Chart_Sıcaklık.Series["çoksoğuk"].Points.AddXY(Sıcaklık, çokdüşükS);

            sıcaklık.Chart_Sıcaklık.Series["soğuk"].Points.AddXY(Sıcaklık, 0);
            sıcaklık.Chart_Sıcaklık.Series["soğuk"].Points.AddXY(Sıcaklık, düşükS);

            sıcaklık.Chart_Sıcaklık.Series["orta"].Points.AddXY(Sıcaklık, 0);
            sıcaklık.Chart_Sıcaklık.Series["orta"].Points.AddXY(Sıcaklık, ortaS);

            sıcaklık.Chart_Sıcaklık.Series["sıcak"].Points.AddXY(Sıcaklık, 0);
            sıcaklık.Chart_Sıcaklık.Series["sıcak"].Points.AddXY(Sıcaklık, yüksekS);

            sıcaklık.Chart_Sıcaklık.Series["çoksıcak"].Points.AddXY(Sıcaklık, 0);
            sıcaklık.Chart_Sıcaklık.Series["çoksıcak"].Points.AddXY(Sıcaklık, çokyüksekS);




        }


        private void sicaklik_Click(object sender, EventArgs e)
            {

            }

            private void textBox_sicaklik_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
