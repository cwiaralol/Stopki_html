using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stopki_html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         
        Przycisk "Generuj wywołuje akcje pobrania wszystkich wartości i wykonania stopki"
         
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.imie = textBox1.Text;
            Program.nazwisko = textBox2.Text;
            Program.dzial = treeView1.SelectedNode.Parent.Name;
            Program.stanowisko = treeView1.SelectedNode.Name;
            Program.emailEND = listBox1.SelectedItem.ToString();
            MessageBox.Show(Program.imie);
            MessageBox.Show(Program.nazwisko);
            MessageBox.Show(Program.dzial);
            MessageBox.Show(Program.stanowisko);
            MessageBox.Show(Program.emailEND);
            //MessageBox.Show("Wygenerowano stopkę");
            Application.Restart();
        }



    }
}
