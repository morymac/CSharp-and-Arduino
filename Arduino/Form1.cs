using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sharpduino;


namespace Arduino1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdgetinfo_Click(object sender, EventArgs e)
        {
            string port = txtPort.Text;
            int pin = Convert.ToInt32(txtinpin.Text);
            ArduinoStuff.RASensor(pin, port);

        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            string port = txtPort.Text;
            var Arduino = new ArduinoUno(port);
            textBox1.BackColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pin = Convert.ToInt32(txtinpin.Text);
            string port = txtPort.Text;
            var Arduino = new ArduinoUno(port);


        }

        private void cmdDigitalOut_Click(object sender, EventArgs e)
        {

        }



    }


}
