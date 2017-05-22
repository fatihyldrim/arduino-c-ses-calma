using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SesCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SerialPort serialPort1;
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1 = new SerialPort(comboBox1.Text, 9600);
            //serialPort1.PortName = comboBox1.Text; 
            serialPort1.Open();
            label3.Text = "Bağlandı..";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            label3.Text = "Ses Yok";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label3.Text = "Ses Var";
        }
    }
}
