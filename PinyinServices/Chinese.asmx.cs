using System.Data;
using System.Linq;
using System.Web.Services;

namespace net.khanhphong.services.pinyin
{
    /// <summary>
    /// Summary description for Chinese
    /// </summary>
    [WebService(Namespace = "https://khanhphong.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Chinese : System.Web.Services.WebService
    {

        [WebMethod(Description = "Get string of Pinyin With Number codes from Chinese characters string")]
        public string GetPinyinWithNumber(string Chinese)
        {
            string pinyin = "";
            DatabaseTableAdapters.QueriesTableAdapter obj = new DatabaseTableAdapters.QueriesTableAdapter();

            foreach (var c in Chinese)
            {
                pinyin += " " + obj.func_GetPinyinWithNumber(c.ToString());
            }

            return pinyin.Trim();
        }

        [WebMethod(Description = "Get string of Pinyin With Mark codes from Chinese characters string")]
        public string GetPinyinWithMark(string Chinese)
        {
            DatabaseTableAdapters.QueriesTableAdapter obj = new DatabaseTableAdapters.QueriesTableAdapter();
            string pinyin = "";

            foreach (var c in Chinese)
            {
                string pinyinWithMark = "";
                string pinyinWithNumber = obj.func_GetPinyinWithNumber(c.ToString());

                if (pinyinWithNumber.Contains('|'))
                {
                    string[] arrayPinyin = pinyinWithNumber.Split('|');
                    foreach (var s in arrayPinyin)
                    {
                        pinyinWithMark += pinyinWithMark.Equals("") ? Pinyin.ToPinyinWithMark(s) : "|" + Pinyin.ToPinyinWithMark(s);
                    }
                }
                else
                    pinyinWithMark = Pinyin.ToPinyinWithMark(pinyinWithNumber);

                pinyin += " " + pinyinWithMark;
            }


            return pinyin.Trim();
        }

        [WebMethod(Description = "Get DataTable of Chinese Characters from Pinyin (with number).")]
        public DataTable GetChineseByPinyin(string Pinyin)
        {          
            DatabaseTableAdapters.proc_GetChinesesByPinyinTableAdapter obj = new DatabaseTableAdapters.proc_GetChinesesByPinyinTableAdapter();
            return obj.GetData(Pinyin);
        }

        [WebMethod(Description = "Translates one (1) Chinese character to Vietnamese (Han - Viet) text.")]
        public string GetVietnamsesByChinese(string Chinese)
        {
            DatabaseTableAdapters.QueriesTableAdapter obj = new DatabaseTableAdapters.QueriesTableAdapter();
            return obj.func_GetVietnameseByChinese(Chinese);
        }

        [WebMethod(Description = "Translates Chinese text to Vietnamese (Han - Viet) text.")]
        public string TranslateToVietnamese(string ChineseText)
        {
            DatabaseTableAdapters.QueriesTableAdapter obj = new DatabaseTableAdapters.QueriesTableAdapter();
            return obj.func_TranslateToVietnamese(ChineseText);
        }
    }
}
