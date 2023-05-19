using System;
using System.Windows.Forms;
using System.Timers;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        int h, m, s, ms;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            label2.Text = "00:00:00:000";
        }

        public Form1()
        {
            InitializeComponent();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 10;
                if (ms >= 1000)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
            }));

            label2.Invoke(new Action(() => {
                label2.Text = $"{h:00}:{m:00}:{s:00}:{ms:000}";
            }));
        }
    }
}
