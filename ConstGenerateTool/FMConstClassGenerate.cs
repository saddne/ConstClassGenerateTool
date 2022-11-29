using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstGenerateTool
{
    public partial class FMConstClassGenerate : Form
    {
        #region Win

        public FMConstClassGenerate()
        {
            InitializeComponent();
        }

        private void FMConstClassGenerate_Load(object sender, EventArgs e)
        {                 
            InitForm();
        }

        private void InitForm()
        {
            lblA.Text = Enum.RegexExample.A + "\r\n" + "（例：A:1|成功；B:2|失败）";
            lblB.Text = Enum.RegexExample.B + "\r\n" + "（例：A:1;B:2）";
        }

        #endregion

        #region Button

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var properties = ConstGenerateUtil.ConvertTextToPropertyList(txtRegex.Text, rtxtInput.Text);
            if (properties == null || properties.Count == 0)
            {
                return;
            }

            rtxtFinalConst.Text = ConstGenerateUtil.CreateConstClassProperties(txtClassName.Text, txtClassSummary.Text, txtPre.Text, properties);
        }

        #endregion

        private void LblRegex_DoubleClick(object sender, EventArgs e)
        {
            var tag = ((Label)sender).Tag;
            switch (tag)
            {
                case "A":
                    txtRegex.Text = Enum.RegexExample.A;
                    break;
                case "B":
                    txtRegex.Text = Enum.RegexExample.B;
                    break;
                default:
                    break;
            }
        }
    }
}
