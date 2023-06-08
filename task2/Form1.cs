﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class frmDiagrams : Form
    {
        int mGist, mRound;
        int minAge, minYear;
        double Sum;

        private void btCreateMasGist_Click(object sender, EventArgs e)
        {
            if (txtMasGist.Text == "" || txtMinYear.Text == "")
            { MessageBox.Show("Не всі дані введено!", "Помилка"); }
            else
            {
                minYear = Int32.Parse(txtMinYear.Text);
                mGist = Int32.Parse(txtMasGist.Text);

                if (minYear < 2000)
                { MessageBox.Show("Рік початку курсів - 2000-й!", "Помилка"); }
                else
                {
                    dgvMasGist.ColumnCount = mGist;
                    for (int j = 0; j < mGist; j++)
                    {
                        dgvMasGist.Columns[j].Width = 110;

                        dgvMasGist.ColumnHeadersDefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleCenter;

                        dgvMasGist.Columns[j].HeaderText = minYear.ToString() + "рік";
                        minYear++;
                    }
                }
            }
        }

        private void btCreateMasRound_Click(object sender, EventArgs e)
        {
            if (txtMasRound.Text == "" || txtMinAge.Text == "")
            { MessageBox.Show("Не всі дані введено!", "Помилка"); }
            else
            {
                mRound = Int32.Parse(txtMasRound.Text);
                minAge = Int32.Parse(txtMinAge.Text);

                if (minAge < 10)
                { MessageBox.Show("Мінімальний вік для курсів - 10 років!", "Помилка"); }
                else
                {
                    dgvMasRound.ColumnCount = mRound;
                    for (int j = 0; j < mRound; j++)
                    {
                        dgvMasRound.Columns[j].Width = 180;
                        dgvMasRound.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvMasRound.Columns[j].HeaderText = " Вік. катег. (" + minAge.ToString() + ")";
                        minAge++;
                    }
                }
            }
        }

        private void btCreateRound_Click(object sender, EventArgs e)
        {
            Sum = 0;
            double[] A = new double[mRound];
            string[] B = new string[mRound];
            minAge = minAge - mRound;

            for (int j = 0; j < mRound; j++)
            {
                A[j] = Convert.ToDouble(dgvMasRound.Rows[0].Cells[j].Value);
                B[j] = "Вік. катег. (" + minAge.ToString() + ")";
                Sum += A[j];
                minAge++;
                if (A[j] <= 0)
                { MessageBox.Show("Серед введених елементів є негативні або нульові!", "Помилка"); }
            }

            if (Sum != 100)
            { MessageBox.Show("Сума відсоткового відношення віку повинна дорівнювати 100%! Перевірте дані!", "Помилка"); }
            else
            {
                chartDiagrams.Series[1].Points.DataBindXY(B, A);
                chartDiagrams.ChartAreas[1].Area3DStyle.Enable3D = true;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCreateGist_Click(object sender, EventArgs e)
        {
            int[] C = new int[mGist];
            int[] D = new int[mGist];
            minYear = minYear - mGist;

            for (int j = 0; j < mGist; j++)
            {
                C[j] = Convert.ToInt32(dgvMasGist.Rows[0].Cells[j].Value);
                D[j] = minYear;
                minYear++;
                if (C[j] < 0)
                { MessageBox.Show("Серед введених елементів є негативні!", "Помилкака"); }
            }

            chartDiagrams.Series[0].Points.DataBindXY(D, C);
        }

        public frmDiagrams()
        {
            InitializeComponent();
        }

        private void txtMinYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
