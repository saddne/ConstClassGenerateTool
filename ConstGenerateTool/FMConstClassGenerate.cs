using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Enum;
using Business.ConstClass;
using Business.RegexConfig;
using System.IO;

namespace ConstGenerateTool
{
    public partial class FMConstClassGenerate : Form
    {
        #region PropertiesInfo

        private RegexModel _RegexModel;

        #endregion

        #region Win

        public FMConstClassGenerate()
        {
            InitializeComponent();
        }

        private void FMConstClassGenerate_Load(object sender, EventArgs e)
        {
            _RegexModel = new RegexModel();
            _RegexModel.FilePath = Path.Combine(Application.StartupPath, FileName.RegexSaveFileName);
            _RegexModel.GetRegexFieldList();

            InitForm();
        }

        private void InitForm()
        {
            lblA.Text = RegexExample.A + "\r\n" + "S:系统,U:用户";
            lblB.Text = RegexExample.B + "\r\n" + "S:1|系统,U:2|用户";
            txtRegex.Text = RegexExample.A;

            var cbxSelectedTypeSource = new List<KeyValuePair<string, string>>();
            cbxSelectedTypeSource.Add(new KeyValuePair<string, string>("", "--请选择--"));
            cbxSelectedTypeSource.AddRange(PropertyType.GetList());
            cbxSelectedType.DataSource = cbxSelectedTypeSource;
            cbxSelectedType.DisplayMember = "Value";
            cbxSelectedType.ValueMember = "Key";

            RefreshForm();
        }

        private void RefreshForm()
        {
            if (_RegexModel.RegexFieldList != null && _RegexModel.RegexFieldList.Count > 0)
            {
                grBRegex.Visible = true;

                var cbxMyRegexSource = new List<KeyValuePair<string, string>>();
                cbxMyRegexSource.Add(new KeyValuePair<string, string>("", "--请选择--"));
                foreach (var item in _RegexModel.RegexFieldList)
                {
                    cbxMyRegexSource.Add(new KeyValuePair<string, string>(item.RegexText, item.RegexText));
                }
                cbxMyRegex.DataSource = cbxMyRegexSource;
                cbxMyRegex.DisplayMember = "Value";
                cbxMyRegex.ValueMember = "Key";
            }
            else
            {
                grBRegex.Visible = false;
            }
        }

        #endregion

        #region Event

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var fieldPattern = new FieldPattern
            {
                FieldPrefix = txtPre.Text,
                FieldType = cbxSelectedType.SelectedValue.ToString(),
                FieldNamePattern = txtFieldName.Text,
                FieldValuePattern = txtFieldValue.Text,
                FieldSummaryPattern = txtFieldSummary.Text,
            };

            var paraModel = new ConstClassParamModel
            {
                InputString = txtInput.Text,
                RegexPattern = txtRegex.Text,
                CustomFieldPattern = fieldPattern,
                ClassName = txtClassName.Text,
            };

            var result = ConstClassGenerator.Generate(paraModel);

            txtDefaultType.Text = paraModel.GeneratedFieldType;

            #region 属性

            paraModel.CustomFieldPattern.FieldNamePattern = !string.IsNullOrEmpty(paraModel.CustomFieldPattern.FieldNamePattern) ? paraModel.CustomFieldPattern.FieldNamePattern : paraModel.GenerateFieldPattern.FieldNamePattern;
            txtFieldName.Text = paraModel.CustomFieldPattern.FieldNamePattern;
            if (!paraModel.GenerateFieldPattern.FieldNamePattern.Equals(paraModel.CustomFieldPattern.FieldNamePattern))
            {
                txtFieldName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }
            else
            {
                txtFieldName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }

            paraModel.CustomFieldPattern.FieldValuePattern = !string.IsNullOrEmpty(paraModel.CustomFieldPattern.FieldValuePattern) ? paraModel.CustomFieldPattern.FieldValuePattern : paraModel.GenerateFieldPattern.FieldValuePattern;
            txtFieldValue.Text = paraModel.CustomFieldPattern.FieldValuePattern;
            if (!paraModel.GenerateFieldPattern.FieldValuePattern.Equals(paraModel.CustomFieldPattern.FieldValuePattern))
            {
                txtFieldValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }
            else
            {
                txtFieldValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }

            paraModel.CustomFieldPattern.FieldSummaryPattern = !string.IsNullOrEmpty(paraModel.CustomFieldPattern.FieldSummaryPattern) ? paraModel.CustomFieldPattern.FieldSummaryPattern : paraModel.GenerateFieldPattern.FieldSummaryPattern;
            txtFieldSummary.Text = paraModel.CustomFieldPattern.FieldSummaryPattern;
            if (!paraModel.GenerateFieldPattern.FieldSummaryPattern.Equals(paraModel.CustomFieldPattern.FieldSummaryPattern))
            {
                txtFieldSummary.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }
            else
            {
                txtFieldSummary.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            }

            #endregion

            if (!string.IsNullOrEmpty(result))
            {
                rtxtFinalConst.Text = result;

                Clipboard.SetDataObject(result);
                MessageBox.Show("已复制");
            }
        }

        private void lblRegex_Click(object sender, EventArgs e)
        {
            var tag = ((Label)sender).Tag;
            switch (tag)
            {
                case "A":
                    txtRegex.Text = RegexExample.A;
                    break;
                case "B":
                    txtRegex.Text = RegexExample.B;
                    break;
                default:
                    break;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtxtFinalConst.Text))
            {
                Clipboard.SetDataObject(rtxtFinalConst.Text);
                MessageBox.Show("已复制");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveRegex = txtRegex.Text.Trim();

            _RegexModel.Validation(saveRegex, true);

            _RegexModel.RegexFieldList.Add(new RegexField { RegexText = saveRegex });

            _RegexModel.Save();
            MessageBox.Show("保存成功");

            RefreshForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var deleteRegex = cbxMyRegex.SelectedValue.ToString().Trim();

            _RegexModel.Validation(deleteRegex, false);

            var regexField = _RegexModel.RegexFieldList.SingleOrDefault(p => p.RegexText == deleteRegex);
            _RegexModel.RegexFieldList.Remove(regexField);

            _RegexModel.Save();
            MessageBox.Show("删除成功");

            RefreshForm();
        }

        private void txtRegex_TextChanged(object sender, EventArgs e)
        {
            txtFieldName.Text = string.Empty;
            txtFieldValue.Text = string.Empty;
            txtFieldSummary.Text = string.Empty;
        }

        private void cbxMyRegex_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxMyRegex.SelectedIndex != 0)
            {
                txtRegex.Text = cbxMyRegex.SelectedValue.ToString();
            }
        }

        #endregion
    }
}
