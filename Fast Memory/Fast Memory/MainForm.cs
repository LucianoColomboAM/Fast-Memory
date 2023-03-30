/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 30/07/2018
 * Time: 20:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fast_Memory
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
        int lvl1;
        int lvl2;
        int lvl3;
        int contador;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int min;//estas dos variables regulan 
		int seg;// el tiempo en los void nivel1,2 y 3
		public void nivel1(){
            contador = 1;
			//timer1.Start();
			/*pictureBox10.Visible=false;
			iniciar.Visible=false;*/
			min=2;
			seg=0;
			timer1.Enabled=true;
			labeltiempodisp.Visible=true;
			fondo.Image=Image.FromFile("fondoa.jpg");
			imagencompleta.Image=Image.FromFile("imagencompleta1.jpg");
			pictureBox22.Image=Image.FromFile("fondo2.jpg");
			pictureBox12.Image=Image.FromFile("fondo2.jpg");
			pictureBox32.Image=Image.FromFile("fondo2.jpg");
			pictureBox42.Image=Image.FromFile("fondo2.jpg");
			pictureBox52.Image=Image.FromFile("fondo2.jpg");
			pictureBox62.Image=Image.FromFile("fondo2.jpg");
			pictureBox72.Image=Image.FromFile("fondo2.jpg");
			pictureBox82.Image=Image.FromFile("fondo2.jpg");
			pictureBox92.Image=Image.FromFile("fondo2.jpg");
            Random  rnd = new Random();
            lvl1 = rnd.Next(1, 5);
            switch (lvl1)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("1_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox2.Image = Image.FromFile("1_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox3.Image = Image.FromFile("1_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox4.Image = Image.FromFile("1_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox5.Image = Image.FromFile("1_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox6.Image = Image.FromFile("1_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox7.Image = Image.FromFile("1_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox8.Image = Image.FromFile("1_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox9.Image = Image.FromFile("1_06.jpg");
                    pictureBox7.Tag = "1";
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("1_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox2.Image = Image.FromFile("1_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox3.Image = Image.FromFile("1_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox4.Image = Image.FromFile("1_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox5.Image = Image.FromFile("1_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox6.Image = Image.FromFile("1_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox7.Image = Image.FromFile("1_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox8.Image = Image.FromFile("1_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox9.Image = Image.FromFile("1_08.jpg");
                    pictureBox7.Tag = "8";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("1_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox2.Image = Image.FromFile("1_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox3.Image = Image.FromFile("1_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox4.Image = Image.FromFile("1_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox5.Image = Image.FromFile("1_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("1_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox7.Image = Image.FromFile("1_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox8.Image = Image.FromFile("1_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox9.Image = Image.FromFile("1_08.jpg");
                    pictureBox7.Tag = "8";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("1_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox2.Image = Image.FromFile("1_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox3.Image = Image.FromFile("1_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox4.Image = Image.FromFile("1_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox5.Image = Image.FromFile("1_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox6.Image = Image.FromFile("1_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox7.Image = Image.FromFile("1_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox8.Image = Image.FromFile("1_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox9.Image = Image.FromFile("1_06.jpg");
                    pictureBox7.Tag = "6";
                    break;

            }
           
			//timer1.Enabled=true;
			//labeltiempo.Text=timer1;
			
		}
		public void nivel2(){
            contador = 2;
            min =1;
			seg=30;
			//labeltiempodisp.Visible=true;
			pictureBox12.Enabled=false;
			pictureBox22.Enabled=false;
			pictureBox32.Enabled=false;
			pictureBox42.Enabled=false;
			pictureBox52.Enabled=false;
			pictureBox62.Enabled=false;
			pictureBox72.Enabled=false;
			pictureBox82.Enabled=false;
			pictureBox92.Enabled=false;
			pictureBoxaux.Visible=false;
			pictureBoxaux.Visible=false;
			pictureBox22.Image=Image.FromFile("fondo2.jpg");
			pictureBox12.Image=Image.FromFile("fondo2.jpg");
			pictureBox32.Image=Image.FromFile("fondo2.jpg");
			pictureBox42.Image=Image.FromFile("fondo2.jpg");
			pictureBox52.Image=Image.FromFile("fondo2.jpg");
			pictureBox62.Image=Image.FromFile("fondo2.jpg");
			pictureBox72.Image=Image.FromFile("fondo2.jpg");
			pictureBox82.Image=Image.FromFile("fondo2.jpg");
			pictureBox92.Image=Image.FromFile("fondo2.jpg");
            Random rndq = new Random();
            lvl2 = rndq.Next(1, 5);
            switch (lvl2)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("2_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox2.Image = Image.FromFile("2_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox3.Image = Image.FromFile("2_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox4.Image = Image.FromFile("2_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox5.Image = Image.FromFile("2_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("2_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox7.Image = Image.FromFile("2_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox8.Image = Image.FromFile("2_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox9.Image = Image.FromFile("2_02.jpg");
                    pictureBox7.Tag = "2";
                   
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("2_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox2.Image = Image.FromFile("2_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("2_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox4.Image = Image.FromFile("2_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox5.Image = Image.FromFile("2_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox7.Image = Image.FromFile("2_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox8.Image = Image.FromFile("2_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox9.Image = Image.FromFile("2_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox3.Image = Image.FromFile("2_07.jpg");
                    pictureBox7.Tag = "7";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("2_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox2.Image = Image.FromFile("2_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox3.Image = Image.FromFile("2_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox4.Image = Image.FromFile("2_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox5.Image = Image.FromFile("2_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("2_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox7.Image = Image.FromFile("2_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox8.Image = Image.FromFile("2_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox9.Image = Image.FromFile("2_08.jpg");
                    pictureBox7.Tag = "8";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("2_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox2.Image = Image.FromFile("2_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox3.Image = Image.FromFile("2_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox4.Image = Image.FromFile("2_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox5.Image = Image.FromFile("2_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox6.Image = Image.FromFile("2_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox7.Image = Image.FromFile("2_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox8.Image = Image.FromFile("2_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox9.Image = Image.FromFile("2_06.jpg");
                    pictureBox7.Tag = "6";

                    break;
            }
            imagencompleta.Image=Image.FromFile("imagencompleta2.jpg");
			fondo.Image=Image.FromFile("fondob.jpg");
			
			//timer1.Interval=5000;
			timer1.Enabled=true;
			//labeltiempodisp.Visible=true;
		}
		public void nivel3(){
            contador = 3;
            min =1;
			seg=00;
			labeltiempodisp.Visible=true;
			pictureBoxaux.Visible=false;
			labelnivel.Text="Nivel 3";
			pictureBox22.Image=Image.FromFile("fondo2.jpg");
			pictureBox12.Image=Image.FromFile("fondo2.jpg");
			pictureBox32.Image=Image.FromFile("fondo2.jpg");
			pictureBox42.Image=Image.FromFile("fondo2.jpg");
			pictureBox52.Image=Image.FromFile("fondo2.jpg");
			pictureBox62.Image=Image.FromFile("fondo2.jpg");
			pictureBox72.Image=Image.FromFile("fondo2.jpg");
			pictureBox82.Image=Image.FromFile("fondo2.jpg");
			pictureBox92.Image=Image.FromFile("fondo2.jpg");
			imagencompleta.Image=Image.FromFile("imagencompleta3.jpg");
			fondo.Image=Image.FromFile("fondoc.jpg");
            Random rndc = new Random();
            lvl3 = rndc.Next(1, 5);
            switch (lvl3)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile("3_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox2.Image = Image.FromFile("3_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox3.Image = Image.FromFile("3_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox4.Image = Image.FromFile("3_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox5.Image = Image.FromFile("3_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("3_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox7.Image = Image.FromFile("3_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox8.Image = Image.FromFile("3_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox9.Image = Image.FromFile("3_02.jpg");
                    pictureBox7.Tag = "2";

                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile("3_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox2.Image = Image.FromFile("3_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("3_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox4.Image = Image.FromFile("3_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox5.Image = Image.FromFile("3_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox7.Image = Image.FromFile("3_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox8.Image = Image.FromFile("3_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox9.Image = Image.FromFile("3_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox3.Image = Image.FromFile("3_07.jpg");
                    pictureBox7.Tag = "7";
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile("3_06.jpg");
                    pictureBox7.Tag = "6";
                    pictureBox2.Image = Image.FromFile("3_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox3.Image = Image.FromFile("3_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox4.Image = Image.FromFile("3_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox5.Image = Image.FromFile("3_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox6.Image = Image.FromFile("3_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox7.Image = Image.FromFile("3_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox8.Image = Image.FromFile("3_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox9.Image = Image.FromFile("3_08.jpg");
                    pictureBox7.Tag = "8";
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile("3_09.jpg");
                    pictureBox7.Tag = "9";
                    pictureBox2.Image = Image.FromFile("3_04.jpg");
                    pictureBox7.Tag = "4";
                    pictureBox3.Image = Image.FromFile("3_01.jpg");
                    pictureBox7.Tag = "1";
                    pictureBox4.Image = Image.FromFile("3_03.jpg");
                    pictureBox7.Tag = "3";
                    pictureBox5.Image = Image.FromFile("3_07.jpg");
                    pictureBox7.Tag = "7";
                    pictureBox6.Image = Image.FromFile("3_02.jpg");
                    pictureBox7.Tag = "2";
                    pictureBox7.Image = Image.FromFile("3_08.jpg");
                    pictureBox7.Tag = "8";
                    pictureBox8.Image = Image.FromFile("3_05.jpg");
                    pictureBox7.Tag = "5";
                    pictureBox9.Image = Image.FromFile("3_06.jpg");
                    pictureBox7.Tag = "6";

                    break;
            }
			//timer1.Interval=5000;
			timer1.Enabled=true;
		}
		void ImagencompletaClick(object sender, EventArgs e)
		{
			imagencompleta.Image=Image.FromFile("fondo2.jpg");
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			//labelperdiste.Visible=false;
			//labelganaste.Visible=false;
			labeltiempo.Visible=false;
			labeltiempodisp.Visible=false;
			//pictureBoxfin.Visible=false;
			//labelfin.Visible=false;
			//pictureBoxcomenzar.Image=Image.FromFile("comenzar.jpg");
		}
		void BorrartodoClick(object sender, EventArgs e)
		{
			pictureBox22.Image=Image.FromFile("fondo2.jpg");
			pictureBox12.Image=Image.FromFile("fondo2.jpg");
			pictureBox32.Image=Image.FromFile("fondo2.jpg");
			pictureBox42.Image=Image.FromFile("fondo2.jpg");
			pictureBox52.Image=Image.FromFile("fondo2.jpg");
			pictureBox62.Image=Image.FromFile("fondo2.jpg");
			pictureBox72.Image=Image.FromFile("fondo2.jpg");
			pictureBox82.Image=Image.FromFile("fondo2.jpg");
			pictureBox92.Image=Image.FromFile("fondo2.jpg");
			//timer1.Enabled = true;
		}
        void ConfirmarClick(object sender, EventArgs e)
        {
            if ((pictureBox12.Tag.ToString() == "1") && (pictureBox22.Tag.ToString() == "2") && (pictureBox32.Tag.ToString() == "3") && (pictureBox42.Tag.ToString() == "4") && (pictureBox52.Tag.ToString() == "5") && (pictureBox62.Tag.ToString() == "6") && (pictureBox72.Tag.ToString() == "7") && (pictureBox82.Tag.ToString() == "8") && (pictureBox92.Tag.ToString() == "9"))
            {
                MessageBox.Show("¡Correcto!", "¡Pasaste de nivel!");

                if (labelnivel.Text.Contains("3")) {
                    MessageBox.Show("¡Ganaste!", "¡Felicidades!");
                    labeltiempodisp.Visible = false;
                    labeltiempo.Visible = false;
                    labelnivel.Visible = false;
                    //pictureBoxfin.Image = Image.FromFile("ganaste.jpg");
                    //pictureBoxfin.Visible = true;
                    //labelfin.Visible = true;
                    //labelganaste.Visible = true;
                }
                if (labelnivel.Text.Contains("2")) {
                    nivel3();
                } else {
                    labelnivel.Text = "Nivel 2";
                    /*imagencompleta.Image=Image.FromFile("H:\\Fast Memory\\imagencompleta2.jpg");
                    fondo.Image=Image.FromFile("H:\\Fast Memory\\fondob.jpg");
                    pictureBox7.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_07.jpg");
                pictureBox7.Tag="7";
                pictureBox6.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_06.jpg");
                pictureBox7.Tag="6";
                pictureBox5.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_05.jpg");
                pictureBox7.Tag="5";
                pictureBox4.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_04.jpg");
                pictureBox7.Tag="4";
                pictureBox3.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_03.jpg");
                pictureBox7.Tag="3";
                pictureBox2.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_02.jpg");
                pictureBox7.Tag="2";
                pictureBox1.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_01.jpg");
                pictureBox7.Tag="1";
                pictureBox8.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_08.jpg");
                pictureBox7.Tag="8";
                pictureBox9.Image=Image.FromFile("H:\\Fast Memory\\x\\imágenes\\2_09.jpg");
                pictureBox7.Tag="9";*/
                    //fondo2();
                    nivel2();
                }
            } else {
                MessageBox.Show("¡Incorrecto!");
                //nivel1();
                labeltiempo.Visible = false;
                labeltiempodisp.Visible = false;
                //pictureBoxfin.Image=Image.FromFile("perdiste.jpg");
                //pictureBoxfin.Visible=true;
                //labelperdiste.Visible=true;
                //labelfin.Visible=true;
            }
		}
		void PictureBox12Click(object sender, EventArgs e)
		{
	pictureBox12.Image=pictureBoxaux.Image;
		pictureBox12.Tag=pictureBoxaux.Tag;
		if ((pictureBox12.Image==pictureBox22.Image)||(pictureBox12.Image==pictureBox32.Image)||(pictureBox12.Image==pictureBox42.Image)||(pictureBox12.Image==pictureBox52.Image)||(pictureBox12.Image==pictureBox62.Image)||(pictureBox12.Image==pictureBox72.Image)||(pictureBox12.Image==pictureBox82.Image)||(pictureBox12.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox12.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox22Click(object sender, EventArgs e)
		{
	pictureBox22.Image=pictureBoxaux.Image;
	pictureBox22.Tag=pictureBoxaux.Tag;
	if ((pictureBox22.Image==pictureBox12.Image)||(pictureBox22.Image==pictureBox32.Image)||(pictureBox22.Image==pictureBox42.Image)||(pictureBox22.Image==pictureBox52.Image)||(pictureBox22.Image==pictureBox62.Image)||(pictureBox22.Image==pictureBox72.Image)||(pictureBox22.Image==pictureBox82.Image)||(pictureBox22.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox22.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox32Click(object sender, EventArgs e)
		{
	pictureBox32.Image=pictureBoxaux.Image;
	pictureBox32.Tag=pictureBoxaux.Tag;
	if ((pictureBox32.Image==pictureBox12.Image)||(pictureBox32.Image==pictureBox22.Image)||(pictureBox32.Image==pictureBox42.Image)||(pictureBox32.Image==pictureBox52.Image)||(pictureBox32.Image==pictureBox62.Image)||(pictureBox32.Image==pictureBox72.Image)||(pictureBox32.Image==pictureBox82.Image)||(pictureBox32.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox32.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox42Click(object sender, EventArgs e)
		{
	pictureBox42.Image=pictureBoxaux.Image;
	pictureBox42.Tag=pictureBoxaux.Tag;
	if ((pictureBox42.Image==pictureBox12.Image)||(pictureBox42.Image==pictureBox22.Image)||(pictureBox42.Image==pictureBox32.Image)||(pictureBox42.Image==pictureBox52.Image)||(pictureBox42.Image==pictureBox62.Image)||(pictureBox42.Image==pictureBox72.Image)||(pictureBox42.Image==pictureBox82.Image)||(pictureBox42.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox42.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox52Click(object sender, EventArgs e)
		{
	pictureBox52.Image=pictureBoxaux.Image;
	pictureBox52.Tag=pictureBoxaux.Tag;
	if ((pictureBox52.Image==pictureBox12.Image)||(pictureBox52.Image==pictureBox22.Image)||(pictureBox52.Image==pictureBox32.Image)||(pictureBox52.Image==pictureBox42.Image)||(pictureBox12.Image==pictureBox62.Image)||(pictureBox52.Image==pictureBox72.Image)||(pictureBox52.Image==pictureBox82.Image)||(pictureBox52.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox52.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox62Click(object sender, EventArgs e)
		{
	pictureBox62.Image=pictureBoxaux.Image;
	pictureBox62.Tag=pictureBoxaux.Tag;
	if ((pictureBox62.Image==pictureBox12.Image)||(pictureBox62.Image==pictureBox22.Image)||(pictureBox62.Image==pictureBox32.Image)||(pictureBox62.Image==pictureBox42.Image)||(pictureBox62.Image==pictureBox52.Image)||(pictureBox62.Image==pictureBox72.Image)||(pictureBox62.Image==pictureBox82.Image)||(pictureBox62.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox62.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox72Click(object sender, EventArgs e)
		{
	pictureBox72.Image=pictureBoxaux.Image;
	pictureBox72.Tag=pictureBoxaux.Tag;
	if ((pictureBox72.Image==pictureBox12.Image)||(pictureBox72.Image==pictureBox22.Image)||(pictureBox72.Image==pictureBox32.Image)||(pictureBox72.Image==pictureBox42.Image)||(pictureBox72.Image==pictureBox52.Image)||(pictureBox72.Image==pictureBox62.Image)||(pictureBox72.Image==pictureBox82.Image)||(pictureBox72.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox72.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox82Click(object sender, EventArgs e)
		{
	pictureBox82.Image=pictureBoxaux.Image;
	pictureBox82.Tag=pictureBoxaux.Tag;
	if ((pictureBox82.Image==pictureBox12.Image)||(pictureBox82.Image==pictureBox22.Image)||(pictureBox82.Image==pictureBox22.Image)||(pictureBox82.Image==pictureBox32.Image)||(pictureBox82.Image==pictureBox42.Image)||(pictureBox82.Image==pictureBox52.Image)||(pictureBox82.Image==pictureBox62.Image)||(pictureBox82.Image==pictureBox72.Image)||(pictureBox82.Image==pictureBox92.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox82.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox92Click(object sender, EventArgs e)
		{
	pictureBox92.Image=pictureBoxaux.Image;
	pictureBox92.Tag=pictureBoxaux.Tag;
	if ((pictureBox92.Image==pictureBox12.Image)||(pictureBox92.Image==pictureBox22.Image)||(pictureBox92.Image==pictureBox32.Image)||(pictureBox92.Image==pictureBox42.Image)||(pictureBox92.Image==pictureBox52.Image)||(pictureBox92.Image==pictureBox62.Image)||(pictureBox92.Image==pictureBox72.Image)||(pictureBox92.Image==pictureBox82.Image)){
			MessageBox.Show ("imagenes iguales", "error");
			pictureBox92.Image=Image.FromFile("fondo2.jpg");
		}
		}
		void PictureBox1Click(object sender, EventArgs e)
		{
			pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
			pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox1.Image;
	pictureBoxaux.Tag="1";
		}
		void PictureBox2Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox2.Image;
	pictureBoxaux.Tag="2";
		}
		void PictureBox3Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
					pictureBoxaux.Visible=true;
		pictureBoxaux.Image=pictureBox3.Image;
	pictureBoxaux.Tag="3";
		}
		void PictureBox4Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox4.Image;
	pictureBoxaux.Tag="4";
		}
		void PictureBox5Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox5.Image;
	pictureBoxaux.Tag="5";
		}
		void PictureBox6Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox6.Image;
	pictureBoxaux.Tag="6";
		}
		void PictureBox7Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox7.Image;
			pictureBoxaux.Tag="7";
		}
		void PictureBox8Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox8.Image;
	pictureBoxaux.Tag="8";
		}
		void PictureBox9Click(object sender, EventArgs e)
		{
						pictureBox12.Enabled=true;
			pictureBox22.Enabled=true;
			pictureBox32.Enabled=true;
			pictureBox42.Enabled=true;
			pictureBox52.Enabled=true;
			pictureBox62.Enabled=true;
			pictureBox72.Enabled=true;
			pictureBox82.Enabled=true;
			pictureBox92.Enabled=true;
						pictureBoxaux.Visible=true;
	pictureBoxaux.Image=pictureBox9.Image;
	pictureBoxaux.Tag="9";
		}
		void VolverunoClick(object sender, EventArgs e)
		{
	if (pictureBox12.Image==pictureBoxaux.Image){
				pictureBox12.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox22.Image==pictureBoxaux.Image){
				pictureBox22.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox32.Image==pictureBoxaux.Image){
				pictureBox32.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox42.Image==pictureBoxaux.Image){
				pictureBox42.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox52.Image==pictureBoxaux.Image){
				pictureBox52.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox62.Image==pictureBoxaux.Image){
				pictureBox62.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox72.Image==pictureBoxaux.Image){
				pictureBox72.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox82.Image==pictureBoxaux.Image){
				pictureBox82.Image=Image.FromFile("fondo2.jpg");
			}
						if (pictureBox92.Image==pictureBoxaux.Image){
				pictureBox92.Image=Image.FromFile("fondo2.jpg");
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			string minutos =min.ToString();
			string segundos =seg.ToString();
			if (min<10){
				minutos="0"+min.ToString();
			}
			if (seg<10){
				segundos="0"+seg.ToString();
			}
			if (seg==0 && min >0){
				min -=1;
				seg=60;
			}
			if (min==0 && seg==0){
				timer1.Stop();
				MessageBox.Show("se termino el tiempo");
							labeltiempodisp.Visible=false;
				//pictureBoxfin.Image=Image.FromFile("perdiste.jpg");
				//pictureBoxfin.Visible=true;
				//labelperdiste.Visible=true;
				//labelfin.Visible=true;
				labeltiempo.Visible=false;
			}
			labeltiempo.Text=minutos+":"+segundos;
			seg -=1;
			/*timer1.Enabled = false;
			MessageBox.Show("se termino el tiempo");*/
			
		}
		void ButtoncomenzarClick(object sender, EventArgs e)
		{
			//pictureBoxcomenzar.Visible=false;
			buttoncomenzar.Visible=false;
			labeltiempo.Visible=true;
            nivel1();
            
		}

        private void labeltiempodisp_Click(object sender, EventArgs e)
        {

        }

        private void btnmezclar_Click(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                nivel1();
            }
            if (contador == 2)
            {
                nivel2();
            }
            if (contador == 3)
            {
                nivel3();
            }
        }
    }
}
