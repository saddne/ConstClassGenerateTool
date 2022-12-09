using Business.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business.RegexConfig
{
    public class RegexModel
    {
        public string FilePath { get; set; }

        public List<RegexField> RegexFieldList { get; set; }

        public void GetRegexFieldList()
        {
            RegexFieldList = new List<RegexField>();
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        RegexFieldList.Add(new RegexField() { RegexText = sr.ReadLine() });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 验证
        /// </summary>
        /// <param name="updateRegex">要进行操作的正则表达式（保存或删除）</param>
        /// <param name="isSave">true:添加；false:删除</param>
        /// <exception cref="Exception"></exception>
        public void Validation(string updateRegex, bool isSave)
        {
            if (RegexExample.GetAllKeys().Contains(updateRegex))
            {
                throw new Exception(String.Format("当前正则表达式是系统默认配置正则表达式", isSave ? "，无需保存！" : "，不可删除！"));
            }

            if (RegexFieldList != null && RegexFieldList.Count > 0)
            {
                if (isSave)
                {
                    if (RegexFieldList.Any(p => p.RegexText == updateRegex))
                    {
                        throw new Exception("当前正则表达式已保存，无需重复保存！");
                    }
                }
                else
                {
                    if (!RegexFieldList.Any(p => p.RegexText == updateRegex))
                    {
                        throw new Exception("当前正则表达式不存在，无法删除！");
                    }
                }
            }
        }

        public void Save()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    foreach (var item in RegexFieldList)
                    {
                        sw.WriteLine(item.RegexText);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    public class RegexField
    {
        public string RegexText { get; set; }
    }
}
