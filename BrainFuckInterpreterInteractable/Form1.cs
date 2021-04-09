using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainFuckInterpreterInteractable
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string getTextFromInput()
        {
            return input.Text;
        }

        private void start_Click(object sender, EventArgs e)
        {
            console.Items.Clear();
            console.Items.Add("");

            List<int> mem = new List<int>();
            mem.Add(0);

            string file = getTextFromInput();
            int memIndex = 0;
            int currentLine = 0;

            for (int i = 0; i < file.Length; i++)
            {
                char c = file.ToCharArray()[i];

                switch (c)
                {
                    case '>':
                        memIndex++;
                        if (memIndex >= mem.Count)
                        {
                            mem.Add(0);
                        }
                        break;
                    case '<':
                        memIndex--;
                        if (memIndex < 0)
                        {
                            memIndex = 0;
                            mem.Insert(0, 0);
                        }
                        break;
                    case '+':
                        mem[memIndex]++;
                        if (mem[memIndex] > 255)
                        {
                            mem[memIndex] = 0;
                        }
                        break;
                    case '-':
                        mem[memIndex]--;
                        if (mem[memIndex] < 0)
                        {
                            mem[memIndex] = 255;
                        }
                        break;
                    case '.':
                        if(mem[memIndex] == 10)
                        {
                            currentLine++;
                            console.Items.Add("");
                        } else
                        {
                            char letter = Convert.ToChar(mem[memIndex]);
                            string line = (string)console.Items[currentLine];
                            console.Items[currentLine] = (line + letter.ToString());
                        }
                        break;
                    case ',':
                        char key = Interaction.InputBox("Input").ToCharArray()[0];
                        mem[memIndex] = (int)key;
                        break;
                    case '[':
                        if (mem[memIndex] == 0)
                        {
                            int open = 0;
                            i++;
                            while (i < file.Length)
                            {
                                if (file[i] == ']' && open == 0)
                                {
                                    break;
                                }
                                else if (file[i] == '[')
                                {
                                    open++;
                                }
                                else if (file[i] == ']')
                                {
                                    open--;
                                }
                                i++;
                            }
                        }
                        break;
                    case ']':
                        if (mem[memIndex] != 0)
                        {
                            int closed = 0;
                            i--;
                            while (i >= 0)
                            {
                                if (file[i] == '[' && closed == 0)
                                {
                                    break;
                                }
                                else if (file[i] == '[')
                                {
                                    closed--;
                                }
                                else if (file[i] == ']')
                                {
                                    closed++;
                                }
                                i--;
                            }
                        }
                        break;
                }
            }

            Console.WriteLine("");
            foreach (int num in mem)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
            Console.WriteLine("Characters: " + file.Length);
        }
    }
}
