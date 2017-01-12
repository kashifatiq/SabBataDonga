using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SabBataDonga
{
    public partial class Form1 : Form
    {
        string dummyRequest = "Fahad bhai jawab bata dain, apko apki bachi ki qasam";
        int Counter = 0;
        String _answer = "";
        public Form1()
        {
            InitializeComponent();
        }
        bool StartRecording = false;
        private void txtJadoo_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtJadoo_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btnNayaSawal_Click(object sender, EventArgs e)
        {
            txtJadoo.Text = "";
            StartRecording = false;
            lblAnswer.Text = "";
            Counter = 0;
            _answer = "";
            txtQuestion.Text = "";
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            if (txtJadoo.Text.Trim() == "")
            {
                MessageBox.Show("Pehle bhai se request karo");
                txtJadoo.Focus();
            }
            else if (txtQuestion.Text.Trim() == "")
            {
                MessageBox.Show("Sawal Abbu Likhainge???????", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuestion.Focus();
            }
            else
            {
                if (_answer == "")
                    lblAnswer.Text = "Acha mushkil sawal. beta kal jawab donga iska";
                else
                    lblAnswer.Text = _answer.Replace(".", "");
            }
        }

        private void txtJadoo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtJadoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Contains(".")) // .
            {
                //e.Handled = true;
                if (StartRecording == false)
                    StartRecording = true;
                else
                    StartRecording = false;
            }
            if (StartRecording == true && !e.KeyChar.ToString().Contains("."))
            {
                _answer = _answer + e.KeyChar.ToString();
                //e.Handled = true;
            }
            
            if (Counter < dummyRequest.Length)
            {
                e.KeyChar = dummyRequest[Counter];
                Counter = Counter + 1;
            }
        }
    }
}
