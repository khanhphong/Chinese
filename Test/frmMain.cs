using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdPinyinNumber_Click(object sender, EventArgs e)
        {
            PinyinChinese.ChineseSoapClient obj = new PinyinChinese.ChineseSoapClient();
            txtPinyin.Text = obj.GetPinyinWithNumber(txtChinese.Text.Trim());
        }

        private void cmdPinyinMark_Click(object sender, EventArgs e)
        {
            try
            {
                PinyinChinese.ChineseSoapClient obj = new PinyinChinese.ChineseSoapClient();
                txtPinyin.Text = obj.GetPinyinWithMark(txtChinese.Text.Trim());
            }
            catch { }
        }

        private void cmdTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                PinyinChinese.ChineseSoapClient obj = new PinyinChinese.ChineseSoapClient();
                txtVietnamese.Text = obj.TranslateToVietnamese(txtChinese.Text.Trim()).Trim();
            }
            catch { }
        }
    }
}
