using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text.ToUpper()=="ANKARA")
                        {
                            buttonA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                            
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 2:
                        if (textBox1.Text.ToUpper() == "BURSA")
                        {
                            buttonB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 3:
                        if (textBox1.Text.ToUpper() == "CUMA")
                        {
                            buttonC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 4:
                        if (textBox1.Text.ToUpper() == "DİYARBAKIR")
                        {
                            buttonD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 5:
                        if (textBox1.Text.ToUpper() == "EDİRNE")
                        {
                            buttonE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 6:
                        if (textBox1.Text.ToUpper() == "FAYTON")
                        {
                            buttonF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 7:
                        if (textBox1.Text.ToUpper() == "GRAM")
                        {
                            buttonG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 8:
                        if (textBox1.Text.ToUpper() == "HANÇER")
                        {
                            buttonH.BackColor = Color.Green;
                            SoruGetir();
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 9:
                        if (textBox1.Text.ToUpper() == "ISIRGAN OTU")
                        {
                            buttonI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 10:
                        if (textBox1.Text.ToUpper() == "JANDARMA")
                        {
                            buttonJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 11:
                        if (textBox1.Text.ToUpper() == "KUZEY KORE")
                        {
                            buttonK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 12:
                        if (textBox1.Text.ToUpper() == "LAZ")
                        {
                            buttonL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 13:
                        if (textBox1.Text.ToUpper() == "MART")
                        {
                            buttonM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 14:
                        if (textBox1.Text.ToUpper() == "NİSAN")
                        {
                            buttonN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 15:
                        if (textBox1.Text.ToUpper() == "OCTOBERFEST")
                        {
                            buttonO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 16:
                        if (textBox1.Text.ToUpper() == "PHUKET")
                        {
                            buttonP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 17:
                        if (textBox1.Text.ToUpper() == "RAMAZAN")
                        {
                            buttonR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 18:
                        if (textBox1.Text.ToUpper() == "SAMSUN")
                        {
                            buttonS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 19:
                        if (textBox1.Text.ToUpper() == "TAYLAND")
                        {
                            buttonT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 20:
                        if (textBox1.Text.ToUpper() == "URFA")
                        {
                            buttonU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 21:
                        if (textBox1.Text.ToUpper() == "VAR")
                        {
                            buttonV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 22:
                        if (textBox1.Text.ToUpper() == "YEŞİL")
                        {
                            buttonY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 23:
                        if (textBox1.Text.ToUpper() == "ZEYTİN")
                        {
                            buttonZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                        }
                        break;
                    case 24:
                        if (textBox1.Text.ToUpper() == "XRAY")
                        {
                            buttonX.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                            SoruGetir();
                            timer1.Stop();
                        }
                        else
                        {
                            buttonX.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                            SoruGetir();
                            timer1.Stop();
                        }
                        break;
                }
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SoruGetir();
            timer1.Start();
        }
        int sure = 0;

        private void button25_Click(object sender, EventArgs e)
        {
            timer1.Dispose();
            lblSüre.Text = "0";
            lblDogru.Text = "0";
            lblYanlis.Text = "0";

            buttonA.BackColor = Color.LightGray;
            buttonB.BackColor = Color.LightGray;
            buttonC.BackColor = Color.LightGray;
            buttonD.BackColor = Color.LightGray;
            buttonE.BackColor = Color.LightGray;
            buttonF.BackColor = Color.LightGray;
            buttonG.BackColor = Color.LightGray;
            buttonH.BackColor = Color.LightGray;
            buttonI.BackColor = Color.LightGray;
            buttonJ.BackColor = Color.LightGray;
            buttonK.BackColor = Color.LightGray;
            buttonL.BackColor = Color.LightGray;
            buttonM.BackColor = Color.LightGray;
            buttonN.BackColor = Color.LightGray;
            buttonO.BackColor = Color.LightGray;
            buttonP.BackColor = Color.LightGray;
            buttonR.BackColor = Color.LightGray;
            buttonS.BackColor = Color.LightGray;
            buttonU.BackColor = Color.LightGray;
            buttonV.BackColor = Color.LightGray;
            buttonY.BackColor = Color.LightGray;
            buttonZ.BackColor = Color.LightGray;
            buttonX.BackColor = Color.LightGray;
            buttonT.BackColor = Color.LightGray;
            buttonX.BackColor = Color.LightGray;

            soruno = 0;
            linkLabel1.Text = "Başla";
            richTextBox1.Clear();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            lblSüre.Text = sure.ToString();
        }

        private void SoruGetir()
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            textBox1.Clear();
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin başkentinin adı?";
                buttonA.BackColor = Color.Yellow;
                button25.Text = "A";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara bölgesindeki ilimiz?";
                buttonB.BackColor = Color.Yellow;
                button25.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                buttonC.BackColor = Color.Yellow;
                button25.Text = "C";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                buttonD.BackColor = Color.Yellow;
                button25.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Türkiye'nin Yunanlara komşu olan ili?";
                buttonE.BackColor = Color.Yellow;
                button25.Text = "A";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Adalarda hayvan haklarını ihlal eden ulaşım aracı?";
                buttonF.BackColor = Color.Yellow;
                button25.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Kilonun 1000'de biri?";
                buttonG.BackColor = Color.Yellow;
                button25.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Hasan Sabbah ve fedailerinin kullandığı alet?";
                buttonH.BackColor = Color.Yellow;
                button25.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Ellendiğinde kaşıntı yapan bitki?";
                buttonI.BackColor = Color.Yellow;
                button25.Text = "I";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Polis ve Asker karışımı?";
                buttonJ.BackColor = Color.Yellow;
                button25.Text = "J";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Dış dünyaya kendini kapayan atom bombası sahibi ülke?";
                buttonK.BackColor = Color.Yellow;
                button25.Text = "K";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Karadenizde yoğunlukla yaşayan etnisite?";
                buttonL.BackColor = Color.Yellow;
                button25.Text = "L";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Kapıdan baktırınca kazma kürek yaktıran ay?";
                buttonM.BackColor = Color.Yellow;
                button25.Text = "M";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Ondan sonraki ay?";
                buttonN.BackColor = Color.Yellow;
                button25.Text = "N";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Eylül ayının son hafta Almanya'da düzenlenen festival?";
                buttonO.BackColor = Color.Yellow;
                button25.Text = "O";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Tayland'da bulunan turistik ada?";
                buttonP.BackColor = Color.Yellow;
                button25.Text = "P";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                buttonR.BackColor = Color.Yellow;
                button25.Text = "R";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Atatürk'ün çıkıp kurtuluş savaşını başlattığı ilimiz?";
                buttonS.BackColor = Color.Yellow;
                button25.Text = "S";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Başkenti Bangkok olan Güney Asya ülkesi?";
                buttonT.BackColor = Color.Yellow;
                button25.Text = "T";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Şanlı olan ilimiz";
                buttonU.BackColor = Color.Yellow;
                button25.Text = "U";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "C# dilinde genel olarak kullanılan tür";
                buttonV.BackColor = Color.Yellow;
                button25.Text = "V";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Mavi ve sarı renklerin karışımı";
                buttonY.BackColor = Color.Yellow;
                button25.Text = "Y";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Akdeniz bölgesinde yetişen,yağından da faydalanılan meyve?";
                buttonZ.BackColor = Color.Yellow;
                button25.Text = "Z";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Işınları olur?";
                buttonX.BackColor = Color.Yellow;
                button25.Text = "X";
            }
            if(soruno==25)
            {
                richTextBox1.Text = "Tebrikler, " + lblSüre.Text.ToString() + " saniyede " + lblDogru.Text.ToString() + " doğru ile tamamladınız.";
                button25.Text = "SIFIRLA";
                timer1.Stop();
            }
        }
    }
}
