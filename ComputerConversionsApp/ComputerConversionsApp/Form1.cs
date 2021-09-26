using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerConversionsApp
{
    public partial class Form1 : Form
    {
        int fromChoiceIndex = 0;
        int toChoiceIndex = 0;

        public Form1()
        {
            InitializeComponent();

            fromListBox.SelectedIndex = 0;
            toListBox.SelectedIndex = 1;
            outputTextBox.ForeColor = Color.Green;
            copiedText.Visible = false;
            outputTextBox.Text = "";
        }
        private void convertButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == "" || fromChoiceIndex == toChoiceIndex)
                return;
            
            //Match each button combination to it's according convert function
            if(fromChoiceIndex == 0 && toChoiceIndex == 1)
                outputTextBox.Text = ComputerConversions.DecBin(inputBox.Text);

            if (fromChoiceIndex == 1 && toChoiceIndex == 0)
                outputTextBox.Text = ComputerConversions.BinDec(inputBox.Text);

            if (fromChoiceIndex == 1 && toChoiceIndex == 2)
                outputTextBox.Text = ComputerConversions.BinHex(inputBox.Text);

            if (fromChoiceIndex == 2 && toChoiceIndex == 1)
                outputTextBox.Text = ComputerConversions.HexBin(inputBox.Text);

            if (fromChoiceIndex == 0 && toChoiceIndex == 2)
                outputTextBox.Text = ComputerConversions.DecHex(inputBox.Text);

            if (fromChoiceIndex == 2 && toChoiceIndex == 0)
                outputTextBox.Text = ComputerConversions.HexDec(inputBox.Text);
        }

        private void fromListBox_SelectedIndexChanged(object sender, EventArgs e) => fromChoiceIndex = fromListBox.SelectedIndex;

        private void toListBox_SelectedIndexChanged(object sender, EventArgs e) => toChoiceIndex = toListBox.SelectedIndex;

        private async void outputTextBox_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(outputTextBox.Text);
            copiedText.Visible = true;
            await Task.Delay(750);
            copiedText.Visible = false;
        }
    }
}
