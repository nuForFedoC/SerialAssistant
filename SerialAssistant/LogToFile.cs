using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VHMLog
{
    public class LogToFile
    {
        private FileStream logFileStream = null;
        private StreamWriter logFileStreamWriter = null;
		
		public string filePath = null;

		public LogToFile(string path)
		{
			this.filePath = path;
		}

        public void LogFileOpenOrCreat()
        {
            if (File.Exists(this.filePath))
                this.logFileStream = new FileStream(this.filePath, FileMode.Append, FileAccess.Write);
            else
                this.logFileStream = new FileStream(this.filePath, FileMode.Create, FileAccess.Write);
            this.logFileStreamWriter = new StreamWriter(logFileStream);
        }

        public void LogFileClose()
        {
            this.logFileStreamWriter.Flush();
            this.logFileStreamWriter.Close();
            this.logFileStream.Close();
        }

        public string LogFileWriteLine(string context)
        {
            try
            {
                this.LogFileOpenOrCreat();
                this.logFileStreamWriter.WriteLine(context);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                this.LogFileClose();
            }
            
            return null;
        }

        public string LogFileWriteList(List<string> contexList)
        {
            try
            {
                this.LogFileOpenOrCreat();

                foreach (string context in contexList)
                    this.logFileStreamWriter.WriteLine(context);

            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                this.LogFileClose();
            }
            return null;
        }

        public string LogFileWriteListBox(ListBox contexListBox)
        {
            try
            {
                this.LogFileOpenOrCreat();

                foreach (string context in contexListBox.Items)
                    this.logFileStreamWriter.WriteLine(context);

            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                this.LogFileClose();
            }
            return null;
        }

        public string LogFileWriteListBox(ListView contextListView)
        {
            try
            {
                this.LogFileOpenOrCreat();

                foreach (ListViewItem contextItems in contextListView.Items)
                {
                    string lineInContextListView = null;
                    for (int i = 0; i < contextListView.Columns.Count; i++)
                        lineInContextListView += contextItems.SubItems[i].Text + " ";
                    this.logFileStreamWriter.WriteLine(lineInContextListView);
                }

            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                this.LogFileClose();
            }
            return null;
        }

        public string LogFileWriteLineWithTimeStamp(string context)
        {
            try
            {
                this.LogFileOpenOrCreat();
                logFileStreamWriter.WriteLine(DateTime.Now.ToString("yy-MM-dd_HH-mm-ss") + "-----" + context);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            finally
            {
                this.LogFileClose();
            }

            return null;
        }
    }
}
