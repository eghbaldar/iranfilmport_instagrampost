using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeforePostingIFP
{
    public partial class Form1 : Form
    {
        int maxValue;
        int MaxComment = 500;
        public Form1()
        {
            InitializeComponent();
            maxValue = int.Parse(txtMaxChar.Text) - (txtTags.Text.Length);
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
           try
            {
                if (!(txtOriginal.Text.Trim().Substring(0, 3) == "..."))
                {
                    MessageBox.Show("سه نقطه اولیه را اضافه نکرده اید");
                    return;
                }
                ////////////////////
                if (txtOriginal.Text.Length > maxValue)
                {
                    var originl = txtOriginal.Text;
                    txtOriginal.Text = originl.Substring(0, maxValue) + Environment.NewLine + Environment.NewLine + txtTags.Text;

                    if (originl.Length > maxValue)
                    {
                        txtFirstComment.Text = originl.Substring(maxValue, (originl.Length - maxValue));
                    }
                    else
                    {
                        txtFirstComment.Clear();
                    }
                    ///////////////////////////////////////////////////
                    if (txtFirstComment.Text.Length > MaxComment)
                    {
                        originl = txtFirstComment.Text;
                        if (originl.Length > MaxComment)
                        {
                            txtSecondComment.Text = originl.Substring(MaxComment, originl.Length - MaxComment);
                            txtFirstComment.Text = originl.Substring(0, MaxComment);
                        }
                    }
                    else
                    {
                        txtSecondComment.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPastOriginal_Click(object sender, EventArgs e)
        {
            txtOriginal.Text = Clipboard.GetText();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtFirstComment.Clear();
            txtSecondComment.Clear();
            txtOriginal.Clear();
        }

        private void btnCopyOriginal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOriginal.Text);
        }

        private void btnCopyFirstComment_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtFirstComment.Text);
        }

        private void btnCopySecondComment_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSecondComment.Text);
        }
    }
}
