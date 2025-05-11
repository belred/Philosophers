using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Philosophers
{
    public partial class Form1 : Form
    {
        const int N = 5;
        int THINKING = 0;
        int HUNGRY = 1;
        int EATING = 2;
        int[] state = { 0, 0, 0, 0, 0 };
        int[] turn = { 0, 0, 0, 0, 0 }; //очередь
        int[] flag = { -1, -1, -1, -1, -1 };
        bool[] wait = { false, false, false, false, false };
        Thread ph1 = null;
        Thread ph2 = null;
        Thread ph3 = null;
        Thread ph4 = null;
        Thread ph5 = null;
        Point[] ph = { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) };
        int size = 75;
        Graphics Graph;
        Pen MyPen;
        SolidBrush MyBrush;
        (Point X, Point Y)[] coord = { (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)) };
        (Point X, Point Y)[] coord_ = { (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)) };
        (Point X, Point Y)[] coord_left = { (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)) };
        (Point X, Point Y)[] coord_right = { (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)), (new Point(0, 0), new Point(0, 0)) };
        Point dish = new Point(0, 0);
        int[] timeThreads = { 0, 0, 0, 0, 0 }; //скорость
        bool start = false;
        bool script1 = false;
        bool script2 = false;

        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black, 3);
            MyBrush = new SolidBrush(Color.Yellow);
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
            buttonScript1.Enabled = true;
            buttonScript2.Enabled = true;
            timeThreads[0] = (int)trackBarThread1.Value;
            timeThreads[1] = (int)trackBarThread2.Value;
            timeThreads[2] = (int)trackBarThread3.Value;
            timeThreads[3] = (int)trackBarThread4.Value;
            timeThreads[4] = (int)trackBarThread5.Value;
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.DoubleBuffered = true; //для плавной отрисовки
            setCoords();
        }

        private void takeSticks_left(int i) //перемещение палочки (взять) 
        {
            while (coord[i] != coord_left[i])
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (coord[i].X.X != coord_left[i].X.X)
                    {
                        if (coord[i].X.X > coord_left[i].X.X) coord[i].X.X -= 1;
                        else if (coord[i].X.X < coord_left[i].X.X) coord[i].X.X += 1;
                    }
                    if (coord[i].X.Y != coord_left[i].X.Y)
                    {
                        if (coord[i].X.Y > coord_left[i].X.Y) coord[i].X.Y -= 1;
                        else if (coord[i].X.Y < coord_left[i].X.Y) coord[i].X.Y += 1;
                    }
                    if (coord[i].Y.X != coord_left[i].Y.X)
                    {
                        if (coord[i].Y.X > coord_left[i].Y.X) coord[i].Y.X -= 1;
                        else if (coord[i].Y.X < coord_left[i].Y.X) coord[i].Y.X += 1;
                    }
                    if (coord[i].Y.Y != coord_left[i].Y.Y)
                    {
                        if (coord[i].Y.Y > coord_left[i].Y.Y) coord[i].Y.Y -= 1;
                        else if (coord[i].Y.Y < coord_left[i].Y.Y) coord[i].Y.Y += 1;
                    }
                    this.Invalidate();
                    this.Update();
                });
                Thread.Sleep(53);
            }
        }

        private void takeSticks_right(int i) //перемещение палочки (взять) 
        {
            while (coord[i] != coord_right[i])
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (coord[i].X.X != coord_right[i].X.X)
                    {
                        if (coord[i].X.X > coord_right[i].X.X) coord[i].X.X -= 1;
                        else if (coord[i].X.X < coord_right[i].X.X) coord[i].X.X += 1;
                    }
                    if (coord[i].X.Y != coord_right[i].X.Y)
                    {
                        if (coord[i].X.Y > coord_right[i].X.Y) coord[i].X.Y -= 1;
                        else if (coord[i].X.Y < coord_right[i].X.Y) coord[i].X.Y += 1;
                    }
                    if (coord[i].Y.X != coord_right[i].Y.X)
                    {
                        if (coord[i].Y.X > coord_right[i].Y.X) coord[i].Y.X -= 1;
                        else if (coord[i].Y.X < coord_right[i].Y.X) coord[i].Y.X += 1;
                    }
                    if (coord[i].Y.Y != coord_right[i].Y.Y)
                    {
                        if (coord[i].Y.Y > coord_right[i].Y.Y) coord[i].Y.Y -= 1;
                        else if (coord[i].Y.Y < coord_right[i].Y.Y) coord[i].Y.Y += 1;
                    }
                    this.Invalidate();
                    this.Update();
                });
                Thread.Sleep(53);
            }
        }

        private void starting_position() //начальная позиция палочки
        {
            for (int i = 0; i < N; i++) coord[i] = coord_[i];
        }

        private void putSticks(int i) //перемещение палочки (положить)
        {
            while (coord[i] != coord_[i])
            {
                this.Invoke((MethodInvoker)delegate
                {
                    if (coord[i].X.X != coord_[i].X.X)
                    {
                        if (coord[i].X.X > coord_[i].X.X) coord[i].X.X -= 1;
                        else if (coord[i].X.X < coord_[i].X.X) coord[i].X.X += 1;
                    }
                    if (coord[i].X.Y != coord_[i].X.Y)
                    {
                        if (coord[i].X.Y > coord_[i].X.Y) coord[i].X.Y -= 1;
                        else if (coord[i].X.Y < coord_[i].X.Y) coord[i].X.Y += 1;
                    }
                    if (coord[i].Y.X != coord_[i].Y.X)
                    {
                        if (coord[i].Y.X > coord_[i].Y.X) coord[i].Y.X -= 1;
                        else if (coord[i].Y.X < coord_[i].Y.X) coord[i].Y.X += 1;
                    }
                    if (coord[i].Y.Y != coord_[i].Y.Y)
                    {
                        if (coord[i].Y.Y > coord_[i].Y.Y) coord[i].Y.Y -= 1;
                        else if (coord[i].Y.Y < coord_[i].Y.Y) coord[i].Y.Y += 1;
                    }
                    this.Invalidate();
                    this.Update();
                });
                Thread.Sleep(53);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e) //рисование
        {
            Graph = e.Graphics;
            for (int i = 0; i < 5; i++)
            {
                drawPh(i);
            }
            for (int i = 0; i < 5; i++)
            {
                drawSticks(i, coord[i].X, coord[i].Y);
            }
            drawDish();
        }

        private void drawPh(int i) //рисует философа
        {
            if (state[i] == THINKING) MyBrush.Color = Color.Yellow;
            else if (state[i] == HUNGRY) MyBrush.Color = Color.Red;
            else if (state[i] == EATING) MyBrush.Color = Color.Green;
            Graph.FillEllipse(MyBrush, ph[i].X, ph[i].Y, size, size);
        }

        private void drawSticks(int i, Point x, Point y) //рисует палочку
        {
            Graph.DrawLine(MyPen, x, y);
        }

        private void drawDish() //рисует блюдо
        {
            Graph.DrawEllipse(MyPen, dish.X, dish.Y, 100, 100);
        }

        private void setCoords() //задаёт координаты
        {
            ph[0].X = this.ClientSize.Width / 2 - 330;
            ph[0].Y = this.ClientSize.Height / 2 - 50;

            ph[1].X = this.ClientSize.Width / 2 - 200;
            ph[1].Y = this.ClientSize.Height / 2 - 200;

            ph[2].X = this.ClientSize.Width / 2;
            ph[2].Y = this.ClientSize.Height / 2 - 150;

            ph[3].X = this.ClientSize.Width / 2 + 5;
            ph[3].Y = this.ClientSize.Height / 2 + 70;

            ph[4].X = this.ClientSize.Width / 2 - 210;
            ph[4].Y = this.ClientSize.Height / 2 + 110;

            //блюдо
            dish.X = this.ClientSize.Width / 2 - 160;
            dish.Y = this.ClientSize.Height / 2 - 60;

            //1 палочка
            coord[0].X.X = dish.X - 130; coord[0].X.Y = dish.Y - 60;
            coord[0].Y.X = dish.X - 30; coord[0].Y.Y = dish.Y;
            //к 1 философу
            coord_left[0].X.X = dish.X - 160; coord_left[0].X.Y = dish.Y - 10;
            coord_left[0].Y.X = dish.X - 60; coord_left[0].Y.Y = dish.Y + 50;
            //ко 2 философу
            coord_right[0].X.X = dish.X - 80; coord_right[0].X.Y = dish.Y - 110;
            coord_right[0].Y.X = dish.X + 20; coord_right[0].Y.Y = dish.Y - 50;

            //2 палочка
            coord[1].X.X = dish.X + 120; coord[1].X.Y = dish.Y - 130;
            coord[1].Y.X = dish.X + 80; coord[1].Y.Y = dish.Y - 30;
            //ко 2 философу
            coord_left[1].X.X = dish.X + 50; coord_left[1].X.Y = dish.Y - 150;
            coord_left[1].Y.X = dish.X + 10; coord_left[1].Y.Y = dish.Y - 50;
            //к 3 философу
            coord_right[1].X.X = dish.X + 190; coord_right[1].X.Y = dish.Y - 120;
            coord_right[1].Y.X = dish.X + 150; coord_right[1].Y.Y = dish.Y - 20;

            //3 палочка
            coord[2].X.X = dish.X + 260; coord[2].X.Y = dish.Y + 50;
            coord[2].Y.X = dish.X + 140; coord[2].Y.Y = dish.Y + 50;
            //к 3 философу
            coord_left[2].X.X = dish.X + 260; coord_left[2].X.Y = dish.Y - 20;
            coord_left[2].Y.X = dish.X + 140; coord_left[2].Y.Y = dish.Y - 20;
            //к 4 философу
            coord_right[2].X.X = dish.X + 270; coord_right[2].X.Y = dish.Y + 140;
            coord_right[2].Y.X = dish.X + 150; coord_right[2].Y.Y = dish.Y + 140;

            //4 палочка
            coord[3].X.X = dish.X + 100; coord[3].X.Y = dish.Y + 240;
            coord[3].Y.X = dish.X + 70; coord[3].Y.Y = dish.Y + 130;
            //к 4 философу
            coord_left[3].X.X = dish.X + 190; coord_left[3].X.Y = dish.Y + 240;
            coord_left[3].Y.X = dish.X + 160; coord_left[3].Y.Y = dish.Y + 130;
            //к 5 философу
            coord_right[3].X.X = dish.X + 30; coord_right[3].X.Y = dish.Y + 260;
            coord_right[3].Y.X = dish.X; coord_right[3].Y.Y = dish.Y + 150;

            //5 палочка
            coord[4].X.X = dish.X - 140; coord[4].X.Y = dish.Y + 180;
            coord[4].Y.X = dish.X - 30; coord[4].Y.Y = dish.Y + 110;
            //к 5 философу
            coord_left[4].X.X = dish.X - 90; coord_left[4].X.Y = dish.Y + 220;
            coord_left[4].Y.X = dish.X + 20; coord_left[4].Y.Y = dish.Y + 150;
            //к 1 философу
            coord_right[4].X.X = dish.X - 170; coord_right[4].X.Y = dish.Y + 110;
            coord_right[4].Y.X = dish.X - 60; coord_right[4].Y.Y = dish.Y + 50;

            for (int i = 0; i < N; i++) coord_[i] = coord[i];
        }

        public void philosopher(int i)
        {
            while (true)
            {
                if (!start) continue;
                else
                {
                    think(i);
                    take_forks(i); //берёт обе вилки или блокируется
                    eat(i);
                    put_forks(i); //освобождает обе вилки
                    if (!wait[i]) Thread.Sleep(timeThreads[i]);
                }
            }
        }

        public void test_script1(int i) //для голодной смерти
        {
            while (!start) continue;
            int LEFT = (i - 1) % N;
            if (LEFT < 0) LEFT = N - 1;
            int RIGHT = (i + 1) % N;
            if (state[i] == HUNGRY && state[LEFT] != EATING)
            {
                Thread.Sleep(100);
                state[i] = EATING;
                takeSticks_right(LEFT);
                if (state[RIGHT] != EATING)
                {
                    if (RIGHT - 1 < 0) RIGHT = N;
                    takeSticks_left(RIGHT - 1);
                    i++;
                    textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " взял палочки\r\n")));
                    i--;
                    //разблокируем философа
                    if (wait[i])
                    {
                        wait[i] = false;
                    }
                }
                else
                {
                    i++;
                    if (!wait[i - 1]) textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " ждёт палочку\r\n")));
                    i--;
                    wait[i] = true;
                }
            }
            else if (state[i] == HUNGRY)
            {
                i++;
                if (!wait[i - 1]) textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " ждёт палочку\r\n")));
                i--;
                wait[i] = true;
            }
        }

        public void test_script2(int i) //для заговора соседей
        {
            while (!start) continue;
            int LEFT = (i - 1) % N;
            if (LEFT < 0) LEFT = N - 1;
            int RIGHT = (i + 1) % N;
            if (state[i] == EATING && state[LEFT] != EATING && state[RIGHT] != EATING)
            {
                state[i] = EATING;
                takeSticks_right(LEFT);
                if (RIGHT - 1 < 0) RIGHT = N;
                takeSticks_left(RIGHT - 1);
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " взял палочки\r\n")));
                i--;
                //разблокируем философа
                if (wait[i])
                {
                    wait[i] = false;
                }
            }
            else if (state[i] == HUNGRY)
            {
                i++;
                if (!wait[i - 1]) textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " ждёт палочки\r\n")));
                i--;
                wait[i] = true;
            }
        }

        public void put_forks_script2(int i) //для заговора соседей
        {
            while (!start) continue;
            if (!wait[i])
            {
                int LEFT = (i - 1) % N;
                if (LEFT < 0) LEFT = N - 1;
                int RIGHT = (i + 1) % N;
                //двигаем палочки обратно
                putSticks(LEFT);
                if (RIGHT - 1 < 0) RIGHT = N;
                putSticks(RIGHT - 1);
                if (i == 1) state[3] = EATING;
                if (i == 3) state[1] = EATING;

                lock_(i);
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " положил палочки и думает\r\n")));
                i--;
                state[i] = THINKING;
                this.Invoke((MethodInvoker)delegate
                {
                    this.Invalidate();
                    this.Update();
                });
                state[1] = EATING;
                state[3] = EATING;
                unlock_(i);
            }
        }

        public void think(int i)
        {
            while (!start) continue;
            if (!wait[i])
            {
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " думает\r\n")));
                i--;
                Thread.Sleep(timeThreads[i]);
            }
        }

        public void take_forks(int i)
        {
            while (!start) continue;
            if (!wait[i])
            {
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " проголодался\r\n")));
                i--;
                lock_(i);
                state[i] = HUNGRY;
                if (script2 && (i == 1 || i == 3))  state[i] = EATING;
                this.Invoke((MethodInvoker)delegate
                {
                    this.Invalidate();
                    this.Update();
                });
                if (script1) test_script1(i);
                else if (script2) test_script2(i);
                else test(i); //попытка взять обе вилки
                unlock_(i);
            }
            else if (wait[i])
            {
                lock_(i);
                if (script1) test_script1(i);
                else if (script2) test_script2(i);
                else test(i); //попытка взять обе вилки
                unlock_(i);
            }
        }

        public void test(int i)
        {
            while (!start) continue;
            int LEFT = (i - 1) % N;
            if (LEFT < 0) LEFT = N - 1;
            int RIGHT = (i + 1) % N;
            if (state[i] == HUNGRY && state[LEFT] != EATING && state[RIGHT] != EATING)
            {
                state[i] = EATING;
                takeSticks_right(LEFT);
                if (RIGHT - 1 < 0) RIGHT = N;
                takeSticks_left(RIGHT - 1);
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " взял палочки\r\n")));
                i--;
                //разблокируем философа
                if (wait[i])
                {
                    wait[i] = false;
                }
            }
            else if (state[i] == HUNGRY)
            {
                i++;
                if (!wait[i - 1]) textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " ждёт палочки\r\n")));
                i--;
                wait[i] = true;
            }
        }

        public void eat(int i)
        {
            while (!start) continue;
            if (!wait[i])
            {
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " ест\r\n")));
                i--;
                Thread.Sleep(timeThreads[i]);
            }
        }

        public void put_forks(int i)
        {
            while (!start) continue;
            if (!wait[i])
            {
                int LEFT = (i - 1) % N;
                if (LEFT < 0) LEFT = N - 1;
                int RIGHT = (i + 1) % N;
                //двигаем палочки обратно
                if (script2) put_forks_script2(LEFT);
                else putSticks(LEFT);
                if (RIGHT - 1 < 0) RIGHT = N;
                if (script2) put_forks_script2(RIGHT - 1);
                else putSticks(RIGHT - 1);

                lock_(i);
                i++;
                textBoxInfo.Invoke(new Action(() => textBoxInfo.AppendText("Философ " + i + " положил палочки и думает\r\n")));
                i--;
                state[i] = THINKING;
                this.Invoke((MethodInvoker)delegate
                {
                    this.Invalidate();
                    this.Update();
                });
                if (!script2)
                {
                    test(LEFT); //проверка, может ли левый сосед есть
                    test((i + 1) % N); //проверка, может ли правый сосед есть
                }
                unlock_(i);
            }
        }

        public void lock_(int i)
        {
            for (int j = 0; j < N; j++)
            {
                turn[j] = i;
                flag[i] = j;
                bool per = false;
                while (per) //для продвижения в очереди соревнуемся с другими потоками
                {
                    int count = 0;
                    for (int k=0;k<N; k++)
                    {
                        if (k != i && flag[k] < j) count++;
                    }
                    if (count != 0 || turn[j] != i) per = false;
                    else per = true;
                }
            }
        }

        public void unlock_(int i)
        {
            flag[i] = -1;
        }

        private void button1_Click(object sender, EventArgs e) //основной старт
        {
            textBoxInfo.AppendText("Потоки запущены\r\n");
            speed();
            script1 = false;
            script2 = false;
            start = true;
            if (ph1 != null)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonPause.Enabled = true;
                buttonScript1.Enabled = false;
                buttonScript2.Enabled = false;
                return;
            }
            textBoxInfo.Clear();
            textBoxInfo.AppendText("Потоки запущены\r\n");

            starting_position();
            this.Invoke((MethodInvoker)delegate
            {
                this.Invalidate();
                this.Update();
            });

            var threadParam = new System.Threading.ThreadStart(delegate { philosopher(0); });
            ph1 = new Thread(threadParam);
            ph1.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(1); });
            ph2 = new Thread(threadParam);
            ph2.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(2); });
            ph3 = new Thread(threadParam);
            ph3.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(3); });
            ph4 = new Thread(threadParam);
            ph4.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(4); });
            ph5 = new Thread(threadParam);
            ph5.Start();

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = true;
            buttonScript1.Enabled = false;
            buttonScript2.Enabled = false;
        }

        private void buttonStopThread1_Click(object sender, EventArgs e) //останов
        {
            textBoxInfo.AppendText("Потоки завершены\r\n");
            start = false;
            script1 = false;
            script2 = false;
            if (ph1 != null) ph1.Abort();
            ph1 = null;
            ph2.Abort();
            ph2 = null;
            ph3.Abort();
            ph3 = null;
            ph4.Abort();
            ph4 = null;
            if (ph5 != null) ph5.Abort();
            ph5 = null;
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonPause.Enabled = false;
            buttonScript1.Enabled = true;
            buttonScript2.Enabled = true;
            for (int i=0; i<N; i++)
            {
                state[i] = 0;
                turn[i] = 0;
                flag[i] = -1;
                wait[i] = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void trackBarThread1_Scroll(object sender, EventArgs e)
        {
            timeThreads[0] = (int)trackBarThread1.Value;
        }

        private void trackBarThread2_Scroll(object sender, EventArgs e)
        {
            timeThreads[1] = (int)trackBarThread2.Value;
        }

        private void trackBarThread3_Scroll(object sender, EventArgs e)
        {
            timeThreads[2] = (int)trackBarThread3.Value;
        }

        private void trackBarThread4_Scroll(object sender, EventArgs e)
        {
            timeThreads[3] = (int)trackBarThread4.Value;
        }

        private void trackBarThread5_Scroll(object sender, EventArgs e)
        {
            timeThreads[4] = (int)trackBarThread5.Value;
        }

        private void buttonPause_Click(object sender, EventArgs e) //пауза
        {
            textBoxInfo.AppendText("Потоки приостановлены\r\n");
            start = false;
            buttonStart.Enabled = true;
            buttonStop.Enabled = true;
            buttonPause.Enabled = false;
            buttonScript1.Enabled = false;
            buttonScript2.Enabled = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void buttonScript1_Click(object sender, EventArgs e) //голодная смерть
        {
            start = true;
            script1 = true;
            textBoxInfo.Clear();
            textBoxInfo.AppendText("Потоки запущены\r\n");

            for (int i=0; i<timeThreads.Length; i++)
            {
                timeThreads[i] = 5500;
            }
            starting_position();
            this.Invoke((MethodInvoker)delegate
            {
                this.Invalidate();
                this.Update();
            });

            var threadParam = new System.Threading.ThreadStart(delegate { philosopher(0); });
            ph1 = new Thread(threadParam);
            ph1.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(1); });
            ph2 = new Thread(threadParam);
            ph2.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(2); });
            ph3 = new Thread(threadParam);
            ph3.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(3); });
            ph4 = new Thread(threadParam);
            ph4.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(4); });
            ph5 = new Thread(threadParam);
            ph5.Start();

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = false;
            buttonScript1.Enabled = false;
            buttonScript2.Enabled = false;

            no_speed();
        }

        private void no_speed()
        {
            trackBarThread1.Enabled = false;
            trackBarThread2.Enabled = false;
            trackBarThread3.Enabled = false;
            trackBarThread4.Enabled = false;
            trackBarThread5.Enabled = false;
        }

        private void speed()
        {
            trackBarThread1.Enabled = true;
            timeThreads[0] = (int)trackBarThread1.Value;
            trackBarThread2.Enabled = true;
            timeThreads[1] = (int)trackBarThread2.Value;
            trackBarThread3.Enabled = true;
            timeThreads[2] = (int)trackBarThread3.Value;
            trackBarThread4.Enabled = true;
            timeThreads[3] = (int)trackBarThread4.Value;
            trackBarThread5.Enabled = true;
            timeThreads[4] = (int)trackBarThread5.Value;
        }

        private void buttonScript2_Click(object sender, EventArgs e) //заговор соседей
        {
            start = true;
            script2 = true;
            textBoxInfo.Clear();
            textBoxInfo.AppendText("Потоки запущены\r\n");

            timeThreads[1] = 1999;
            timeThreads[2] = 9000;
            timeThreads[3] = 4001;
            starting_position();
            this.Invoke((MethodInvoker)delegate
            {
                this.Invalidate();
                this.Update();
            });

            var threadParam = new System.Threading.ThreadStart(delegate { philosopher(1); });
            ph2 = new Thread(threadParam);
            ph2.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(2); });
            ph3 = new Thread(threadParam);
            ph3.Start();

            threadParam = new System.Threading.ThreadStart(delegate { philosopher(3); });
            ph4 = new Thread(threadParam);
            ph4.Start();

            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            buttonPause.Enabled = false;
            buttonScript1.Enabled = false;
            buttonScript2.Enabled = false;

            no_speed();
        }
    }
}
