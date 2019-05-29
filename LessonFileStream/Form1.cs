﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LessonFileStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string playName1 = "";
        string playName2 = "";
        string playName3 = "";
        string playName4 = "";

        string playAmount1 = "";
        string playAmount2 = "";
        string playAmount3 = "";
        string playAmount4 = "";

        int k = 1;
        private void AddButton_Click(object sender, EventArgs e)
        {
            

            switch (k)
            {
                case 1:
                    player1.Text = textBox1.Text;
                    playName1 = textBox1.Text;
                    money1.Text = "15000000";
                    playAmount1 = money1.Text;
                    textBox1.Clear();
                    k++;
                    break;
                case 2:
                    player2.Text = textBox1.Text;
                    playName2 = textBox1.Text;
                    money2.Text = "15000000";
                    playAmount2 = money2.Text;
                    textBox1.Clear();
                    k++;
                    break;
                case 3:
                    player3.Text = textBox1.Text;
                    playName3 = textBox1.Text;
                    money3.Text = "15000000";
                    playAmount3 = money3.Text;
                    textBox1.Clear();
                    k++;
                    break;
                case 4:
                    player4.Text = textBox1.Text;
                    playName4 = textBox1.Text;
                    money4.Text = "15000000";
                    playAmount4 = money4.Text;
                    textBox1.Clear();
                    k++;
                    break;
                default:
                    warning.Text = "В игре не может участвовать больше четырех человек!";
                    break;
            }
        }

        string path = "./text.txt";
        private void startPlay_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(path, true))
            {
                stream.WriteLine($"{playName1}:{playAmount1}" +
                    $"\n{playName2}:{playAmount2}" +
                    $"\n{playName3}:{playAmount3}" +
                    $"\n{playName4}:{playAmount4}");
            }
        }
        
        private void loading_Click(object sender, EventArgs e)
        {
            int i = 1;
            /*Dictionary<string, string> saveGame = new Dictionary<string, string>();
            List<string[]> arr = new List<string[]>();*/
            using (StreamReader reader = File.OpenText(path))
            {
                //string[] line = new string[2];

                do
                {
                    string line = reader.ReadLine();
                    switch (i)
                    {
                        case 1:
                            player1.Text = line[0].ToString();
                            money1.Text = line[1].ToString();
                            i++;
                            break;
                        case 2:
                            player2.Text = line[0].ToString();
                            money2.Text = line[1].ToString();
                            i++;
                            break;
                        case 3:
                            player3.Text = line[0].ToString();
                            money3.Text = line[1].ToString();
                            i++;
                            break;
                        case 4:
                            player4.Text = line[0].ToString();
                            money4.Text = line[1].ToString();
                            i++;
                            break;
                        default:
                            warning.Text = "Готово!";
                            break;
                    }
                }
                while (reader != null);
                    
            }
        }
    }
}