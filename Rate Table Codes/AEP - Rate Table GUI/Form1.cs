using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace AEP___Rate_Table_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string m = "";
        private string d = ""; // Declare these variables at the class level
        private string r = "";
        private string R = "";
        private string t = "";
        private string v = "";
        private bool buttonCdPClicked = false;
        private bool buttonCdVClicked = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                panelCdP.Visible = false;
                panelCdV.Visible = false;
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                radioButtonCW.Enabled = false;
                radioButtonCCW.Enabled = false;
                numericUpDownPos.Enabled= false;
                numericUpDownVel.Enabled = false;
                buttonSend.Enabled = false;
                buttonStop.Enabled = false;
                textBoxPosInc.Enabled = false;
                textBoxTime.Enabled = false;
                comboBoxBaudRate.Text = "115200";

                string[] portList = SerialPort.GetPortNames();
                comboBoxCOMPort.Items.AddRange(portList);
                comboBoxBaudRate.Items.Add(9600);
                comboBoxBaudRate.Items.Add(115200);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonCdV_Click(object sender, EventArgs e)
        {
            panelCdP.Visible = true; 
            panelCdV.Controls.Add(this.groupBoxDir);
            panelCdV.Controls.Add(this.buttonSend);
            panelCdV.Controls.Add(this.buttonRefresh);
            panelCdV.Controls.Add(this.buttonStop);
            panelCdV.Controls.Add(this.labelBack);
            buttonCdP.Visible = true;
            splitContainer1.Panel2.Controls.Add(this.groupBoxCOM);
            groupBoxCOM.Visible = true;
            panelCdV.Visible = true;
            buttonCdV.Visible = false;
            buttonCdPClicked = false;
            buttonCdVClicked = true;
    }

        private void buttonCdP_Click(object sender, EventArgs e)
        {
            panelCdP.Controls.Add(this.groupBoxDir);
            panelCdP.Controls.Add(this.buttonSend);
            panelCdP.Controls.Add(this.buttonRefresh);
            panelCdP.Controls.Add(this.buttonStop);
            panelCdP.Controls.Add(this.labelBack);
            panelCdV.Visible = false;
            buttonCdV.Visible = true;
            splitContainer1.Panel1.Controls.Add(this.groupBoxCOM);
            groupBoxCOM.Visible = true;
            panelCdP.Visible = true;
            buttonCdP.Visible = false;
            buttonCdPClicked = true;
            buttonCdVClicked = false;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxCOMPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                serialPort1.Open();
                this.groupBoxCOM.BackColor = System.Drawing.Color.ForestGreen;
                radioButtonCW.Enabled = true;
                radioButtonCCW.Enabled = true;
                buttonDisconnect.Enabled = true;
                buttonSend.Enabled = true;
                textBoxPosInc.Enabled = true;
                textBoxTime.Enabled = true;
                numericUpDownPos.Enabled = true;
                numericUpDownVel.Enabled = true;
                buttonConnect.Enabled = false;
                comboBoxBaudRate.Enabled = false;
                comboBoxCOMPort.Enabled = false;
                if (serialPort1.IsOpen)
                {
                    buttonActualizar.Visible = false;
                }
                else
                    buttonActualizar.Visible = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            string[] portList = SerialPort.GetPortNames();
            comboBoxCOMPort.Items.Clear();
            comboBoxCOMPort.Items.AddRange(portList);
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
             serialPort1.Close();
             groupBoxCOM.BackColor = System.Drawing.Color.Maroon;
             buttonActualizar.Visible = true;
             buttonConnect.Enabled = true;
             comboBoxBaudRate.Enabled = true;
             comboBoxCOMPort.Enabled = true;
             buttonDisconnect.Enabled = false;
            }
             catch (Exception error)
             {
                 MessageBox.Show(error.Message);
             }
        }

        private void textBoxRotInc_TextChanged(object sender, EventArgs e)
        {
            r = "r" + textBoxPosInc.Text;
        }

        private void numericUpDownPos_ValueChanged(object sender, EventArgs e)
        {
            R = "R" + numericUpDownPos.Value;
            r = "r0" + R;
        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {
            t = "t" + textBoxTime.Text;
        }

        private void numericUpDownVel_ValueChanged(object sender, EventArgs e)
        {
            v = "v" + numericUpDownVel.Value;
        }

        private void radioButtonCW_CheckedChanged(object sender, EventArgs e)
        {
            d = "d" + 0;
        }

        private void radioButtonCCW_CheckedChanged(object sender, EventArgs e)
        {
            d = "d" + 1;
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                buttonSend.Visible = false;
                buttonStop.Enabled = true;

                // Check if the serial port is open
                if (serialPort1.IsOpen)
                {
                    // Assuming 'd', 'r', 't' and 'v' are declared and have values assigned
                    if (buttonCdPClicked == true)
                    {
                        m = d + r;
                    }
                    else if (buttonCdVClicked == true)
                    {
                        m = d + t + v;
                    }

                    // Write the string to the serial port
                    serialPort1.Write(m);

                    // MessageBox.Show("Datos enviados: " + m);
                }
                else
                {
                    MessageBox.Show("Conectar puerto COM");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the serial port is open
                if (serialPort1.IsOpen)
                {
                    // Assuming 'd', 'r', 't' and 'v' are declared and have values assigned
                    if (buttonCdPClicked == true)
                    {
                        m = d + r;
                    }
                    else if (buttonCdVClicked == true)
                    {
                        m = d + t + v;
                    }

                    // Write the string to the serial port
                    serialPort1.Write(m);

                    // MessageBox.Show("Datos enviados: " + m);
                }
                else
                {
                    MessageBox.Show("Conectar puerto COM");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonSend.Visible = true;
            buttonStop.Enabled = false;
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("d0r0t0v0");
                buttonSend.Enabled = true;
            }
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            m = "d0r0t0v0";
            serialPort1.Write(m); 
            serialPort1.Close();
            groupBoxCOM.BackColor = System.Drawing.Color.Maroon;
            buttonActualizar.Visible = true;
            buttonConnect.Enabled = true;
            comboBoxBaudRate.Enabled = true;
            comboBoxCOMPort.Enabled = true;
            buttonDisconnect.Enabled = false;
            panelCdV.Visible = false;
            panelCdP.Visible = false;
            groupBoxCOM.Visible = false;
            buttonCdP.Visible = true;
            buttonCdV.Visible = true;
            radioButtonCW.Enabled = false;
            radioButtonCCW.Enabled = false;
            buttonDisconnect.Enabled = false;
            buttonSend.Enabled = false;
            textBoxPosInc.Enabled = false;
            textBoxTime.Enabled = false;
            numericUpDownPos.Enabled = false;
            numericUpDownVel.Enabled = false;
            buttonConnect.Enabled = true;
            comboBoxBaudRate.Enabled = true;
            comboBoxCOMPort.Enabled = true;
        }
    }
}
