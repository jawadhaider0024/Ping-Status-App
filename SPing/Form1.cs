using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;


namespace SPing
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
        public void button1_Click(object sender, EventArgs e)
        {
            string Ip;
            Ip = "8.8.8.8";
            //ip2 = "192.168.1.1";
            textBox1.Text = Ip;
            //textBox2.Text = ip2;
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(Ip);
            //PingReply reply2 = pingSender.Send(ip2);

            if (reply.Status == IPStatus.Success)
            {
                label1.Text = "I";
            }
            else
            {
                label1.Text = "O";
            }
        }
            //if (reply2.Status == IPStatus.Success)
            //{
            //    label2.Text = "I";
            //}
            //else
            //{
            //    label2.Text = "O";
            //}  
     
                                                                    //public void SPing(string Ip)
                                                                    //{
                                                                    //   
                                                                    //    Ip = "8.8.8.8";
                                                                      //  textBox1.Text = Ip;
                                                                    //    Ping pingSender = new Ping();
                                                                    //    PingReply reply = pingSender.Send(Ip);
                                                                    //    if (reply.Status == IPStatus.Success)
                                                                    //    {
                                                                    //        textBox2.Text = "I";
                                                                    //    }
                                                                    //    else
                                                                    //    {
                                                                    //        textBox2.Text = "O";
                                                                    //    }
                                                                    //}
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
