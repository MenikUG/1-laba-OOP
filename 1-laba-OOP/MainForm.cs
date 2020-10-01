using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_laba_OOP
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();

        int kol;
        private void button_Hello_Click(object sender, EventArgs e)
        {
            kol = Convert.ToInt32(kolich.Text);
            if (kol < 10)
            {
                kol += 1;
                kolich.Text = kol.ToString();
                progressBar1.Value = Convert.ToInt32(kolich.Text);
                if (kol == 10)
                    pbfull.Visible = true;

            }
            else
            {
                MessageBox.Show("Progress Bar достиг максимума",
                    "WARNING",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                    );
            }

        }
        private void Reset_Click(object sender, EventArgs e)
        {
            kolich.Text = 0.ToString();
            progressBar1.Value = 0;
            pbfull.Visible = false;
        }

        private void poleinput_TextChanged(object sender, EventArgs e)
        {
            polerepeat.Text = poleinput.Text;
        }

        private void polerepeat_TextChanged(object sender, EventArgs e)
        {
            poleinput.Text = polerepeat.Text;
        }

        private void listcolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectColor = listcolor.SelectedItem.ToString();
            switch (selectColor)
            {
                case ("Красный"):
                    pagelist_1.BackColor = Color.Red;
                    text4.ForeColor = Color.Red;
                    break;
                case ("Оранжевый"):
                    pagelist_1.BackColor = Color.Orange;
                    text4.ForeColor = Color.Orange;
                    break;
                case ("Жёлтый"):
                    pagelist_1.BackColor = Color.Yellow;
                    text4.ForeColor = Color.Yellow;
                    break;
                case ("Зелёный"):
                    pagelist_1.BackColor = Color.Green;
                    text4.ForeColor = Color.Green;
                    break;
                case ("Голубой"):
                    pagelist_1.BackColor = Color.Blue;
                    text4.ForeColor = Color.Blue;
                    break;
                case ("Синий"):
                    pagelist_1.BackColor = Color.DarkBlue;
                    text4.ForeColor = Color.DarkBlue;
                    break;
                case ("Фиолетовый"):
                    pagelist_1.BackColor = Color.Purple;
                    text4.ForeColor = Color.Purple;
                    break;
                case ("Белый"):
                    pagelist_1.BackColor = Color.White;
                    text4.ForeColor = Color.White;
                    break;
                case ("Черный"):
                    pagelist_1.BackColor = Color.Black;
                    text4.ForeColor = Color.Black;
                    break;
                case ("Серый"):
                    pagelist_1.BackColor = Color.Gray;
                    text4.ForeColor = Color.Gray;
                    break;
            }
        }

        private void countrylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selecteditem = countrylist.SelectedItems[0].Text;
                if (selecteditem != null)
                {
                    DialogResult result = MessageBox.Show(
                    "Вы уверены что хотите перейти на сайт",
                    "Выбор",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    if (result == DialogResult.Yes)
                    {
                        switch (selecteditem)
                        {
                            case ("Russia"):
                                System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Russia");
                                break;
                            case ("China"):
                                System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/China");
                                break;
                            case ("Belarusian"):
                                System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/Belarus");
                                break;
                            case ("German"):
                                System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/German");
                                break;
                            case ("America"):
                                System.Diagnostics.Process.Start("https://ru.wikipedia.org/wiki/America");
                                break;
                        }
                    }

                }
            }
            catch { }
        }

        private void CHECK_Click(object sender, EventArgs e)
        {
            if ((checkedListBox.GetItemChecked(0) == true) && (checkedListBox.GetItemChecked(1) == true) && (checkedListBox.GetItemChecked(2) == true) && (checkedListBox.GetItemChecked(3) == true) && (checkedListBox.GetItemChecked(4) == true))
            {
                picture.Image = global::_1_laba_OOP.Properties.Resources.CONGRATULATION;
            }
            else picture.Image = global::_1_laba_OOP.Properties.Resources.Dont;
        }

        private void CPU_Click(object sender, EventArgs e)
        {
            picture.Image = global::_1_laba_OOP.Properties.Resources.xeon_d_2100_2x1;
            checkedListBox.SetItemChecked(3, true);
        }

        private void GPU_Click(object sender, EventArgs e)
        {
            picture.Image = global::_1_laba_OOP.Properties.Resources.rtx3090;
            checkedListBox.SetItemChecked(4, true);
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (Info.Checked == true)
                checkedListBox.SetItemChecked(1, true);
            else checkedListBox.SetItemChecked(1, false);
        }

        private void Galka_Click(object sender, EventArgs e)
        {
            if (Galka.Checked == true)
                checkedListBox.SetItemChecked(2, true);
            else checkedListBox.SetItemChecked(2, false);
        }

        private void main_Click(object sender, EventArgs e)
        {
            checkedListBox.SetItemChecked(0, true);
        }

        Bitmap bitmap1;
        private void btn_selectPicture_Click(object sender, EventArgs e)
        {
            if (openPicture.ShowDialog() == DialogResult.Cancel)
                return;
            pictureturn.ImageLocation = openPicture.FileName;
            bitmap1 = (Bitmap)Bitmap.FromFile(openPicture.FileName);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bitmap1.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureturn.Image = bitmap1;
            pictureturn.Refresh();
        }
    }
    

}
