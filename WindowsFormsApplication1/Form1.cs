﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var font = FontFamily.Families;
            
            foreach (FontFamily f in font)
            {

                comFont.Items.Add(f.Name);
            }

    

        }

        



            void ChangeFont()
            {

                if(comFont.SelectedIndex <0)
                {
                    return;
                }

                FontStyle fs = FontStyle.Regular;

                if(chkBold.Checked)
                {
                    fs |= FontStyle.Bold;
                }


                if(chkItalic.Checked)
                {
                    fs |= FontStyle.Italic;
                }

                txtMessage.Font = new Font((string)comFont.SelectedItem, 10, fs);

            }

                enum Sports : int
                {
            //1,2,3
                }
        private Sports selectedSports;








        private void comFont_SelectedIndexChanged(object sender, EventArgs e)
        {
        ChangeFont();
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {

            ChangeFont();
        
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        
        }

        private void rdoSoccer_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)0;
            lblSports.Text = selectedSports + "를 선택";

        }

        private void rdoBaseball_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)1;
            lblSports.Text = selectedSports + "를 선택";
        }

        private void rdoBasketball_CheckedChanged(object sender, EventArgs e)
        {
            this.selectedSports = (Sports)2;
            lblSports.Text = selectedSports + "를 선택";
        }

        private void trb1_Scroll(object sender, EventArgs e)
        {
            trb1.Maximum = 100;
            prb1.Maximum = 100;
            prb1.Value = trb1.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            prb1.Maximum = int.Parse(textBox1.Text);
            prb1.Step = int.Parse(textBox1.Text) / 100;
            for(int i = 0; i<= int.Parse(textBox1.Text);
                i++)
                {prb1.Value = i;
            }
        }

        
    }

        


    
}
