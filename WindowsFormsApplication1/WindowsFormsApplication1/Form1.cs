using System;
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

        }

        private void _aboutBt_Click(object sender, EventArgs e)
        {
            _myAboutBox _ab = new _myAboutBox();
            _ab.Show();
        }

        private void _helloBt_Click(object sender, EventArgs e)
        {
            if (_nameBox.Text != "")
            {
                _msg.BackColor = Color.White;
                _msg.ForeColor = Color.White;
                _helloForm _hF = new _helloForm();
                _hF._hLabel.Text = "Приветствую вас, " + _nameBox.Text + "!\n" + "\n Сейчас программа ничего не умеет \n" + "\n Нажмите на меня, для закрытия этого окна!";
                _hF.Show();
            }
            else
            {
                _msg.Text = "Введите имя!!!";
                _msg.BackColor = Color.DarkOrange;
                _msg.ForeColor = Color.DarkRed;
            }
        }

        private void _exitBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
