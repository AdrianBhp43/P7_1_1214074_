using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214074_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(800, 377);
        }

        private void btnPilihanMatkul_Click(object sender, EventArgs e)
        {
            if (tbNim.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbLakiLaki.Checked || rbPerempuan.Checked)
                    {
                        if (tbAlamat.Text != "")
                        {
                            if (cbProgramStudi.Text != "")
                            {
                                if (tbTahunAkademik.Text != "")
                                {
                                    if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
                                    {
                                        if (tbSemester.Text != "")
                                        {
                                            if ((tbSemester.Text).All(Char.IsNumber))
                                            {
                                                MessageBox.Show(
                                                "Sudah Berhasil Diisi !",
                                                "Informasi Data Submit",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Size = new Size(800, 714);
                                            }
                                            else
                                            {
                                                MessageBox.Show(
                                                "Inputan Semester Hanya Boleh Angka !",
                                                "Informasi Data Submit",
                                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show(
                                            "Semester Belum Diisi !",
                                            "Informasi Data Submit",
                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(
                                       "Format Tahun akademik salah !",
                                       "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(
                               "Tahun Akademik Belum Diisi !",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                "Program Studi  Belum Diisi !",
                                 "Informasi Data Submit",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                            "Alamat Belum Diisi !",
                            "Informasi Data Submit",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                        "Jenis Kelamin Belum Diisi !",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(
                    "Nama Belum Diisi !",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(
                "NIM Belum Diisi !",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTahunAkademik_TextChanged(object sender, EventArgs e)
        {
            if (tbTahunAkademik.Text =="")
            {
                epWrong.SetError(tbTahunAkademik, "");
            }
            else
            {
                if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
                {
                    epWrong.SetError(tbTahunAkademik, "");

                }
                else
                {
                    epWrong.SetError(tbTahunAkademik, "Format Akademik salah!\nContoh: nnnn/nnnn ");

                }
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")
            {
                epWrong.SetError(tbSemester, "");
            }
            else
            {
                if ((tbSemester.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbSemester, "");
                }
                else
                {
                    epWrong.SetError(tbSemester, "Inputan Semester Hanya Boleh Angka!");
                }
            }
        }


        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rb3.Checked)
            {
                cb1.Enabled = true; cb1.Checked = false;
                cb2.Enabled = true; cb2.Checked = false;

                cb3.Enabled = true; cb3.Checked = false;

                cb4.Enabled = true; cb4.Checked = false;

                cb5.Enabled = true; cb5.Checked = false;

                cb6.Enabled = true; cb6.Checked = false;

                cb7.Enabled = true; cb7.Checked = false;

                cb8.Enabled = true; cb8.Checked = false;

                cb9.Enabled = false; cb9.Checked = false;

                cb10.Enabled = true; cb10.Checked = false;

                cb11.Enabled = true; cb11.Checked = false;

                cb12.Enabled = false; cb12.Checked = false;

            }
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;

                cb2.Enabled = true; cb1.Checked = false;

                cb3.Enabled = true; cb1.Checked = false;

                cb4.Enabled = true; cb1.Checked = false;

                cb5.Enabled = true; cb1.Checked = false;

                cb6.Enabled = true; cb1.Checked = false;

                cb7.Enabled = true; cb1.Checked = false;

                cb8.Enabled = true; cb1.Checked = false;

                cb9.Enabled = false; cb1.Checked = false;

                cb10.Enabled = true; cb1.Checked = false;

                cb11.Enabled = true; cb1.Checked = false;

                cb12.Enabled = true; cb1.Checked = false;

            }
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb5.Checked)
            {
                cb1.Enabled = false; cb1.Checked = false;

                cb2.Enabled = true; cb1.Checked = false;

                cb3.Enabled = true; cb1.Checked = false;

                cb4.Enabled = true; cb1.Checked = false;

                cb5.Enabled = true; cb1.Checked = false;

                cb6.Enabled = true; cb1.Checked = false;

                cb7.Enabled = true; cb1.Checked = false;

                cb8.Enabled = true; cb1.Checked = false;

                cb9.Enabled = true; cb1.Checked = false;

                cb10.Enabled = true; cb1.Checked = false;

                cb11.Enabled = true; cb1.Checked = false;

                cb12.Enabled = false; cb1.Checked = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string JenisKelamin = null;
            if (rbLakiLaki.Checked)
            {
                JenisKelamin = rbLakiLaki.Text;
            }
            else
            {
                JenisKelamin = rbPerempuan.Text;
            }

            string Kurikulum = null;

            if (rb3.Checked)
            {
                Kurikulum = rb3.Text;
            }
            else if (rb4.Checked)
            {
                Kurikulum = rb4.Text;
            }
            else 
            {
                Kurikulum = rb5.Text;
            }

            string MataKuliah = null;

            if (cb1.Checked)
            {
                MataKuliah += cb1.Text + ", ";
            }
            if (cb2.Checked)
            {
                MataKuliah += cb2.Text + ", ";
            }
            if (cb3.Checked)
            {
                MataKuliah += cb3.Text + ", ";
            }
            if (cb4.Checked)
            {
                MataKuliah += cb4.Text + ", ";
            }
            if (cb5.Checked)
            {
                MataKuliah += cb5.Text + ", ";
            }
            if (cb6.Checked)
            {
                MataKuliah += cb6.Text + ", ";
            }
            if (cb7.Checked)
            {
                MataKuliah += cb7.Text + ", ";
            }
            if (cb8.Checked)
            {
                MataKuliah += cb8.Text + ", ";
            }
            if (cb9.Checked)
            {
                MataKuliah += cb9.Text + ", ";
            }
            if (cb10.Checked)
            {
                MataKuliah += cb10.Text + ", ";
            }
            if (cb10.Checked)
            {
                MataKuliah += cb10.Text + ", ";
            }
            if (cb11.Checked)
            {
                MataKuliah += cb11.Text + ", ";
            }
            if (cb12.Checked)
            {
                MataKuliah += cb12.Text + ", ";
            }
            else
            {
                MessageBox.Show
                ("NIM : " + tbNim.Text +
                "\nName : " + tbNama.Text +
                "\nJenis Kelamin : " + JenisKelamin +
                "\nAlamat : " + tbAlamat +
                "\nProgram Studi : " + cbProgramStudi +
                "\nTahun Akademik : " + tbTahunAkademik +
                "\nSemester: " + tbSemester +
                "\nKurikikulum : " + Kurikulum +
                "\nMata Kuliah : " + MataKuliah, 
                "Data Telah Di Input",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbNim.Clear();
            tbNama.Clear();
            rbLakiLaki.Checked = false;
            rbPerempuan.Checked = false;
            tbAlamat.Clear();
            cbProgramStudi.ResetText();
            tbTahunAkademik.Clear();
            tbSemester.Clear();
            rb3.Checked = false;
            rb4.Checked = false;
            rb5.Checked = false;
            rb4.Checked = false;
            cb1.Enabled = false; 
            cb2.Enabled = false;
            cb3.Enabled = false; 
            cb4.Enabled = false; 
            cb5.Enabled = false; 
            cb6.Enabled = false; 
            cb7.Enabled = false; 
            cb8.Enabled = false; 
            cb9.Enabled = false; 
            cb10.Enabled = false;
            cb11.Enabled = false;
            cb12.Enabled = false;
            this.Size = new Size(800, 377);
        }
    }
}