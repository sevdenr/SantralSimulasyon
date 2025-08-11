using EasyModbus;
using SantralSimülasyon.Properties;
using System.Reflection.Emit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SantralSimülasyon
{  // döngü
    public partial class Form1 : Form
    {
        ModbusClient plc = new ModbusClient("192.168.0.50", 502);
        private static PlcOkunacakVeri degerler = new PlcOkunacakVeri();
        public bool SistemDurum = false;
        public static bool[] mb;
        public static int[] mbI;
        public static int syc;
        private int sycKabin1 = 0;
        private int sycKabin2 = 0;
        private int sycKabin3 = 0;
        public int dgrKabin1, dgr1, dgr2, dgr3, dgrKabin2, dgrKabin3;
        public int adet;

        public Form1()
        {
            //timer1.Interval = 50; // 3 saniye (3000 milisaniye)
            plc.Connect();
            VeriOkuma();
            IsikDurumu();
            InitializeComponent();

        }
        private void Baslat(object sender, EventArgs e)
        {
            KabinVerileri();
            if (SistemDurum)
            {
                SistemiBaslat();
            }
            else
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KabinVerileri();
        }
        private void KabinVerileri()
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                try
                {
                    dgrKabin1 = Convert.ToInt32(textBox1.Text);
                    dgrKabin2 = Convert.ToInt32(textBox2.Text);
                    dgrKabin3 = Convert.ToInt32(textBox3.Text);
                    adet = Convert.ToInt32(textBox4.Text);
                    SistemDurum = true;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Kabin değerleri sadece sayısal olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm kabin değerlerini giriniz.", "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SistemiBaslat()
        {
            baslat.Image = Resources.Acik;
            durdur.Image = Resources.Kapa;
            timer1.Start();
            timer2.Start();
            try
            {
                if (plc.Connected)
                {
                    plc.WriteSingleCoil(8, false);
                    plc.WriteSingleCoil(0, true);
                    plc.WriteSingleRegister(1, adet);
                }
                else
                {
                    MessageBox.Show("PLC Bağlantısı Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show($"Veri yazma sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Durdur(object sender, EventArgs e)
        {
            durdur.Image = Resources.Kapali;
            baslat.Image = Resources.Ac;
            try
            {
                if (plc.Connected)
                {
                    plc.WriteSingleCoil(8, true);

                }
                else
                {
                    MessageBox.Show("PLC Bağlantısı Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show($"Veri yazma sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VeriOkuma()
        {
            try
            {
                plc.Connect();
                mb = plc.ReadCoils(0, 11);
                mbI =   plc.ReadHoldingRegisters(0, 11);
            

                if (plc.Connected)
                {
                    degerler.start = mb[0];
                    degerler.m1 = mb[1];
                    degerler.m2 = mb[2];
                    degerler.kabin1 = mb[3];
                    degerler.m3 = mb[4];
                    degerler.kabin2 = mb[5];
                    degerler.kabin3 = mb[6];
                    degerler.motorDurum = mb[7];
                    degerler.stop = mb[8];
                    degerler.m7 = mb[9];
                    degerler.sayac = mb[10];
                   // degerler.Dgr = mbI[1];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri okuma sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void IsikDurumu()
        {
            try
            {   // motor 1
                if (degerler.m1)
                {
                    Motor1.Image = Resources.MOTORON2;
                    syc++;
                    switch (syc)
                    {
                        case 1:
                            M1b1.Image = Resources.BoruAcik;
                            M1b2.Image = Resources.BoruAcik;
                            M1b3.Image = Resources.BoruAcik;
                            M1b4.Image = Resources.BoruAcik;
                            M1b5.Image = Resources.BoruAcik;
                            break;
                        case 5:
                            M1b1.Image = Resources.Boru;
                            M1b2.Image = Resources.Boru;
                            M1b3.Image = Resources.Boru;
                            M1b4.Image = Resources.Boru;
                            M1b5.Image = Resources.Boru;
                            break;
                        case 6: syc = 0; break;
                    }
                    KabinAnimasyon(kabin1, ref sycKabin1);

                    if (dgr1 == dgrKabin1)
                    {
                        dgr1 = 0;

                    }
                    else if (dgr1 < dgrKabin1)
                    {
                        dgr1 = dgr1 + (dgrKabin1 / 15);
                        k1deger.Text = $"{dgr1}";
                    }
                    else
                    {

                        dgr1 = dgr1 + 0;
                        k1deger.Text = $"{dgr1}";
                    }
                }
                else
                {
                    Motor1.Image = Resources.MOTOROFF;
                    M1b1.Image = Resources.Boru;
                    M1b2.Image = Resources.Boru;
                    M1b3.Image = Resources.Boru;
                    M1b4.Image = Resources.Boru;
                    M1b5.Image = Resources.Boru;
                }


                // motor 2
                if (degerler.m2)
                {
                    Motor2.Image = Resources.MOTORON2;
                    syc++;
                    switch (syc)
                    {
                        case 1:
                            M2b1.Image = Resources.BoruAcik;
                            M2b2.Image = Resources.BoruAcik;
                            M2b3.Image = Resources.BoruAcik;
                            M2b4.Image = Resources.BoruAcik;
                            M2b5.Image = Resources.BoruAcik;

                            break;
                        case 4:
                            M2b1.Image = Resources.Boru;
                            M2b2.Image = Resources.Boru;
                            M2b3.Image = Resources.Boru;
                            M2b4.Image = Resources.Boru;
                            M2b5.Image = Resources.Boru;
                            break;
                        case 5:
                            syc = 0; break;
                    }

                    KabinAnimasyon(kabin2, ref sycKabin2);

                    if (dgr2 == dgrKabin2)
                    {
                        dgr2 = 0;

                    }
                    else if (dgr2 < dgrKabin2)
                    {
                        dgr2 = dgr2 + (dgrKabin2 / 15);
                        k2deger.Text = $"{dgr2}";
                    }
                    else
                    {

                        dgr2 = dgr2 + 0;
                        k2deger.Text = $"{dgr2}";
                    }

                }
                else
                {
                    Motor2.Image = Resources.MOTOROFF;
                    M2b1.Image = Resources.Boru;
                    M2b2.Image = Resources.Boru;
                    M2b3.Image = Resources.Boru;
                    M2b4.Image = Resources.Boru;
                    M2b5.Image = Resources.Boru;
                }


                // motor 3
                if (degerler.m3)
                {
                    Motor3.Image = Resources.MOTORON2;

                    syc++;
                    switch (syc)
                    {
                        case 1:
                            M3b1.Image = Resources.BoruAcik;
                            M3b2.Image = Resources.BoruAcik;
                            M3b3.Image = Resources.BoruAcik;
                            M3b4.Image = Resources.BoruAcik;
                            M3b5.Image = Resources.BoruAcik;
                            break;
                        case 5:
                            M3b1.Image = Resources.Boru;
                            M3b2.Image = Resources.Boru;
                            M3b3.Image = Resources.Boru;
                            M3b4.Image = Resources.Boru;
                            M3b5.Image = Resources.Boru;
                            break;
                        case 6:
                            syc = 0; break;
                    }
                    KabinAnimasyon(kabin3, ref sycKabin3);

                    if (dgr3 == dgrKabin3)
                    {
                        dgr3 = 0;

                    }
                    else if (dgr3 < dgrKabin3)
                    {
                        dgr3 = dgr3 + (dgrKabin3 / 15);
                        k3deger.Text = $"{dgr3}";
                    }
                    else
                    {

                        dgr3 = dgr3 + 0;
                        k3deger.Text = $"{dgr3}";
                    }


                }
                else
                {
                    Motor3.Image = Resources.MOTOROFF;
                    M3b1.Image = Resources.Boru;
                    M3b2.Image = Resources.Boru;
                    M3b3.Image = Resources.Boru;
                    M3b4.Image = Resources.Boru;
                    M3b5.Image = Resources.Boru;

                }

                //kabinler
                if (degerler.kabin1)
                {
                    kabin1.Image = Resources.full;
                    k1deger.Text = $"{dgrKabin1}";

                }
                if (degerler.kabin2)
                {
                    kabin2.Image = Resources.full;
                    k2deger.Text = $"{dgrKabin2}";
                }
                if (degerler.kabin3)
                {
                    kabin3.Image = Resources.full;
                    k3deger.Text = $"{dgrKabin3}";
                }






                //motor durumu
                if (degerler.motorDurum)
                {
                    label1.Enabled = true;
                    mikserDurum.Image = Resources.Mikser;
                    mikserKapak.Image = Resources.MikserKapakAcik;
                    kabin1.Image = Resources.bos;
                    kabin2.Image = Resources.bos;
                    kabin3.Image = Resources.bos;

                }
                else
                {
                    mikserDurum.Image = Resources.Mikser2;
                    mikserKapak.Image = Resources.MikserKapakKapali;

                }


                if (degerler.m7)
                {
                    yukleme.Image = Resources.yagmur;
                    mikserDurum.Image = Resources.Mikser2;
                    mikserKapak.Image = Resources.arkaplan;
                    kamyon.Image = Resources.TransmikserSari;
                    mikserKapak.Image = Resources.MikserKapakKapali;


                }
                else
                {
                    kamyon.Image = Resources.Transmikser;

                    yukleme.Image = Resources.arkaplan;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VeriOkuma();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            IsikDurumu();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                plc.Connect();
                if (plc.Connected)
                {
                    VeriOkuma();
                    IsikDurumu(); // İlk yüklemede bağlantı durumunu kontrol et
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int i = 0;

        private void KabinAnimasyon(PictureBox kabin, ref int syc)
        {
            syc++;
            switch (syc)
            {
                case 1: kabin.Image = Resources.bos; break;
                case 2: kabin.Image = Resources.yuzde10; break;
                case 3: kabin.Image = Resources.yuzde50; break;
                case 4: kabin.Image = Resources.yuzde90; break;
                case 5: kabin.Image = Resources.full; break;
                default: syc = 0; break;

            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
