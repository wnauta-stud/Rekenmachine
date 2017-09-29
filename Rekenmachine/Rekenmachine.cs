/* Copyright Wouter Nauta, for educational purposes only. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week3_Opgave_2
{
    
    public partial class Rekenmachine : Form
    {

        string outputstring = "",teken, berekeningswaarde = "", temp ="", dubbelemacht="", num = "";
        int positie = 0, machtactivatie = 0, hakenactivatie = 0, aantalmachten = 0;
       
        double[] machtenarray = new double[1];
        double outputberekening = 0;

        public Rekenmachine()

        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Clear()
        {
            outputstring = "";
            berekeningswaarde = "";
            hakenactivatie = 0;
            machtactivatie = 0;
            dubbelemacht = "";
            Array.Clear(machtenarray, 0, aantalmachten);
        }
        private void outputmethod()
        {

            output.Text = "   " + outputstring;
        }
    
        private void machtenstatus()
        {
            if (machtactivatie == 2)
            {

                machten();


            }
            else
            {
                if (num == ".")
                {
                    berekeningswaarde += '.';
                    outputstring += ",";
                }
                else
                {
                    berekeningswaarde += num;
                    outputstring += num;
                }

                outputmethod();
            }
        }
        private void machten()
        {

            if (machtactivatie == 2)
            {

                int waardegrootte = berekeningswaarde.Length - positie;
                temp = berekeningswaarde.Substring(positie, waardegrootte);
                dubbelemacht += num;
                outputstring += num;
                outputmethod();
            }
            else if (machtactivatie == 1 && temp.Length > 0 && dubbelemacht.Length > 0)
            {
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new DataTable();
                    double tempvalue = Math.Pow(Convert.ToDouble(dt1.Compute(temp, "")), Convert.ToDouble(dt2.Compute(dubbelemacht, "")));
                    machtenarray[aantalmachten] = tempvalue;
                    berekeningswaarde = berekeningswaarde.Replace(temp, "");

                    aantalmachten++;
                    Array.Resize(ref machtenarray, (aantalmachten + 1));
                    dubbelemacht = "";
                    temp = "";
                    machtactivatie = 0;
        
            }
        }

        private void number_Click(object sender, EventArgs e)
        {
            num = (sender as Button).Text;
            if (num.Equals(0) && berekeningswaarde.Length > 0)
            {
                char last = berekeningswaarde[berekeningswaarde.Length - 1];
                if (last.Equals('/'))
                {
                    outputstring = outputstring.Remove(outputstring.Length - 1);
                    berekeningswaarde = berekeningswaarde.Remove(berekeningswaarde.Length - 1);
                    MessageBox.Show("Error kan niet delen door 0");
                    outputmethod();
                } else { machtenstatus(); }
    

                    }
            else
            {
                machtenstatus();
            }
        }

        private void tekens_Click(object sender, EventArgs e)
        {
            num = (sender as Button).Text;

                machtenstatus();

                if (num.Equals("("))
                {
                    hakenactivatie++;
                }
                else if (num.Equals(")"))
                {

                    hakenactivatie--;
                }

        }
        private void komma_Click(object sender, EventArgs e)
        {
            num = ".";
            machtenstatus();
        }
        private void macht_Click(object sender, EventArgs e)
        {

        
            bool isNum = Regex.IsMatch(berekeningswaarde[berekeningswaarde.Length - 1].ToString(), @"[0-9]$");
            outputstring += "^";
            if (berekeningswaarde[berekeningswaarde.Length - 1].ToString().Equals(")"))
            {
                for (int i = (berekeningswaarde.Length - 1); i >= 0; i--)
                {
                    if (berekeningswaarde[i].ToString().Equals("("))
                    {
                        positie = i; 

                        break;
                    }
                }
                machtactivatie = 2;

            }

            else if (isNum == true)
            {

                for (int i = (berekeningswaarde.Length-1);  i>=0; i-- )
                {
                    bool isNum2 = Regex.IsMatch(berekeningswaarde[i].ToString(), @"[0-9]$");
                    if (isNum2 == true)
                    {
                        positie = i;
                        machtactivatie =2;
                    }
                    else{
                        break;
                    }
                }
            }
            outputmethod();
            
        }
            
       
        private void berekenen_Click(object sender, EventArgs e)
        {
            if (hakenactivatie > 0)
            {
                MessageBox.Show("U bent een haakje sluiten vergeten.");

            }
            else if (hakenactivatie < 0)
            {
                MessageBox.Show("U bent een haakje openen vergeten.");
            }
            else
            {

                machtactivatie = 1;
                machten();
                if (berekeningswaarde.Length > 0)
                {
                    DataTable dt = new DataTable();
                    outputberekening = Convert.ToDouble(dt.Compute(berekeningswaarde, "")) + machtenarray.Sum();
                }
                else
                {
                    outputberekening = machtenarray.Sum();
                }
                
                output.Text = "   " + outputstring + " = " + outputberekening.ToString();
                Clear();
            } 
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Clear();
            output.Text = "";
        }

    }
}
