using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasBaru9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pilihan = 0;
            int jumlah = 0;
            int totalHarga = 0;

            try
            {
                pilihan = int.Parse(txtPilihan.Text);
                jumlah = int.Parse(txtJumlah.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukkan angka yang valid untuk Pilihan dan Jumlah");
                return;
            }

          
            switch (pilihan)
            {
                case 1:
                    totalHarga = 5000 * jumlah; // Cilok
                    break;
                case 2:
                    totalHarga = 4000 * jumlah; // Cireng
                    break;
                case 3:
                    totalHarga = 5000 * jumlah; // Karedok Basreng
                    break;
                case 4:
                    totalHarga = 4000 * jumlah; // Cibay
                    break;
                default:
                    MessageBox.Show("Pilihan tidak valid! Masukkan angka antara 1-4.");
                    return;
            }

            
            txtTotal.Text = "Rp " + totalHarga.ToString();
        }
    }
    }

