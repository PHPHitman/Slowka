﻿using Slowka.SlowkaKlasy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slowka
{
    public partial class AddNewWord : Form
    {
        
        public AddNewWord()
        {
            InitializeComponent();
        }
        EnglishWords s = new EnglishWords();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pobieranie wartości z pól
            s.Slowko = textBox1.Text;
            s.Tlumaczenie = textBox2.Text;
            s.Kategoria = comboBox1.Text;

            //Przesyłanie danych do bazy używając metod
            bool success = s.Insert(s);
            if (success == true)
            {
                //Powodzenie
                MessageBox.Show("Dodano nowe słówko");
            }
            else
            {
                MessageBox.Show("Niepowodzenie. Spróbuj ponownie");
            }
        }
    }
}