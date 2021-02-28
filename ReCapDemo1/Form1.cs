using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReCapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Button[,] buttons = new Button[8,8]; //8'e 8'lik button arrayi
            int top = 0;
            int left = 0;

            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            { //0. boyutun alabileceği en büyük değer 7'dir.
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    //i 0 j 0 , i 0 j 1 en son 7 olucak  0'ın 8.butonu ibi
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;
                    if((i+j)%2==0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i,j]); //this forma karşılık gelir.
                    //ilk butondan sonra diğerini sağa doğru 50 karakter sonra
                    //başlatmak gerekiyor.
                }
                //2. satırda lefti sıfırlamak lazım ki sola geçsin
                top += 50;
                left = 0; 
            }           
           
        }
    }
}
