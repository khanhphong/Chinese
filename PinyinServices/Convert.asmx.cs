using System.Web.Services;

namespace net.khanhphong.services.pinyin
{
    /// <summary>
    /// Summary description for Convert
    /// </summary>
    [WebService(Namespace = "https://khanhphong.net/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Convert : System.Web.Services.WebService
    {

        [WebMethod(Description = "Convert Pinyin With Number to Pinyin With Mark")]
        public string ToPinyinWithMark(string PinyinWithNumber)
        {
            return Pinyin.ToPinyinWithMark(PinyinWithNumber);
        }
    }
}
