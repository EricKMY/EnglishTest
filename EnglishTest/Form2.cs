using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        const string ABOUT_DICTIONARY = "Total 1000 words in the dictionary.";
        const string ABOUT_SPELLING1 = "Spelling Checker 1000 Words";
        const string ABOUT_SPELLING2 = "All rights reserved";
        const string ABOUT_SPELLING3 = "Spirit Du";
        LinkLabel _link1 = new LinkLabel();
        LinkLabel _link2 = new LinkLabel();
        LinkLabel _link3 = new LinkLabel();
        const string LINK1 = "SDT";
        const string LINK2 = "CSIE";
        const string LINK3 = "NTUT";
        const char CHANGE_LINE = '\n';

        //總題數選項
        private void ClickMenuTotalTen(object sender, EventArgs e)
        {
            _numericUpDown1.Value = 10;
        }

        //總題數選項
        private void ClickMenuTotalTwenty(object sender, EventArgs e)
        {
            _numericUpDown1.Value = 20;
        }

        //總題數選項
        private void ClickMenuTotalFifty(object sender, EventArgs e)
        {
            _numericUpDown1.Value = 50;
        }

        //題型選項
        private void ClickMenuFillBlank(object sender, EventArgs e)
        {
            _comboBox1.SelectedIndex = 0;
        }

        //題型選項
        private void ClickMenuMultipleChoice(object sender, EventArgs e)
        {
            _comboBox1.SelectedIndex = 1;
        }

        //題型選項
        private void ClickMenuTypeRandom(object sender, EventArgs e)
        {
            _comboBox1.SelectedIndex = 2;
        }

        //exit
        private void ClickMenuExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //字典介紹
        private void ClickMenuAboutDictionary(object sender, EventArgs e)
        {
            MessageBox.Show(ABOUT_DICTIONARY);
        }

        //其他介紹
        private void ClickMenuAboutSpelling(object sender, EventArgs e)
        {
            _link1.Text = LINK1;
            _link2.Text = LINK2;
            _link3.Text = LINK3;
            MessageBox.Show(ABOUT_SPELLING1 + CHANGE_LINE + _link1.Text + "@" + _link2.Text + "," + _link3.Text + CHANGE_LINE + ABOUT_SPELLING2 + CHANGE_LINE + ABOUT_SPELLING3);
        }
    }
}