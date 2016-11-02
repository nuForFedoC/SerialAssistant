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
using System.IO;
using System.Threading;
using VHMLog;

namespace SerialAssistant
{
    public partial class Form1 : Form
    {
        private LogToFile cmdFile;
        private SerialPort testSerialPort =new SerialPort();

        private List<ScriptString> scriptList = new List<ScriptString>();

        public delegate void UpdateRecieveBoxDelegate(string newString);

        private BackgroundWorker scriptModeBackgroundWorker = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            // To report progress from the background worker we need to set this property
            scriptModeBackgroundWorker.WorkerReportsProgress = true;
            scriptModeBackgroundWorker.WorkerSupportsCancellation = true;

            // This event will be raised on the worker thread when the worker starts
            scriptModeBackgroundWorker.DoWork += new DoWorkEventHandler(scriptModeBackgroundWorker_DoWork);

            // This event will be raised when we call ReportProgress
            //scriptModeBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(scriptModeBackgroundWorker_ProgressChanged);
            scriptModeBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(scriptModeBackgroundWorker_WorkComplete);
            string[] serialPortNamesArray = SerialPort.GetPortNames();
            foreach (string portName in serialPortNamesArray)
            {
                serialPortNameComboBox.Items.Add(portName);
            }

            baudRateComboBox.Items.Add("9600");
            baudRateComboBox.Items.Add("19200");
            baudRateComboBox.Items.Add("38400");
            baudRateComboBox.Items.Add("57600");
            baudRateComboBox.Items.Add("115200");
            baudRateComboBox.SelectedIndex = 2;

            portOpenAndCloseButton.Text = "OpenPort";
            sendButton.Text = "Send";
            loadCMDButton.Text = "LoadCMD";
            saveCMDButton.Text = "SaveCMD";
            addCMDButton.Text = "AddCMDToCMDList";

            newLineCheckBox.Text = "AddNewLine";
            returnCheckBox.Text = "AddReturn";

            clearRecieveBoxLabel.Text = "ClearRecieveBox";
            clearComboBoxLabel.Text = "ClearCMDList";

            scriptListView.View = View.Details;
            scriptListView.Columns.Add("CMD");
            scriptListView.Columns.Add("TimeDelay");
            scriptListView.Columns[0].Width = 200;
            scriptListView.Columns[1].Width = 80;
            scriptListView.Enabled = false;
            scriptListView.FullRowSelect = true;

            scriptModeCheckBox.Text = "ScriptMode";

            circleModeCheckBox.Text = "CircleMode";
            circleModeCheckBox.Visible = false;

            timeDelayNumericUpDown.Minimum = 0;
            timeDelayNumericUpDown.Maximum = 10000;
            timeDelayNumericUpDown.Value = 100;
            timeDelayNumericUpDown.Visible = false;

            this.Text = "SerialAssistant";
            
        }

        private void portOpenAndCloseButton_Click(object sender, EventArgs e)
        {
            if (portOpenAndCloseButton.Text == "OpenPort")
            {
                testSerialPort.PortName = serialPortNameComboBox.SelectedItem.ToString();
                testSerialPort.BaudRate = int.Parse(baudRateComboBox.SelectedItem.ToString());
                testSerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                try
                {
                    testSerialPort.Open();
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show("can't open serial port");
                }
                finally
                {
                    if (testSerialPort.IsOpen)
                    {
                        portOpenAndCloseButton.Text = "ClosePort";
                    }
                }
            }
            else if (portOpenAndCloseButton.Text == "ClosePort")
            {
                testSerialPort.Close();
                if (!testSerialPort.IsOpen)
                {
                    portOpenAndCloseButton.Text = "OpenPort";
                }
            }
            

                
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort scanerPort = (SerialPort)sender;
            Thread.Sleep(50);
            string textInBuffer = DateTime.Now.ToString("HH-mm-ss-fff") + " <---- " + scanerPort.ReadExisting();
            UpdateRecieveBoxDelegate UpdateRecieveBox = new UpdateRecieveBoxDelegate(RecieveBoxUpdate);
            this.Invoke(UpdateRecieveBox, textInBuffer);
        }

        private void RecieveBoxUpdate(string newString)
        {
            this.recieveListBox.Items.Add(newString);
            recieveListBox.SelectedIndex = recieveListBox.Items.Count - 1;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (testSerialPort.IsOpen)
            {
                if (scriptModeCheckBox.Checked)
                {
                    if (sendButton.Text == "StartScript")
                    {
                        if (scriptListView.Items.Count > 0)
                        {
                            scriptList.Clear();
                            foreach (ListViewItem tempLviInScriptListView in scriptListView.Items)
                            {
                                //string tempListViewItemString = tempLviInScriptListView.SubItems[0].Text + ',' + tempLviInScriptListView.SubItems[1].Text;
                                ScriptString tempScriptString = new ScriptString();
                                tempScriptString.CMDText = tempLviInScriptListView.SubItems[0].Text;
                                tempScriptString.TimeDelay = int.Parse(tempLviInScriptListView.SubItems[1].Text);
                                scriptList.Add(tempScriptString);
                            }
                            scriptModeBackgroundWorker.RunWorkerAsync();
                            sendButton.Text = "EndScript";
                        }
                    }
                    else
                    {
                        scriptModeBackgroundWorker.CancelAsync();
                        sendButton.Text = "StartScript";
                    }
                }
                else
                {
                    SendTextFromTextBox();
                }           
            }
            else
            {
                MessageBox.Show("Port is not open");
            }
            
        }

        private void cmdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sendTextBox.Text = cmdComboBox.SelectedItem.ToString();
        }

        private void clearRecieveBoxLabel_Click(object sender, EventArgs e)
        {
            recieveListBox.Items.Clear();
        }

        private void loadCMDButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string cmdFilePath = openFileDialog.FileName;
                if (scriptModeCheckBox.Checked)
                {
                    //TODO add code here
                    scriptListView.Items.Clear();
                    if (cmdFilePath.Contains(".txt"))
                    {
                        string[] cmdLinesInFile = File.ReadAllLines(cmdFilePath);
                        foreach (string cmdLine in cmdLinesInFile)
                        {
                            scriptListView.Items.Add(new ListViewItem(cmdLine.Split(',')));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't Open File!!!");
                    }
                }
                else
                {
                    if (cmdFilePath.Contains(".txt"))
                    {
                        string[] cmdLinesInFile = File.ReadAllLines(cmdFilePath);
                        foreach (string cmdLine in cmdLinesInFile)
                        {
                            cmdComboBox.Items.Add(cmdLine);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Can't Open File!!!");
                    }
                }
            }
        }

        private void saveCMDButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.DefaultExt = "txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                cmdFile = new LogToFile(filePath);
                if (scriptModeCheckBox.Checked)
                {
                    //TODO Add script code here
                    if (scriptListView.Items.Count > 0)
                    {
                        foreach (ListViewItem tempLviInScriptListView in scriptListView.Items)
                        { 
                            string tempStriptString="";
                            for (int i = 0; i < tempLviInScriptListView.SubItems.Count; i++) 
                            {
                                tempStriptString += tempLviInScriptListView.SubItems[i].Text;
                                if (i != tempLviInScriptListView.SubItems.Count)
                                {
                                    tempStriptString += ',';
                                }
                            }
                            cmdFile.LogFileWriteLine(tempStriptString);
                        }
                    }
                }
                else
                {
                    if (cmdComboBox.Items.Count > 0)
                    {
                        foreach (object cmdInCMDComboBox in cmdComboBox.Items)
                        {
                            cmdFile.LogFileWriteLine(cmdInCMDComboBox.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No CMD To Save");
                    }
                }
                
            }
        }

        private void addCMDButton_Click(object sender, EventArgs e)
        {
            if (sendTextBox.TextLength > 0)
            {
                if (scriptModeCheckBox.Checked)
                {
                    //TODO add Code here
                    ListViewItem tempLvi = new ListViewItem(sendTextBox.Text);
                    tempLvi.SubItems.Add(timeDelayNumericUpDown.Value.ToString());
                    scriptListView.Items.Add(tempLvi);
                }
                else
                {
                    cmdComboBox.Items.Add(sendTextBox.Text);
                }
            }
        }

        private void clearComboBoxLabel_Click(object sender, EventArgs e)
        {
            if (scriptModeCheckBox.Checked)
            {
                scriptListView.Items.Clear();
            }
            else
            {
                cmdComboBox.Items.Clear();
            }           
        }

        private void sendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                //SendTextFromTextBox();
                sendButton.PerformClick();
            }
        }

        private void SendTextFromTextBox()
        {
            string tempSendBuff = sendTextBox.Text;
            if (returnCheckBox.Checked)
            {
                tempSendBuff = tempSendBuff + '\r';
            }
            if (newLineCheckBox.Checked)
            {
                tempSendBuff = tempSendBuff + '\n';
            }

            recieveListBox.Items.Add(DateTime.Now.ToString("HH-mm-ss-fff") + " ----> " + tempSendBuff);
            testSerialPort.Write(tempSendBuff); 
        }

        private void scriptModeCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (scriptModeCheckBox.Checked)
            {
                sendButton.Text = "StartScript";
                timeDelayNumericUpDown.Visible = true;
                scriptListView.Enabled = true;
                saveCMDButton.Text = "SaveScript";
                loadCMDButton.Text = "LoadScript";
                addCMDButton.Text = "AddCMDToScriptList";
                clearComboBoxLabel.Text = "ClearScriptList";
                cmdComboBox.Enabled = false;
                circleModeCheckBox.Visible = true;
            }
            else
            {
                sendButton.Text = "Send";
                timeDelayNumericUpDown.Visible = false;
                scriptListView.Enabled = false;
                loadCMDButton.Text = "LoadCMD";
                saveCMDButton.Text = "SaveCMD";
                addCMDButton.Text = "AddCMDToCMDList";
                clearComboBoxLabel.Text = "ClearCMDList";
                cmdComboBox.Enabled = true;
                circleModeCheckBox.Visible = false;
            }
        }

        private void scriptListView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'u' || e.KeyChar == 'U') 
            {
                if (scriptListView.SelectedItems.Count > 0 && scriptListView.SelectedItems[0].Index != 0)
                {
                    scriptListView.BeginUpdate();
                    foreach (ListViewItem lviInScriptListView in scriptListView.SelectedItems)
                    {
                        ListViewItem tempLvi = lviInScriptListView;
                        int tempIndex = tempLvi.Index;
                        scriptListView.Items.RemoveAt(tempIndex);
                        scriptListView.Items.Insert(tempIndex - 1, tempLvi);
                    }
                    scriptListView.EndUpdate();
                }
            }
            else if (e.KeyChar == 'n' || e.KeyChar == 'N')
            {
                if (scriptListView.SelectedItems.Count > 0 && scriptListView.SelectedItems[scriptListView.SelectedItems.Count - 1].Index < scriptListView.Items.Count - 1)
                {
                    scriptListView.BeginUpdate();
                    int countOfSelectItems = scriptListView.SelectedItems.Count;
                    foreach (ListViewItem lviInScriptListView in scriptListView.SelectedItems)
                    {
                        ListViewItem tempLvi = lviInScriptListView;
                        int tempIndex = tempLvi.Index;
                        scriptListView.Items.RemoveAt(tempIndex);
                        scriptListView.Items.Insert(tempIndex + countOfSelectItems, tempLvi);
                    }
                    scriptListView.EndUpdate();
                }
            }
            else if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                if (scriptListView.SelectedItems.Count > 0)
                {
                    scriptListView.BeginUpdate();
                    foreach (ListViewItem lviInScriptListView in scriptListView.SelectedItems)
                    {
                        scriptListView.Items.Remove(lviInScriptListView);
                    }
                    scriptListView.EndUpdate();
                }
            }
            scriptListView.Focus();
        }

        void scriptModeBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            do
            {
                for (int i = 0; i < scriptList.Count; i++)
                {
                    UpdateRecieveBoxDelegate UpdateRecieveBox = new UpdateRecieveBoxDelegate(RecieveBoxUpdate);
                    this.Invoke(UpdateRecieveBox, DateTime.Now.ToString("HH-mm-ss-fff") + " ----> " + scriptList[i].CMDText);
                    testSerialPort.Write(scriptList[i].CMDText);
                    Thread.Sleep(scriptList[i].TimeDelay);
                }
            } while (circleModeCheckBox.Checked && !scriptModeBackgroundWorker.CancellationPending);
        }

        private void scriptModeBackgroundWorker_WorkComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            sendButton.Text = "StartScript";
        }
    }
}
