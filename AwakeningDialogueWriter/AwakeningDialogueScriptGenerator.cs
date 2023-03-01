using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwakeningDialogueWriter
{
    public partial class AwakeningDialogueScriptGenerator : Form
    {
        public AwakeningDialogueScriptGenerator()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(richTextBox1.TextLength == 0)
            {
                return;
            }
            else
            {
                richTextBox1.Lines = richTextBox1.Lines.Take(richTextBox1.Lines.Length - 1).ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null || args.Text == "")
            {
                return;
            }
            else
            {
                switch (listBox1.SelectedIndex)
                {
                    case 0:
                        if(args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n\\n" + "\n$SetSpeaker(" + args.Text + ")\n$Synchronize");

                        }
                        break;
                    case 1:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$Emotion(" + args.Text + ")");

                        }
                        break;
                    case 2:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$Wait(" + args.Text + ")");

                        }
                        break;
                    case 3:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$FadeOut(" + args.Text + ")");

                        }
                        break;
                    case 4:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$FadeIn(" + args.Text + ")");

                        }
                        break;
                    case 5:
                        richTextBox1.AppendText("\n$Pause");
                        break;
                    case 6:
                        richTextBox1.AppendText("\n$Clear");
                        break;
                    case 7:
                        richTextBox1.AppendText("\n$DeleteSpeaker");
                        break;
                    case 8:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$PlaySoundEffect(" + args.Text + ")");

                        }
                        break;
                    case 9:
                        richTextBox1.AppendText("\n$ScrollIn");
                        break;
                    case 10:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$PlayVoice(" + args.Text + ")");

                        }
                        break;
                    case 11:
                        if (args.TextLength == 0)
                        {
                            return;
                        }
                        else
                        {
                            richTextBox1.AppendText("\n$PlayMusic(" + args.Text + ")");

                        }
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox2.TextLength == 0 && textBox3.TextLength == 0)
            {
                return;
            }
            else
            {
                richTextBox1.AppendText("$SetConversationType(1)\n" + "$LoadAssets(" + textBox2.Text + ", " + "3)\n"
                    + "$Wait(0)\n$LoadAssets(" + textBox3.Text + ", " + "7)");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(add.TextLength == 0)
            {
                return;
            }
            else
            {
                string[] words = add.Text.Split(' ');
                int i = 0;
                int j = 43;
                richTextBox1.AppendText("\n");
                foreach(string s in words){
                    if(j - s.Length >= 0)
                    {
                        richTextBox1.AppendText(s + ' ');
                        j -= s.Length;
                    }
                    else
                    {
                        i++;
                        if(i == 2)
                        {
                            richTextBox1.AppendText("\n$Pause\n$Clear");
                        }
                        j = 43;
                        richTextBox1.AppendText("\n" + s + ' ');
                        j -= s.Length;
                    }
                }
                richTextBox1.AppendText("\n$Pause");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Replace('-', '―');
            }
        }
    }
}
