using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private Object thisLock = new object(); //объект для захватывания потоками

        string filename = "file.txt";

        Thread writer = null;

        Thread reader = null;

        bool stopWriter = false;

        bool stopReader = false;

        static Semaphore sem = new Semaphore(1, 2);

        int timeThread1;
        int timeThread2;

        int ind;

        public Form1()
        {
            InitializeComponent();

            FileStream fileStream = File.Open(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
            fileStream.Close();

            buttonStartThread1.Enabled = true;
            buttonStopThread1.Enabled = false;
            buttonStartThread2.Enabled = true;
            buttonStopThread2.Enabled = false;
            buttonGlobalStop.Enabled = false;

            ind = -1;
            timeThread1 = (int)trackBarThread1.Value;
            timeThread2 = (int)trackBarThread2.Value;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i=2; i*i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public void WriteToBuffer(int value)
        {
            textBoxThread1.AppendText(value + "\r\n");
        }

        public void WriteValuesIntoFile() //функция записи значений в файл
        {
            while (true)
            {
                sem.WaitOne();

                Random r = new Random();
                int ch = 2;
                while (ch % 2 == 0)
                {
                    ch = r.Next(0, 101);
                }
                if (!stopWriter)
                {
                    lock (thisLock) //захватываем переменную
                    {
                        using (StreamWriter sw = File.AppendText(filename))
                        {
                            sw.WriteLine(ch);
                            Action safeWrite = delegate { WriteToBuffer(ch); };
                            this.BeginInvoke(safeWrite); //записываем результат на экран
                        }
                    }
                }
                sem.Release();
                Thread.Sleep(timeThread1);
            }
        }

        private void buttonStartThread1_Click(object sender, EventArgs e)
        {
            textBoxInfo.AppendText("Поток 1 запущен\r\n");
            if (writer != null)
            {
                if (stopWriter) 
                {
                    stopWriter = false;
                    buttonStartThread1.Enabled = false;
                    buttonStopThread1.Enabled = true;
                    buttonGlobalStop.Enabled = true;
                    return;
                }
            }
            stopWriter = false;
            //создаём поток записи и устанавливаем ему функцию для входа
            var threadParam = new System.Threading.ThreadStart(delegate { WriteValuesIntoFile(); });
            writer = new Thread(threadParam);
            writer.Start();

            buttonStartThread1.Enabled = false;
            buttonStopThread1.Enabled = true;
            buttonGlobalStop.Enabled = true;
        }

        public void WriteToBufferRead(int res)
        {
            textBoxThread2.Invoke(new Action(() => textBoxThread2.AppendText(res.ToString() + "\r\n")));
        }

        public void ReadValueFromFile() //чтение из файла
        {
            while (true)
            {
                sem.WaitOne();
                if (!stopReader)
                {
                    this.ind++;
                    lock (thisLock) //захватываем переменную
                    {
                        string tempFile = Path.GetTempFileName(); //создаём временный файл
                        using (var sw = new StreamWriter(tempFile))
                        {
                            using (var sr = new StreamReader(filename))
                            {
                                string line = " ";
                                int count = -1;

                                while (count < ind - 1)
                                {
                                    count++;
                                    line = sr.ReadLine();
                                    
                                    if (line != " " && line != null)
                                    {
                                        int ch = Int32.Parse(line);
                                        sw.WriteLine(ch);
                                    }
                                    else if (line == null)
                                    {
                                        this.ind--;
                                        textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Поток 2 ожидает\r\n")));
                                    }
                                    else sw.WriteLine(line);
                                }
                                line = sr.ReadLine();
                                if (line != null)
                                {
                                    int ch = Int32.Parse(line);
                                    if (IsPrime(ch))
                                    {
                                        sw.WriteLine(ch);
                                        WriteToBufferRead(ch);
                                    }
                                    else
                                    {
                                        sw.WriteLine(" ");
                                    }
                                    while ((line = sr.ReadLine()) != null)
                                    {
                                        ch = Int32.Parse(line);
                                        sw.WriteLine(ch);
                                    }
                                }
                            }
                        }
                        File.Delete(filename);
                        File.Move(tempFile, filename);
                    }
                }
                sem.Release();
                Thread.Sleep(timeThread2);
            }
        }

        private void buttonStartThread2_Click(object sender, EventArgs e)
        {
            textBoxInfo.AppendText("Поток 2 запущен\r\n");
            if (reader != null)
            {
                if (stopReader)
                {
                    stopReader = false;
                    buttonStartThread2.Enabled = false;
                    buttonStopThread2.Enabled = true;
                    buttonGlobalStop.Enabled = true;
                    return;
                }
            }
            stopReader = false;
            //создаём поток и устанавливаем функцию, которая будет им обрабатываться
            var threadParam = new System.Threading.ThreadStart(delegate { ReadValueFromFile(); });
            reader = new Thread(threadParam);
            reader.Start();

            buttonStartThread2.Enabled = false;
            buttonStopThread2.Enabled = true;
            buttonGlobalStop.Enabled = true;
        }

        private void buttonGlobalStop_Click(object sender, EventArgs e)
        {
            
            if (writer != null)
            {
                textBoxInfo.AppendText("Поток 1 завершён\r\n");
                writer.Abort();
                writer = null;
            }
            stopWriter = true;
            buttonStartThread1.Enabled = true;
            buttonStopThread1.Enabled = false;
            buttonGlobalStop.Enabled = false;
            if (reader != null)
            {
                textBoxInfo.AppendText("Поток 2 завершён\r\n");
                reader.Abort();
                reader = null;
            }
            stopReader = true;
            buttonStartThread2.Enabled = true;
            buttonStopThread2.Enabled = false;
        }

        private void buttonStopThread1_Click(object sender, EventArgs e)
        {
            textBoxInfo.AppendText("Поток 1 приостановлен\r\n");
            stopWriter = true;
            buttonStartThread1.Enabled = true;
            buttonStopThread1.Enabled = false;
            buttonGlobalStop.Enabled = false;
        }

        private void buttonStopThread2_Click(object sender, EventArgs e)
        {
            textBoxInfo.AppendText("Поток 2 приостановлен\r\n");
            stopReader = true;
            buttonStartThread2.Enabled = true;
            buttonStopThread2.Enabled = false;
            buttonGlobalStop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBarThread1_Scroll(object sender, EventArgs e)
        {
            timeThread1 = (int)trackBarThread1.Value;
        }

        private void trackBarThread2_Scroll(object sender, EventArgs e)
        {
            timeThread2 = (int)trackBarThread2.Value;
        }
    }
}
