namespace Modbus_WindowTest
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_SerialPort_Name = new System.Windows.Forms.Label();
            this.ComboBox_SerialPort = new System.Windows.Forms.ComboBox();
            this.ComboBox_Bote = new System.Windows.Forms.ComboBox();
            this.Label_Bote = new System.Windows.Forms.Label();
            this.ComboBox_Check = new System.Windows.Forms.ComboBox();
            this.Label_Check = new System.Windows.Forms.Label();
            this.ComboBox_Stop = new System.Windows.Forms.ComboBox();
            this.Label_Stop = new System.Windows.Forms.Label();
            this.ComboBox_Data = new System.Windows.Forms.ComboBox();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.TextBox_Data1 = new System.Windows.Forms.TextBox();
            this.TextBox_Data2 = new System.Windows.Forms.TextBox();
            this.TextBox_Data3 = new System.Windows.Forms.TextBox();
            this.Button_Write = new System.Windows.Forms.Button();
            this.Button_Read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_SerialPort_Name
            // 
            this.Label_SerialPort_Name.AutoSize = true;
            this.Label_SerialPort_Name.Location = new System.Drawing.Point(13, 13);
            this.Label_SerialPort_Name.Name = "Label_SerialPort_Name";
            this.Label_SerialPort_Name.Size = new System.Drawing.Size(53, 12);
            this.Label_SerialPort_Name.TabIndex = 0;
            this.Label_SerialPort_Name.Text = "串口号：";
            // 
            // ComboBox_SerialPort
            // 
            this.ComboBox_SerialPort.FormattingEnabled = true;
            this.ComboBox_SerialPort.Location = new System.Drawing.Point(72, 10);
            this.ComboBox_SerialPort.Name = "ComboBox_SerialPort";
            this.ComboBox_SerialPort.Size = new System.Drawing.Size(76, 20);
            this.ComboBox_SerialPort.TabIndex = 1;
            // 
            // ComboBox_Bote
            // 
            this.ComboBox_Bote.FormattingEnabled = true;
            this.ComboBox_Bote.Location = new System.Drawing.Point(224, 10);
            this.ComboBox_Bote.Name = "ComboBox_Bote";
            this.ComboBox_Bote.Size = new System.Drawing.Size(76, 20);
            this.ComboBox_Bote.TabIndex = 3;
            // 
            // Label_Bote
            // 
            this.Label_Bote.AutoSize = true;
            this.Label_Bote.Location = new System.Drawing.Point(165, 13);
            this.Label_Bote.Name = "Label_Bote";
            this.Label_Bote.Size = new System.Drawing.Size(53, 12);
            this.Label_Bote.TabIndex = 2;
            this.Label_Bote.Text = "波特率：";
            // 
            // ComboBox_Check
            // 
            this.ComboBox_Check.FormattingEnabled = true;
            this.ComboBox_Check.Location = new System.Drawing.Point(377, 10);
            this.ComboBox_Check.Name = "ComboBox_Check";
            this.ComboBox_Check.Size = new System.Drawing.Size(76, 20);
            this.ComboBox_Check.TabIndex = 5;
            // 
            // Label_Check
            // 
            this.Label_Check.AutoSize = true;
            this.Label_Check.Location = new System.Drawing.Point(318, 13);
            this.Label_Check.Name = "Label_Check";
            this.Label_Check.Size = new System.Drawing.Size(53, 12);
            this.Label_Check.TabIndex = 4;
            this.Label_Check.Text = "校验位：";
            // 
            // ComboBox_Stop
            // 
            this.ComboBox_Stop.FormattingEnabled = true;
            this.ComboBox_Stop.Location = new System.Drawing.Point(224, 46);
            this.ComboBox_Stop.Name = "ComboBox_Stop";
            this.ComboBox_Stop.Size = new System.Drawing.Size(76, 20);
            this.ComboBox_Stop.TabIndex = 9;
            // 
            // Label_Stop
            // 
            this.Label_Stop.AutoSize = true;
            this.Label_Stop.Location = new System.Drawing.Point(165, 49);
            this.Label_Stop.Name = "Label_Stop";
            this.Label_Stop.Size = new System.Drawing.Size(53, 12);
            this.Label_Stop.TabIndex = 8;
            this.Label_Stop.Text = "停止位：";
            // 
            // ComboBox_Data
            // 
            this.ComboBox_Data.FormattingEnabled = true;
            this.ComboBox_Data.Location = new System.Drawing.Point(72, 46);
            this.ComboBox_Data.Name = "ComboBox_Data";
            this.ComboBox_Data.Size = new System.Drawing.Size(76, 20);
            this.ComboBox_Data.TabIndex = 7;
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Location = new System.Drawing.Point(13, 49);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(53, 12);
            this.Label_Data.TabIndex = 6;
            this.Label_Data.Text = "数据位：";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(320, 46);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(75, 23);
            this.Button_Connect.TabIndex = 10;
            this.Button_Connect.Text = "连接";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Location = new System.Drawing.Point(411, 46);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Button_Disconnect.TabIndex = 11;
            this.Button_Disconnect.Text = "断开";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // TextBox_Data1
            // 
            this.TextBox_Data1.Location = new System.Drawing.Point(15, 94);
            this.TextBox_Data1.Name = "TextBox_Data1";
            this.TextBox_Data1.Size = new System.Drawing.Size(76, 21);
            this.TextBox_Data1.TabIndex = 12;
            // 
            // TextBox_Data2
            // 
            this.TextBox_Data2.Location = new System.Drawing.Point(121, 94);
            this.TextBox_Data2.Name = "TextBox_Data2";
            this.TextBox_Data2.Size = new System.Drawing.Size(76, 21);
            this.TextBox_Data2.TabIndex = 13;
            // 
            // TextBox_Data3
            // 
            this.TextBox_Data3.Location = new System.Drawing.Point(224, 94);
            this.TextBox_Data3.Name = "TextBox_Data3";
            this.TextBox_Data3.Size = new System.Drawing.Size(76, 21);
            this.TextBox_Data3.TabIndex = 14;
            // 
            // Button_Write
            // 
            this.Button_Write.Location = new System.Drawing.Point(411, 94);
            this.Button_Write.Name = "Button_Write";
            this.Button_Write.Size = new System.Drawing.Size(75, 23);
            this.Button_Write.TabIndex = 16;
            this.Button_Write.Text = "写入";
            this.Button_Write.UseVisualStyleBackColor = true;
            this.Button_Write.Click += new System.EventHandler(this.Button_Write_Click);
            // 
            // Button_Read
            // 
            this.Button_Read.Location = new System.Drawing.Point(320, 94);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(75, 23);
            this.Button_Read.TabIndex = 15;
            this.Button_Read.Text = "读取";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 306);
            this.Controls.Add(this.Button_Write);
            this.Controls.Add(this.Button_Read);
            this.Controls.Add(this.TextBox_Data3);
            this.Controls.Add(this.TextBox_Data2);
            this.Controls.Add(this.TextBox_Data1);
            this.Controls.Add(this.Button_Disconnect);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.ComboBox_Stop);
            this.Controls.Add(this.Label_Stop);
            this.Controls.Add(this.ComboBox_Data);
            this.Controls.Add(this.Label_Data);
            this.Controls.Add(this.ComboBox_Check);
            this.Controls.Add(this.Label_Check);
            this.Controls.Add(this.ComboBox_Bote);
            this.Controls.Add(this.Label_Bote);
            this.Controls.Add(this.ComboBox_SerialPort);
            this.Controls.Add(this.Label_SerialPort_Name);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于串口的Modbus_Rtu通讯Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_SerialPort_Name;
        private System.Windows.Forms.ComboBox ComboBox_SerialPort;
        private System.Windows.Forms.ComboBox ComboBox_Bote;
        private System.Windows.Forms.Label Label_Bote;
        private System.Windows.Forms.ComboBox ComboBox_Check;
        private System.Windows.Forms.Label Label_Check;
        private System.Windows.Forms.ComboBox ComboBox_Stop;
        private System.Windows.Forms.Label Label_Stop;
        private System.Windows.Forms.ComboBox ComboBox_Data;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.TextBox TextBox_Data1;
        private System.Windows.Forms.TextBox TextBox_Data2;
        private System.Windows.Forms.TextBox TextBox_Data3;
        private System.Windows.Forms.Button Button_Write;
        private System.Windows.Forms.Button Button_Read;
    }
}

