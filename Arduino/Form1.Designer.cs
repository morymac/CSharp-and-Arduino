namespace Arduino1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdgetinfo = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtinpin = new System.Windows.Forms.TextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdDigitalOut = new System.Windows.Forms.Button();
            this.cmdDiOut = new System.Windows.Forms.Button();
            this.txtOutPin = new System.Windows.Forms.TextBox();
            this.txtOutValue = new System.Windows.Forms.TextBox();
            this.txtinvalue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdgetinfo
            // 
            this.cmdgetinfo.Location = new System.Drawing.Point(12, 64);
            this.cmdgetinfo.Name = "cmdgetinfo";
            this.cmdgetinfo.Size = new System.Drawing.Size(139, 90);
            this.cmdgetinfo.TabIndex = 0;
            this.cmdgetinfo.Text = "Read Analog Sensor";
            this.cmdgetinfo.UseVisualStyleBackColor = true;
            this.cmdgetinfo.Click += new System.EventHandler(this.cmdgetinfo_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(278, 12);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(147, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "COM";
            // 
            // txtinpin
            // 
            this.txtinpin.Location = new System.Drawing.Point(12, 38);
            this.txtinpin.Name = "txtinpin";
            this.txtinpin.Size = new System.Drawing.Size(139, 20);
            this.txtinpin.TabIndex = 2;
            this.txtinpin.Text = "Pin";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(278, 64);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(147, 188);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(278, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 4;
            // 
            // cmdDigitalOut
            // 
            this.cmdDigitalOut.Location = new System.Drawing.Point(157, 64);
            this.cmdDigitalOut.Name = "cmdDigitalOut";
            this.cmdDigitalOut.Size = new System.Drawing.Size(115, 90);
            this.cmdDigitalOut.TabIndex = 5;
            this.cmdDigitalOut.Text = "Start Digital Out";
            this.cmdDigitalOut.UseVisualStyleBackColor = true;
            this.cmdDigitalOut.Click += new System.EventHandler(this.cmdDigitalOut_Click);
            // 
            // cmdDiOut
            // 
            this.cmdDiOut.Location = new System.Drawing.Point(157, 162);
            this.cmdDiOut.Name = "cmdDiOut";
            this.cmdDiOut.Size = new System.Drawing.Size(115, 90);
            this.cmdDiOut.TabIndex = 6;
            this.cmdDiOut.Text = "Start Analog Out";
            this.cmdDiOut.UseVisualStyleBackColor = true;
            // 
            // txtOutPin
            // 
            this.txtOutPin.Location = new System.Drawing.Point(157, 38);
            this.txtOutPin.Name = "txtOutPin";
            this.txtOutPin.Size = new System.Drawing.Size(115, 20);
            this.txtOutPin.TabIndex = 7;
            this.txtOutPin.Text = "Pin";
            // 
            // txtOutValue
            // 
            this.txtOutValue.Location = new System.Drawing.Point(157, 12);
            this.txtOutValue.Name = "txtOutValue";
            this.txtOutValue.Size = new System.Drawing.Size(115, 20);
            this.txtOutValue.TabIndex = 9;
            this.txtOutValue.Text = "Value";
            // 
            // txtinvalue
            // 
            this.txtinvalue.Location = new System.Drawing.Point(12, 12);
            this.txtinvalue.Name = "txtinvalue";
            this.txtinvalue.Size = new System.Drawing.Size(139, 20);
            this.txtinvalue.TabIndex = 10;
            this.txtinvalue.Text = "Value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 90);
            this.button1.TabIndex = 11;
            this.button1.Text = "Read Digital Sensor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtinvalue);
            this.Controls.Add(this.txtOutValue);
            this.Controls.Add(this.txtOutPin);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.cmdDiOut);
            this.Controls.Add(this.cmdDigitalOut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.txtinpin);
            this.Controls.Add(this.cmdgetinfo);
            this.Name = "Form1";
            this.Text = "FIRMATA and Arduino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdgetinfo;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtinpin;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdDigitalOut;
        private System.Windows.Forms.Button cmdDiOut;
        private System.Windows.Forms.TextBox txtOutPin;
        private System.Windows.Forms.TextBox txtOutValue;
        private System.Windows.Forms.TextBox txtinvalue;
        private System.Windows.Forms.Button button1;
    }
}

