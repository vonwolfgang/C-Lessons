using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recap_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            /*
            Button button = new Button();
            // Button hazır yazılmış bir class bu classdan bir obje oluşturduk
            button.Width = 50;
            // bu clasın içinde Width denen genişlik alan şeye 50 atadık
            button.Height = 50;
            // bu sınıfın içinde Height denen yükseklik alan şeye 50 atadık
            this.Controls.Add(button);
            // bu metot sayesindede ekrana ekledik butonumuzu.
            // böle yaparak  çok uzun sürer birsürü button eklemek ekrana bu yüzden
            // bunu değiştiricez
            */

            //-------------------------------------------------------------------
            
            // DAMA TAHTASI

            Button[,] button_1 = new Button[8, 8];
            // yukarıda bir matrix tanımladık
            int top = 0;
            int left = 0;
            // bu değişkenleri oluşan her yeni butonu üst üste koymasın diye yaptık

            for (int i = 0; i < button_1.GetUpperBound(0); i++)
                // yukarıda button_1 matrixinin GetUpperBound(0) diyerek
                // 0. indexdeki yani 8 satırdan küçük olcak şekilde ayarladık
            {
                for (int j = 0; j < button_1.GetUpperBound(1); j++)
                    // bu sefer de aynı şeyi diğer 8 sütundan küçük olcak şekilde yaptık
                {
                    button_1[i, j] = new Button();
                    // her seferinde yeni bir button ekliyeceğimiz için her dönüşte yeni bir buton oluşturduk
                    
                    button_1[i, j].Width = 50;
                    button_1[i, j].Height = 50;
                    // her yeni oluşan buttonların özelliklerini belirledik

                    button_1[i,j].Left = left;
                    // burda button_1 'in soldan uzaklığını atadık
                    left += 50;
                    // üst üste binmesin diye de her seferinde +50 yapmamız gerek.
                    button_1[i,j].Top = top;
                    // burdada buttonun yukarıdan yüksekliğini verdik

                    if ((i+j)%2==0)
                    {
                        button_1[i,j].BackColor = Color.Black;
                    }
                    else
                    {
                        button_1[i,j].BackColor = Color.White;
                    }



                    this.Controls.Add(button_1[i,j]);
                    // her yeni oluşan buttonu ekledik


                }
                top += 50;
                // her yeni satıra geçtiğimizde bir alt satıra insin diye top'ı 50 arttırdık

                left = 0; 
                // her satıra da baştan başlasın diye left'i sıfırladık




                
                


            }
            


        }
    }
}
