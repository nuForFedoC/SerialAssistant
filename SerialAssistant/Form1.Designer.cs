namespace SerialAssistant
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.serialPortNameComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portOpenAndCloseButton = new System.Windows.Forms.Button();
            this.recieveListBox = new System.Windows.Forms.ListBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.cmdComboBox = new System.Windows.Forms.ComboBox();
            this.clearRecieveBoxLabel = new System.Windows.Forms.Label();
            this.loadCMDButton = new System.Windows.Forms.Button();
            this.saveCMDButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.addCMDButton = new System.Windows.Forms.Button();
            this.clearComboBoxLabel = new System.Windows.Forms.Label();
            this.newLineCheckBox = new System.Windows.Forms.CheckBox();
            this.returnCheckBox = new System.Windows.Forms.CheckBox();
            this.scriptListView = new System.Windows.Forms.ListView();
            this.scriptModeCheckBox = new System.Windows.Forms.CheckBox();
            this.timeDelayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.circleModeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeDelayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPortNameComboBox
            // 
            this.serialPortNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortNameComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialPortNameComboBox.FormattingEnabled = true;
            this.serialPortNameComboBox.Location = new System.Drawing.Point(12, 41);
            this.serialPortNameComboBox.Name = "serialPortNameComboBox";
            this.serialPortNameComboBox.Size = new System.Drawing.Size(180, 32);
            this.serialPortNameComboBox.TabIndex = 0;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.IntegralHeight = false;
            this.baudRateComboBox.Location = new System.Drawing.Point(303, 41);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(207, 32);
            this.baudRateComboBox.TabIndex = 1;
            // 
            // portOpenAndCloseButton
            // 
            this.portOpenAndCloseButton.AutoSize = true;
            this.portOpenAndCloseButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portOpenAndCloseButton.Location = new System.Drawing.Point(603, 41);
            this.portOpenAndCloseButton.Name = "portOpenAndCloseButton";
            this.portOpenAndCloseButton.Size = new System.Drawing.Size(98, 34);
            this.portOpenAndCloseButton.TabIndex = 2;
            this.portOpenAndCloseButton.Text = "button1";
            this.portOpenAndCloseButton.UseVisualStyleBackColor = true;
            this.portOpenAndCloseButton.Click += new System.EventHandler(this.portOpenAndCloseButton_Click);
            // 
            // recieveListBox
            // 
            this.recieveListBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieveListBox.FormattingEnabled = true;
            this.recieveListBox.ItemHeight = 19;
            this.recieveListBox.Location = new System.Drawing.Point(12, 119);
            this.recieveListBox.Name = "recieveListBox";
            this.recieveListBox.Size = new System.Drawing.Size(757, 251);
            this.recieveListBox.TabIndex = 3;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendTextBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendTextBox.Location = new System.Drawing.Point(12, 442);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(757, 32);
            this.sendTextBox.TabIndex = 4;
            this.sendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sendTextBox_KeyPress);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.AutoSize = true;
            this.sendButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(787, 440);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(98, 34);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "button1";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cmdComboBox
            // 
            this.cmdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdComboBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComboBox.FormattingEnabled = true;
            this.cmdComboBox.Location = new System.Drawing.Point(804, 23);
            this.cmdComboBox.Name = "cmdComboBox";
            this.cmdComboBox.Size = new System.Drawing.Size(296, 32);
            this.cmdComboBox.TabIndex = 6;
            this.cmdComboBox.SelectedIndexChanged += new System.EventHandler(this.cmdComboBox_SelectedIndexChanged);
            // 
            // clearRecieveBoxLabel
            // 
            this.clearRecieveBoxLabel.AutoSize = true;
            this.clearRecieveBoxLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearRecieveBoxLabel.Location = new System.Drawing.Point(782, 399);
            this.clearRecieveBoxLabel.Name = "clearRecieveBoxLabel";
            this.clearRecieveBoxLabel.Size = new System.Drawing.Size(63, 25);
            this.clearRecieveBoxLabel.TabIndex = 7;
            this.clearRecieveBoxLabel.Text = "label1";
            this.clearRecieveBoxLabel.Click += new System.EventHandler(this.clearRecieveBoxLabel_Click);
            // 
            // loadCMDButton
            // 
            this.loadCMDButton.AutoSize = true;
            this.loadCMDButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCMDButton.Location = new System.Drawing.Point(804, 70);
            this.loadCMDButton.Name = "loadCMDButton";
            this.loadCMDButton.Size = new System.Drawing.Size(88, 35);
            this.loadCMDButton.TabIndex = 8;
            this.loadCMDButton.Text = "button1";
            this.loadCMDButton.UseVisualStyleBackColor = true;
            this.loadCMDButton.Click += new System.EventHandler(this.loadCMDButton_Click);
            // 
            // saveCMDButton
            // 
            this.saveCMDButton.AutoSize = true;
            this.saveCMDButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCMDButton.Location = new System.Drawing.Point(992, 70);
            this.saveCMDButton.Name = "saveCMDButton";
            this.saveCMDButton.Size = new System.Drawing.Size(88, 35);
            this.saveCMDButton.TabIndex = 8;
            this.saveCMDButton.Text = "button1";
            this.saveCMDButton.UseVisualStyleBackColor = true;
            this.saveCMDButton.Click += new System.EventHandler(this.saveCMDButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // addCMDButton
            // 
            this.addCMDButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCMDButton.AutoSize = true;
            this.addCMDButton.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCMDButton.Location = new System.Drawing.Point(937, 439);
            this.addCMDButton.Name = "addCMDButton";
            this.addCMDButton.Size = new System.Drawing.Size(88, 35);
            this.addCMDButton.TabIndex = 9;
            this.addCMDButton.Text = "button1";
            this.addCMDButton.UseVisualStyleBackColor = true;
            this.addCMDButton.Click += new System.EventHandler(this.addCMDButton_Click);
            // 
            // clearComboBoxLabel
            // 
            this.clearComboBoxLabel.AutoSize = true;
            this.clearComboBoxLabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearComboBoxLabel.Location = new System.Drawing.Point(987, 399);
            this.clearComboBoxLabel.Name = "clearComboBoxLabel";
            this.clearComboBoxLabel.Size = new System.Drawing.Size(63, 25);
            this.clearComboBoxLabel.TabIndex = 7;
            this.clearComboBoxLabel.Text = "label1";
            this.clearComboBoxLabel.Click += new System.EventHandler(this.clearComboBoxLabel_Click);
            // 
            // newLineCheckBox
            // 
            this.newLineCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newLineCheckBox.AutoSize = true;
            this.newLineCheckBox.Location = new System.Drawing.Point(906, 485);
            this.newLineCheckBox.Name = "newLineCheckBox";
            this.newLineCheckBox.Size = new System.Drawing.Size(80, 17);
            this.newLineCheckBox.TabIndex = 10;
            this.newLineCheckBox.Text = "checkBox1";
            this.newLineCheckBox.UseVisualStyleBackColor = true;
            // 
            // returnCheckBox
            // 
            this.returnCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnCheckBox.AutoSize = true;
            this.returnCheckBox.Location = new System.Drawing.Point(787, 485);
            this.returnCheckBox.Name = "returnCheckBox";
            this.returnCheckBox.Size = new System.Drawing.Size(80, 17);
            this.returnCheckBox.TabIndex = 10;
            this.returnCheckBox.Text = "checkBox1";
            this.returnCheckBox.UseVisualStyleBackColor = true;
            // 
            // scriptListView
            // 
            this.scriptListView.Location = new System.Drawing.Point(804, 119);
            this.scriptListView.Name = "scriptListView";
            this.scriptListView.Size = new System.Drawing.Size(296, 207);
            this.scriptListView.TabIndex = 11;
            this.scriptListView.UseCompatibleStateImageBehavior = false;
            this.scriptListView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scriptListView_KeyPress);
            // 
            // scriptModeCheckBox
            // 
            this.scriptModeCheckBox.AutoSize = true;
            this.scriptModeCheckBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptModeCheckBox.Location = new System.Drawing.Point(804, 352);
            this.scriptModeCheckBox.Name = "scriptModeCheckBox";
            this.scriptModeCheckBox.Size = new System.Drawing.Size(142, 28);
            this.scriptModeCheckBox.TabIndex = 12;
            this.scriptModeCheckBox.Text = "checkBox1";
            this.scriptModeCheckBox.UseVisualStyleBackColor = true;
            this.scriptModeCheckBox.CheckStateChanged += new System.EventHandler(this.scriptModeCheckBox_CheckStateChanged);
            // 
            // timeDelayNumericUpDown
            // 
            this.timeDelayNumericUpDown.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDelayNumericUpDown.Location = new System.Drawing.Point(598, 480);
            this.timeDelayNumericUpDown.Name = "timeDelayNumericUpDown";
            this.timeDelayNumericUpDown.Size = new System.Drawing.Size(171, 32);
            this.timeDelayNumericUpDown.TabIndex = 13;
            // 
            // circleModeCheckBox
            // 
            this.circleModeCheckBox.AutoSize = true;
            this.circleModeCheckBox.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleModeCheckBox.Location = new System.Drawing.Point(979, 352);
            this.circleModeCheckBox.Name = "circleModeCheckBox";
            this.circleModeCheckBox.Size = new System.Drawing.Size(142, 28);
            this.circleModeCheckBox.TabIndex = 14;
            this.circleModeCheckBox.Text = "checkBox1";
            this.circleModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 514);
            this.Controls.Add(this.circleModeCheckBox);
            this.Controls.Add(this.timeDelayNumericUpDown);
            this.Controls.Add(this.scriptModeCheckBox);
            this.Controls.Add(this.scriptListView);
            this.Controls.Add(this.returnCheckBox);
            this.Controls.Add(this.newLineCheckBox);
            this.Controls.Add(this.addCMDButton);
            this.Controls.Add(this.saveCMDButton);
            this.Controls.Add(this.loadCMDButton);
            this.Controls.Add(this.clearComboBoxLabel);
            this.Controls.Add(this.clearRecieveBoxLabel);
            this.Controls.Add(this.cmdComboBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.recieveListBox);
            this.Controls.Add(this.portOpenAndCloseButton);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.serialPortNameComboBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.timeDelayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serialPortNameComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Button portOpenAndCloseButton;
        private System.Windows.Forms.ListBox recieveListBox;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ComboBox cmdComboBox;
        private System.Windows.Forms.Label clearRecieveBoxLabel;
        private System.Windows.Forms.Button loadCMDButton;
        private System.Windows.Forms.Button saveCMDButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button addCMDButton;
        private System.Windows.Forms.Label clearComboBoxLabel;
        private System.Windows.Forms.CheckBox newLineCheckBox;
        private System.Windows.Forms.CheckBox returnCheckBox;
        private System.Windows.Forms.ListView scriptListView;
        private System.Windows.Forms.CheckBox scriptModeCheckBox;
        private System.Windows.Forms.NumericUpDown timeDelayNumericUpDown;
        private System.Windows.Forms.CheckBox circleModeCheckBox;
    }
}

