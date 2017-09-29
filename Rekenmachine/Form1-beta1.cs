using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Opgave_2
{
    
    public partial class Form1 : Form
    {

        int berekeningsgrootte =0;
        double outputnumbers = ' ';
        char[] berekeningswaarde = new char[1];
        
        public Form1()

        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void nul_Click(object sender, EventArgs e)
        {
            
            output.Text += 0;
            berekeningswaarde[berekeningsgrootte] += '0';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte+1));


        }
        private void een_Click(object sender, EventArgs e)
        {
            output.Text += 1;
            berekeningswaarde[berekeningsgrootte] += '1' ;
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }

        private void twee_Click(object sender, EventArgs e)
        {
            output.Text += 2;
            berekeningswaarde[berekeningsgrootte] += '2';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }

        private void drie_Click(object sender, EventArgs e)
        {
            output.Text += 3;
            berekeningswaarde[berekeningsgrootte] += '3';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }

        private void vier_Click(object sender, EventArgs e)
        {
            output.Text += 4;
            berekeningswaarde[berekeningsgrootte] += '4';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }


        private void vijf_Click(object sender, EventArgs e)
        {
            output.Text += 5;
            berekeningswaarde[berekeningsgrootte] += '5';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }

        private void zes_Click(object sender, EventArgs e)
        {
            output.Text += 6;
            berekeningswaarde[berekeningsgrootte] +='6';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void zeven_Click(object sender, EventArgs e)
        {
            output.Text += 7;
            berekeningswaarde[berekeningsgrootte] += '7';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void acht_Click(object sender, EventArgs e)
        {
            output.Text += 8;
            berekeningswaarde[berekeningsgrootte] += '8';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void negen_Click(object sender, EventArgs e)
        {
            output.Text += 9;
            berekeningswaarde[berekeningsgrootte] += '9';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void delen_Click(object sender, EventArgs e)
        {
            output.Text += "/";
            berekeningswaarde[berekeningsgrootte] += '/';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void maal_Click(object sender, EventArgs e)
        {
            output.Text += "*";
            berekeningswaarde[berekeningsgrootte] += '*';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void plus_Click(object sender, EventArgs e)
        {
            output.Text += "+";
            berekeningswaarde[berekeningsgrootte] += '+';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void min_Click(object sender, EventArgs e)
        {
            output.Text += "-";
            berekeningswaarde[berekeningsgrootte] += '-';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void komma_Click(object sender, EventArgs e)
        {
            output.Text += ",";
            berekeningswaarde[berekeningsgrootte] += '.';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void macht_Click(object sender, EventArgs e)
        {
            output.Text += "^";

        }
        private void openingshaak_Click(object sender, EventArgs e)
        {
            output.Text += "(";
            berekeningswaarde[berekeningsgrootte] += '(';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void sluitingshaak_Click(object sender, EventArgs e)
        {
            output.Text += ")";
            berekeningswaarde[berekeningsgrootte] += ')';
            berekeningsgrootte++;
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void berekenen_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(var item in berekeningswaarde)
            {
                sum += item;
            }
            berekeningsgrootte = 0;
            outputnumbers = ' ';
            Array.Clear(berekeningswaarde, 0, berekeningswaarde.Length);
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }
        private void clear_Click(object sender, EventArgs e)
        {
            output.Text= "";
            berekeningsgrootte = 0;
            outputnumbers = ' ';
            Array.Clear(berekeningswaarde, 0, berekeningswaarde.Length);
            Array.Resize<char>(ref berekeningswaarde, (berekeningsgrootte + 1));
        }

    }
}
