﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareasAsincronasWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Ejecutar(ProgressBar progressbar, TextBox label)
        {
            IProgress<int> progress = new Progress<int>(item => {
                progressbar.Value = item;
                label.Text = $"{item}%";
            });

            Task.Run(() => {

                for (int i = 0; i < 100; i++)
                {
                    progress.Report(i);
                    Thread.Sleep(70);
                }
                progress.Report(100);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejecutar(progreso1, lblprogreso);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ejecutar(progreso2, lblprogreso2);
        }
    }
}
