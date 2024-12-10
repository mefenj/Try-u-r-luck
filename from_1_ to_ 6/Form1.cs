using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from_1__to__6
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font currentFont = button1.Font;
            Font newfont = new Font(currentFont, currentFont.Style | FontStyle.Strikeout);
            Form2 Newform = new Form2();
            Newform.Show();
            button1.Font = newfont;
        }

        private void one_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox one = this.one;
            CheckBox two = this.two;
            CheckBox three = this.three;
            CheckBox four = this.four;
            CheckBox five = this.five;
            CheckBox six = this.six;

            List<CheckBox> chekboxes = new List<CheckBox>() {one, two, three, four, five, six};
            if (chekboxes.Any(cb => cb.Checked))
            {
                foreach(var cb in chekboxes)
                {
                    cb.Enabled = false;
                }
                fdice.Enabled = true;
                sdice.Enabled = true;
                tdice.Enabled = true;
            }
        }

        private void resultat(object sender, EventArgs e)
        {
            if (one.Enabled == false & fdice.Enabled == false & sdice.Enabled == false & tdice.Enabled == false)
            {
                res.Enabled = true;
            }
            if(label2.Text != string.Empty)
            {
                resetButton.Enabled = true;
            }
        }
        private void reset_btn(object sender, EventArgs e)
        {
            one.Checked = false;
            two.Checked = false;
            three.Checked = false;
            four.Checked = false;
            five.Checked = false;
            six.Checked = false;
            one.Enabled = true;
            two.Enabled = true;
            three.Enabled = true;
            four.Enabled = true;
            five.Enabled = true;
            six.Enabled = true;
            l1dice.Text = string.Empty;
            l2dice.Text = string.Empty;
            l3dice.Text = string.Empty;
            fdice.Enabled = false;
            sdice.Enabled = false;
            tdice.Enabled = false;
            res.Enabled = false;
            label2.Text = string.Empty;
            resetButton.Enabled = false;
        }

        private void fdice_Click(object sender, EventArgs e)
        {
            int r1number = random.Next(1, 7);
            l1dice.Text = r1number.ToString();
            fdice.Enabled = false;
        }

        private void sdice_Click(object sender, EventArgs e)
        {
            int r2number = random.Next(1, 7);
            l2dice.Text = r2number.ToString();
            sdice.Enabled = false;
        }

        private void tdice_Click(object sender, EventArgs e)
        {
            int r3number = random.Next(1, 7);
            l3dice.Text = r3number.ToString();
            tdice.Enabled = false;
            
        }

        private void res_Click(object sender, EventArgs e)
        {
            int l1n = Convert.ToInt32(l1dice.Text);
            int l2n = Convert.ToInt32(l2dice.Text);
            int l3n = Convert.ToInt32(l3dice.Text);
            CheckBox[] checkcheck = {one, two, three, four, five, six };
            var checke = checkcheck.FirstOrDefault(x => x.Checked);
            int valuev = Convert.ToInt32(checke.Text);
            if(valuev == l1n || valuev == l2n || valuev == l3n)
            {
                label2.Text = "Ты победил!";
            }
            else if(valuev == l1n & l1n == l2n & l2n == l3n)
            {
                label2.Text = "Мега победа! Поздравляю!";
            }
            else
            {
                label2.Text = "Ты проиграл!";
            }
        }
    }
}
