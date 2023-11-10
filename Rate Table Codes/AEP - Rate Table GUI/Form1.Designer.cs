namespace AEP___Rate_Table_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelCdP = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxDir = new System.Windows.Forms.GroupBox();
            this.radioButtonCCW = new System.Windows.Forms.RadioButton();
            this.radioButtonCW = new System.Windows.Forms.RadioButton();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelCdV = new System.Windows.Forms.Panel();
            this.labelBack = new System.Windows.Forms.Label();
            this.groupBoxVel = new System.Windows.Forms.GroupBox();
            this.numericUpDownVel = new System.Windows.Forms.NumericUpDown();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.groupBoxPosInc = new System.Windows.Forms.GroupBox();
            this.textBoxPosInc = new System.Windows.Forms.TextBox();
            this.groupBoxPosAbs = new System.Windows.Forms.GroupBox();
            this.numericUpDownPos = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBoxCOM = new System.Windows.Forms.GroupBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonCdP = new System.Windows.Forms.Button();
            this.buttonCdV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCdP.SuspendLayout();
            this.groupBoxDir.SuspendLayout();
            this.panelCdV.SuspendLayout();
            this.groupBoxVel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVel)).BeginInit();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxPosInc.SuspendLayout();
            this.groupBoxPosAbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxCOM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panelCdP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 203);
            this.panel1.TabIndex = 0;
            // 
            // panelCdP
            // 
            this.panelCdP.BackColor = System.Drawing.Color.White;
            this.panelCdP.Controls.Add(this.buttonStop);
            this.panelCdP.Controls.Add(this.buttonSend);
            this.panelCdP.Controls.Add(this.groupBoxDir);
            this.panelCdP.Controls.Add(this.buttonRefresh);
            this.panelCdP.Controls.Add(this.panelCdV);
            this.panelCdP.Controls.Add(this.groupBoxPosInc);
            this.panelCdP.Controls.Add(this.groupBoxPosAbs);
            this.panelCdP.Location = new System.Drawing.Point(0, 0);
            this.panelCdP.Name = "panelCdP";
            this.panelCdP.Padding = new System.Windows.Forms.Padding(3);
            this.panelCdP.Size = new System.Drawing.Size(676, 203);
            this.panelCdP.TabIndex = 4;
            this.panelCdP.Visible = false;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(407, 152);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(107, 29);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Cancelar";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(407, 117);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(107, 29);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxDir
            // 
            this.groupBoxDir.Controls.Add(this.radioButtonCCW);
            this.groupBoxDir.Controls.Add(this.radioButtonCW);
            this.groupBoxDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDir.Location = new System.Drawing.Point(369, 16);
            this.groupBoxDir.Name = "groupBoxDir";
            this.groupBoxDir.Size = new System.Drawing.Size(183, 80);
            this.groupBoxDir.TabIndex = 0;
            this.groupBoxDir.TabStop = false;
            this.groupBoxDir.Text = "Dirección de Giro";
            // 
            // radioButtonCCW
            // 
            this.radioButtonCCW.AutoSize = true;
            this.radioButtonCCW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCCW.Location = new System.Drawing.Point(49, 48);
            this.radioButtonCCW.Name = "radioButtonCCW";
            this.radioButtonCCW.Size = new System.Drawing.Size(90, 19);
            this.radioButtonCCW.TabIndex = 1;
            this.radioButtonCCW.TabStop = true;
            this.radioButtonCCW.Text = "Counter CW";
            this.radioButtonCCW.UseVisualStyleBackColor = true;
            this.radioButtonCCW.CheckedChanged += new System.EventHandler(this.radioButtonCCW_CheckedChanged);
            // 
            // radioButtonCW
            // 
            this.radioButtonCW.AutoSize = true;
            this.radioButtonCW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCW.Location = new System.Drawing.Point(49, 25);
            this.radioButtonCW.Name = "radioButtonCW";
            this.radioButtonCW.Size = new System.Drawing.Size(80, 19);
            this.radioButtonCW.TabIndex = 0;
            this.radioButtonCW.TabStop = true;
            this.radioButtonCW.Text = "Clockwise";
            this.radioButtonCW.UseVisualStyleBackColor = true;
            this.radioButtonCW.CheckedChanged += new System.EventHandler(this.radioButtonCW_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(408, 116);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(107, 29);
            this.buttonRefresh.TabIndex = 6;
            this.buttonRefresh.Text = "Actualizar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelCdV
            // 
            this.panelCdV.BackColor = System.Drawing.Color.White;
            this.panelCdV.Controls.Add(this.labelBack);
            this.panelCdV.Controls.Add(this.groupBoxVel);
            this.panelCdV.Controls.Add(this.groupBoxTime);
            this.panelCdV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCdV.Location = new System.Drawing.Point(3, 3);
            this.panelCdV.Name = "panelCdV";
            this.panelCdV.Padding = new System.Windows.Forms.Padding(3);
            this.panelCdV.Size = new System.Drawing.Size(670, 197);
            this.panelCdV.TabIndex = 7;
            this.panelCdV.Visible = false;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Location = new System.Drawing.Point(3, 3);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(37, 13);
            this.labelBack.TabIndex = 4;
            this.labelBack.Text = "Volver";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // groupBoxVel
            // 
            this.groupBoxVel.Controls.Add(this.numericUpDownVel);
            this.groupBoxVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxVel.Location = new System.Drawing.Point(112, 107);
            this.groupBoxVel.Name = "groupBoxVel";
            this.groupBoxVel.Size = new System.Drawing.Size(184, 80);
            this.groupBoxVel.TabIndex = 3;
            this.groupBoxVel.TabStop = false;
            this.groupBoxVel.Text = "Velocidad (° / seg)";
            // 
            // numericUpDownVel
            // 
            this.numericUpDownVel.Location = new System.Drawing.Point(35, 33);
            this.numericUpDownVel.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownVel.Name = "numericUpDownVel";
            this.numericUpDownVel.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownVel.TabIndex = 2;
            this.numericUpDownVel.ValueChanged += new System.EventHandler(this.numericUpDownVel_ValueChanged);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.textBoxTime);
            this.groupBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTime.Location = new System.Drawing.Point(112, 16);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(186, 80);
            this.groupBoxTime.TabIndex = 2;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Tiempo (seg)";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(37, 33);
            this.textBoxTime.MaxLength = 3600;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(120, 22);
            this.textBoxTime.TabIndex = 0;
            this.textBoxTime.TextChanged += new System.EventHandler(this.textBoxTime_TextChanged);
            // 
            // groupBoxPosInc
            // 
            this.groupBoxPosInc.Controls.Add(this.textBoxPosInc);
            this.groupBoxPosInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPosInc.Location = new System.Drawing.Point(112, 16);
            this.groupBoxPosInc.Name = "groupBoxPosInc";
            this.groupBoxPosInc.Size = new System.Drawing.Size(186, 80);
            this.groupBoxPosInc.TabIndex = 2;
            this.groupBoxPosInc.TabStop = false;
            this.groupBoxPosInc.Text = "Posición Incremental (°)";
            // 
            // textBoxPosInc
            // 
            this.textBoxPosInc.Location = new System.Drawing.Point(37, 33);
            this.textBoxPosInc.MaxLength = 3600;
            this.textBoxPosInc.Name = "textBoxPosInc";
            this.textBoxPosInc.Size = new System.Drawing.Size(120, 22);
            this.textBoxPosInc.TabIndex = 0;
            this.textBoxPosInc.TextChanged += new System.EventHandler(this.textBoxRotInc_TextChanged);
            // 
            // groupBoxPosAbs
            // 
            this.groupBoxPosAbs.Controls.Add(this.numericUpDownPos);
            this.groupBoxPosAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPosAbs.Location = new System.Drawing.Point(112, 107);
            this.groupBoxPosAbs.Name = "groupBoxPosAbs";
            this.groupBoxPosAbs.Size = new System.Drawing.Size(184, 80);
            this.groupBoxPosAbs.TabIndex = 3;
            this.groupBoxPosAbs.TabStop = false;
            this.groupBoxPosAbs.Text = "Posición Absoluta (°)";
            // 
            // numericUpDownPos
            // 
            this.numericUpDownPos.Location = new System.Drawing.Point(35, 33);
            this.numericUpDownPos.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownPos.Name = "numericUpDownPos";
            this.numericUpDownPos.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownPos.TabIndex = 2;
            this.numericUpDownPos.ValueChanged += new System.EventHandler(this.numericUpDownPos_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agencia Espacial del Paraguay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(215, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADCS subsystem l Rate Table Control";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(155, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seleccionar método de control:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(501, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // groupBoxCOM
            // 
            this.groupBoxCOM.BackColor = System.Drawing.Color.Maroon;
            this.groupBoxCOM.Controls.Add(this.buttonActualizar);
            this.groupBoxCOM.Controls.Add(this.buttonConnect);
            this.groupBoxCOM.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxCOM.Controls.Add(this.comboBoxCOMPort);
            this.groupBoxCOM.Controls.Add(this.buttonDisconnect);
            this.groupBoxCOM.Controls.Add(this.label5);
            this.groupBoxCOM.Controls.Add(this.label4);
            this.groupBoxCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCOM.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCOM.ForeColor = System.Drawing.Color.White;
            this.groupBoxCOM.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCOM.Name = "groupBoxCOM";
            this.groupBoxCOM.Size = new System.Drawing.Size(327, 202);
            this.groupBoxCOM.TabIndex = 1;
            this.groupBoxCOM.TabStop = false;
            this.groupBoxCOM.Text = "Serial COM";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActualizar.ForeColor = System.Drawing.Color.Black;
            this.buttonActualizar.Location = new System.Drawing.Point(70, 128);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(92, 30);
            this.buttonActualizar.TabIndex = 7;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.Color.Black;
            this.buttonConnect.Location = new System.Drawing.Point(166, 128);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(92, 30);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Conectar";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(167, 87);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(90, 29);
            this.comboBoxBaudRate.TabIndex = 5;
            // 
            // comboBoxCOMPort
            // 
            this.comboBoxCOMPort.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCOMPort.FormattingEnabled = true;
            this.comboBoxCOMPort.Location = new System.Drawing.Point(167, 53);
            this.comboBoxCOMPort.Name = "comboBoxCOMPort";
            this.comboBoxCOMPort.Size = new System.Drawing.Size(90, 29);
            this.comboBoxCOMPort.TabIndex = 4;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.Black;
            this.buttonDisconnect.Location = new System.Drawing.Point(70, 128);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(92, 30);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Desconectar";
            this.buttonDisconnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(74, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Baud Rate:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(74, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "COM Port:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 203);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel1.Controls.Add(this.buttonCdP);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCOM);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.Controls.Add(this.buttonCdV);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(676, 208);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonCdP
            // 
            this.buttonCdP.AutoSize = true;
            this.buttonCdP.BackColor = System.Drawing.Color.Transparent;
            this.buttonCdP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCdP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCdP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCdP.ForeColor = System.Drawing.Color.Black;
            this.buttonCdP.Location = new System.Drawing.Point(3, 3);
            this.buttonCdP.Name = "buttonCdP";
            this.buttonCdP.Size = new System.Drawing.Size(327, 202);
            this.buttonCdP.TabIndex = 0;
            this.buttonCdP.Text = "Control de Posición";
            this.buttonCdP.UseVisualStyleBackColor = false;
            this.buttonCdP.Click += new System.EventHandler(this.buttonCdP_Click);
            // 
            // buttonCdV
            // 
            this.buttonCdV.AutoSize = true;
            this.buttonCdV.BackColor = System.Drawing.Color.Transparent;
            this.buttonCdV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCdV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCdV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCdV.ForeColor = System.Drawing.Color.Black;
            this.buttonCdV.Location = new System.Drawing.Point(3, 3);
            this.buttonCdV.Name = "buttonCdV";
            this.buttonCdV.Size = new System.Drawing.Size(333, 202);
            this.buttonCdV.TabIndex = 1;
            this.buttonCdV.Text = "Control de Velocidad";
            this.buttonCdV.UseVisualStyleBackColor = false;
            this.buttonCdV.Click += new System.EventHandler(this.buttonCdV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 411);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AEP - Rate Table Control GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCdP.ResumeLayout(false);
            this.groupBoxDir.ResumeLayout(false);
            this.groupBoxDir.PerformLayout();
            this.panelCdV.ResumeLayout(false);
            this.panelCdV.PerformLayout();
            this.groupBoxVel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVel)).EndInit();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxPosInc.ResumeLayout(false);
            this.groupBoxPosInc.PerformLayout();
            this.groupBoxPosAbs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxCOM.ResumeLayout(false);
            this.groupBoxCOM.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCdP;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonCdP;
        private System.Windows.Forms.Button buttonCdV;
        private System.Windows.Forms.GroupBox groupBoxCOM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCOMPort;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.GroupBox groupBoxDir;
        private System.Windows.Forms.RadioButton radioButtonCCW;
        private System.Windows.Forms.RadioButton radioButtonCW;
        private System.Windows.Forms.GroupBox groupBoxPosInc;
        private System.Windows.Forms.NumericUpDown numericUpDownPos;
        private System.Windows.Forms.GroupBox groupBoxPosAbs;
        private System.Windows.Forms.TextBox textBoxPosInc;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Panel panelCdV;
        private System.Windows.Forms.GroupBox groupBoxVel;
        private System.Windows.Forms.NumericUpDown numericUpDownVel;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label labelBack;
    }
}

