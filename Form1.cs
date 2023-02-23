using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin_Stoicho
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

        private void btn_predavane_Click(object sender, EventArgs e)
        {
            string janr = "";
            string korica = "";
            if (rb_hudojestvena.Checked)
            {
                janr = "художествена";
            }
            else if (rb_nauchno.Checked)
            {
                janr = "научно-популярна";
            }
            else if (rb_spravochna.Checked)
            {
                janr = "справочна";
            }

            if (cb_tvurda.Checked)
            {
                korica = "твърда";
            }
            else
            {
                korica = "мека";
            }


            if (txtbox_avtor.Text == "")
            {
                MessageBox.Show("Не си записал автор на книгата.");
            }
            else if (txtbox_zaglavie.Text == "")
            {
                MessageBox.Show("Не си записал заглавие на книгата.");
            }
            else if (cmb_izdatelstvo.Text == "")
            {
                MessageBox.Show("Не си избрал издателство на книгата.");
            }
            else if (!rb_hudojestvena.Checked && !rb_nauchno.Checked && !rb_spravochna.Checked)
            {
                MessageBox.Show("Не си избрал жанр на книгата.");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show($"Вие въведохте {txtbox_zaglavie.Text} с автор {txtbox_avtor.Text}, {janr} литература с {korica} корица от издателство {cmb_izdatelstvo.Text}. Потвърждавате ли?", "Въвеждане:", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Въведено!");
                    txtbox_avtor.Text = "";
                    txtbox_zaglavie.Text = "";
                    cmb_izdatelstvo.Text = "";
                    rb_hudojestvena.Checked = false;
                    rb_nauchno.Checked = false;
                    rb_spravochna.Checked = false;
                    cb_tvurda.Checked = false;
                }

            }
        }

        private void txtbox_avtor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
