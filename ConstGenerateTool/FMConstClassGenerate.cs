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
            txtRegex.Text = Enum.RegexExample.A;

            var cbxTypeSource = new List<KeyValuePair<string, string>>();
            cbxTypeSource.Add(new KeyValuePair<string, string>("", "--请选择--"));
            cbxTypeSource.AddRange(Enum.PropertyType.GetList());
            cbxType.DataSource = cbxTypeSource;
            cbxType.DisplayMember = "Value";
            cbxType.ValueMember = "Key";
        }

        #endregion

        #region Event

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var properties = ConstGenerateUtil.ConvertTextToPropertyList(txtRegex.Text, rtxtInput.Text);
            if (properties == null || properties.Count == 0)
            {
                return;
            }

            var generateResult = ConstGenerateUtil.CreateConstClassProperties(txtClassName.Text, cbxType.SelectedValue.ToString(), txtPre.Text, properties);
            if (generateResult == null)
            {
                return;
            }

            rtxtFinalConst.Text = generateResult.ConstClassString;
            if (string.IsNullOrEmpty(cbxType.SelectedValue.ToString()))
            {
                cbxType.SelectedValue = generateResult.PropertyType;
            }
        }

        private void lblRegex_Click(object sender, EventArgs e)
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

        #endregion
    }
}
