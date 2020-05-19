using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Magic_Square
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Ok_Click(object sender, EventArgs e)
        {
            
            int c = Convert.ToInt32(number.Text);
            int d = 1;
            int row, col;
            double[,] ms = new double[5, 5];
            int a = (c / 5) - 12;

            {
                for (row = 0; row <= 0; row++)
                {
                    if (row == 0)
                        ms[0, (5 - 1) / 2] = a;

                    for (col = (5 - 1) / 2; col > -1;)
                    {
                        //if (5 % 2 != 0)
                        //{
                            row--;
                            col++;
                            if (row < 0)
                                row = 5 - 1;
                            if (col >= 5)
                                col = 0;
                            if (ms[row, col] == 0)
                            {
                                ms[row, col] = a + d;
                                d = d + 1;
                            }
                            else if (ms[row, col] != 0)
                            {
                                row = row + 2;
                                col--;
                                if (row >= 5)
                                    row = row - 5;
                                if (col < 0)
                                    col = col + 5;
                                ms[row, col] = a + d;
                                d = d + 1;
                            }
                            if (ms[4, 2] != 0)
                                break;
                        //}
                    }

                }
            }
            
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Answer1.SelectedText = "\t\t\t";
                    for (int j = 0; j < 5; j++)
                    {
                        //Thread.Sleep(interval);
                        Answer1.SelectedText = ms[i, j] + "\t";
                    }
                    Answer1.SelectedText = "\n";
                }
                else if(i==1)
                {
                    Answer2.SelectedText = "\t\t\t";
                    for (int j = 0; j < 5; j++)
                    {
                        //Thread.Sleep(interval);
                        Answer2.SelectedText = ms[i, j] + "\t";
                    }
                    Answer2.SelectedText = "\n";
                }
                else if(i==2)
                {
                    Answer3.SelectedText = "\t\t\t";
                    for (int j = 0; j < 5; j++)
                    {
                        Answer3.SelectedText = ms[i, j] + "\t";
                    }
                    Answer3.SelectedText = "\n";
                }
                else if(i==3)
                {
                    Answer4.SelectedText = "\t\t\t";
                    for (int j = 0; j < 5; j++)
                    {
                        //Thread.Sleep(interval);
                        Answer4.SelectedText = ms[i, j] + "\t";
                    }
                    Answer4.SelectedText = "\n";
                }
                else if(i==4)
                {
                    Answer5.SelectedText = "\t\t\t";
                    for (int j = 0; j < 5; j++)
                    {
                        //Thread.Sleep(interval);
                        Answer5.SelectedText = ms[i, j] + "\t";
                    }
                    Answer5.SelectedText = "\n";
                }

            }
            //ok.Enabled = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
