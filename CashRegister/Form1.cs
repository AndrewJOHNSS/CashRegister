using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double flagprice = 5;
        double hockeyprice = 9;
        double iglooprice = 20;
        int numofFlag = 0;
        int numofHockey = 0;
        int numofIgloo = 0;
        double fullflagprice;
        double fullhockeyprice;
        double fulliglooprice;
        double taxrate = 0.13;
        double subtotal = 0;
        double taxamount = 0;
        double totalprice = 0;
        int numofTend = 0;
        double changeleft;
        SoundPlayer player = new SoundPlayer(Properties.Resources.Cash_Register_Cha_Ching_SoundBible_com_184076484);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.Cha_Ching_Register_Muska666_173262285);
        SoundPlayer player3 = new SoundPlayer(Properties.Resources.Bleep_SoundBible_com_1927126940);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reciptcanadashopLabel.ForeColor = Color.DarkGray;
            ordernumberLabel.ForeColor = Color.DarkGray;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numofFlag = Convert.ToInt32(flagtextBox.Text);
                numofHockey = Convert.ToInt32(hockeytextBox.Text);
                numofIgloo = Convert.ToInt32(iglootextBox.Text);
                fullflagprice = flagprice * numofFlag;
                fullhockeyprice = hockeyprice * numofHockey;
                fulliglooprice = iglooprice * numofIgloo;
                subtotal = fulliglooprice + fullhockeyprice + fullflagprice;
                taxamount = taxrate * subtotal;
                totalprice = subtotal + taxamount;
                subtotalOutput.Text = $"{subtotal}";
                subtotalOutput.Text = subtotal.ToString("C");
                taxOutput.Text = $"{taxamount}";
                taxOutput.Text = taxamount.ToString("C");
                totalOutput.Text = $"{totalprice}";
                totalOutput.Text = totalprice.ToString("C");
            }

            catch
            {
                subtotalOutput.Text = "input error eh?";
                taxOutput.Text = "input error eh?";
                totalOutput.Text = "input error eh?";
                hockeytextBox.Text = "";
                flagtextBox.Text = "";
                iglootextBox.Text = "";
                return;
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                numofTend = Convert.ToInt32(tenderedtextBox.Text);
                changeleft = numofTend - totalprice;
                changeOutput.Text = $"{changeleft}";
                changeOutput.Text = changeleft.ToString("C");
            }
            catch
            {
                changeOutput.Text = "error eh?";
                tenderedtextBox.Text = "";
                return;
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            reciptcanadashopLabel.ForeColor = Color.White;
            ordernumberLabel.ForeColor = Color.White;
            player.Play();
            Refresh();
            Thread.Sleep(1100);
            player3.Play();
            receiptflagLabel.Text = $"{flagprice}";
            receiptflagLabel.Text = fullflagprice.ToString("C");
            numofflagreciptLabel.Text = $"= Flag X{numofFlag}";
            receiptflagLabel.ForeColor = Color.White;
            numofflagreciptLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(500);
            player3.Play();
            receipthockeyLabel.Text = $"{hockeyprice}";
            receipthockeyLabel.Text = fullhockeyprice.ToString("C");
            numofhockeyreciptLabel.Text = $"= Hockey Sticks X{numofHockey}";
            receipthockeyLabel.ForeColor = Color.White;
            numofhockeyreciptLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(500);
            player3.Play();
            receiptiglooLabel.Text = $"{iglooprice}";
            receiptiglooLabel.Text = fulliglooprice.ToString("C");
            numofiglooreciptLabel.Text = $"= Igloos X{numofIgloo}";
            receiptiglooLabel.ForeColor = Color.White;
            numofiglooreciptLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(500);
            player3.Play();
            subtotalreceiptLabel.Text = $"Subtotal: {subtotal}";
            subtotalreceiptLabel.Text = subtotal.ToString("Subtotal: $ 0.00");
            taxreceiptLabel.Text = $"Tax: {taxamount}";
            taxreceiptLabel.Text = taxamount.ToString("Tax: $ 0.00");
            totalreceiptLabel.Text = $"Total: {totalprice}";
            totalreceiptLabel.Text = totalprice.ToString("Total: $ 0.00");
            subtotalreceiptLabel.ForeColor = Color.White;
            taxreceiptLabel.ForeColor = Color.White;
            totalreceiptLabel.ForeColor = Color.White;
            Refresh();
            Thread.Sleep(500);
            player3.Play();
            tenderedreceiptLabel.Text = $"Tendered: {numofTend}";
            tenderedreceiptLabel.Text = numofTend.ToString("Tendered: $ 0.00");
            changereceiptLabel.Text = $"Change: {changeleft}";
            changereceiptLabel.Text = changeleft.ToString("Change: $ 0.00");
            tenderedreceiptLabel.ForeColor = Color.White;
            changereceiptLabel.ForeColor = Color.White;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void receiptiglooLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void receipthockeyLabel_Click(object sender, EventArgs e)
        {

        }

        private void ordernumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            player2.Play();
            reciptcanadashopLabel.ForeColor = Color.DarkGray;
            ordernumberLabel.ForeColor = Color.DarkGray;
            receiptflagLabel.ForeColor = Color.DarkGray;
            numofflagreciptLabel.ForeColor = Color.DarkGray;
            receipthockeyLabel.ForeColor = Color.DarkGray;
            numofhockeyreciptLabel.ForeColor = Color.DarkGray;
            receiptiglooLabel.ForeColor = Color.DarkGray;
            numofiglooreciptLabel.ForeColor = Color.DarkGray;
            subtotalreceiptLabel.ForeColor = Color.DarkGray;
            taxreceiptLabel.ForeColor = Color.DarkGray;
            totalreceiptLabel.ForeColor = Color.DarkGray;
            tenderedreceiptLabel.ForeColor = Color.DarkGray;
            changereceiptLabel.ForeColor = Color.DarkGray;
            subtotalOutput.Text = "";
            totalOutput.Text = "";
            taxOutput.Text = "";
            tenderedtextBox.Text = "";
            changeOutput.Text = "";
            iglootextBox.Text = "";
            hockeytextBox.Text = "";
            flagtextBox.Text = "";
            fullflagprice = 0;
            fullhockeyprice = 0;
            fulliglooprice = 0;
            numofFlag = 0;
            numofHockey = 0;
            numofIgloo = 0;
            subtotal = 0;
            taxamount = 0;
            totalprice = 0;
            numofTend = 0;
            changeleft = 0;
            flagprice = 5;
            hockeyprice = 9;
            iglooprice = 20;
            player3.Play();
            Refresh();
            Thread.Sleep(100);
        }

        private void canadashopLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void changeLabel_Click(object sender, EventArgs e)
        {
            subtotalOutput.Text = "eh? easteregg?";
            totalOutput.Text = "eh? easteregg?";
            taxOutput.Text = "eh? easteregg?";
            tenderedtextBox.Text = "eh? easteregg?";
            changeOutput.Text = "eh? easteregg?";
            iglootextBox.Text = "eh? easteregg?";
            hockeytextBox.Text = "eh? easteregg?";
            flagtextBox.Text = "eh? easteregg?";
        }
    }
}
