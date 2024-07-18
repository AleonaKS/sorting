using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz
{
    public partial class Form1 : Form
    {
        Data input = new Data();
        public Form1()
        {
            InitializeComponent();
        }

        // запись в блоки после нажатия "Сортировать"
        private void button1_Click(object sender, EventArgs e)
        {
            textVR1.Text ="";
            string[] output1 = input.process1(text1.Text);
            for (int i = 0; i < output1.Length; i++)
            {
                textVR1.Text = textVR1.Text + output1[i] + "\n";
            }
            Invalidate();
            textVR2.Text = "";
            string[] output2 = input.process2(text1.Text);
            for (int i = 0; i < output2.Length; i++)
            {
                textVR2.Text = textVR2.Text + output2[i] + "\n";
            }
            Invalidate();
        }
      
        // для сохранения
        private void button2_Click(object sender, EventArgs e) 
        {
            StreamWriter File = new StreamWriter("Запись.txt");
            string[] write1 = input.ZArray(textVR1.Text);
            for (int i = 0 ; i < write1.Length; i++)
            {
                File.WriteLine(write1[i]);
            }
            File.WriteLine();
            string[] write2 = input.ZArray(textVR2.Text);
            for (int i = 0; i < write2.Length; i++)
            {
                File.WriteLine(write2[i]);
            }
            MessageBox.Show("Сохранение данных завершено");
            File.Close();
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {
            textVR1.Text = "";
            Invalidate();
        }
        private void text2_TextChanged(object sender, EventArgs e)
        {
            textVR2.Text = "";
            Invalidate();
        }
    }

    class Data
    {
        public  string[] ZArray(string read)
        {
            string[] Filtr = new string[] { "\n", " " };
            string[] Zapolnenie = read.Split(Filtr, StringSplitOptions.RemoveEmptyEntries);
            return Zapolnenie;
        }
        private int[] insertSort(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int Buff = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = Buff;
                    }
                }
            }
            return a;
        }

        private int[] reverseSort(int[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (b[j + 1] > b[j])
                    {
                        int Buff = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = Buff;
                    }
                }
            }
            return b;
        }

        public string[] process1(string read)
        {

            string[] strArray1 = ZArray(read);
            int[] intArray1 = new int[strArray1.Length];
            
            for (int i = 0; i < strArray1.Length; i++)
            {
                try
                {
                    intArray1[i] = Convert.ToInt32(strArray1[i]);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка");
                    string[] error = new string[]{ "" };
                    return error;
                }               
            }

            intArray1 = insertSort(intArray1, intArray1.Length);
            for (int i = 0; i < strArray1.Length; i++)
            {
                strArray1[i] = intArray1[i].ToString();
            }
            return strArray1;
        }

        public string[] process2(string read)
        {

            string[] strArray2 = ZArray(read);
            int[] intArray2 = new int[strArray2.Length];

            for (int i = 0; i < strArray2.Length; i++)
            {
                try
                {
                    intArray2[i] = Convert.ToInt32(strArray2[i]);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка");
                    string[] error = new string[] { "" };
                    return error;
                }
            }

            intArray2 = reverseSort(intArray2, intArray2.Length);
            for (int i = 0; i < strArray2.Length; i++)
            {
                strArray2[i] = intArray2[i].ToString();
    }
            return strArray2;
        }

    }
}
