using System.Collections.Generic;

namespace net.khanhphong.services.pinyin
{
    public static class Helper
    {
        // Pinyin zone

        // yùnmǔ array
        private static string[] _a = new string[] { "a", "ā", "á", "ǎ", "à" };
        private static string[] _o = new string[] { "o", "ō", "ó", "ǒ", "ò" };
        private static string[] _e = new string[] { "e", "ē", "é", "ě", "è" };
        private static string[] _ai = new string[] { "ai", "āi", "ái", "ǎi", "ài" };
        private static string[] _ei = new string[] { "ei", "ēi", "éi", "ěi", "èi" };
        private static string[] _ao = new string[] { "ao", "āo", "áo", "ǎo", "ào" };
        private static string[] _ou = new string[] { "ou", "ōu", "óu", "ǒu", "òu" };
        private static string[] _an = new string[] { "an", "ān", "án", "ǎn", "àn" };
        private static string[] _en = new string[] { "en", "ēn", "én", "ěn", "èn" };
        private static string[] _ang = new string[] { "ang", "āng", "áng", "ǎng", "àng" };
        private static string[] _eng = new string[] { "eng", "ēng", "éng", "ěng", "èng" };
        private static string[] _ong = new string[] { "ong", "ōng", "óng", "ǒng", "òng" };
        private static string[] _i = new string[] { "i", "ī", "í", "ǐ", "ì" };
        private static string[] _ia = new string[] { "ia", "iā", "iá", "iǎ", "ià" };
        private static string[] _ie = new string[] { "ie", "iē", "ié", "iě", "iè" };
        private static string[] _iao = new string[] { "iao", "iāo", "iáo", "iǎo", "iào" };
        private static string[] _iou = new string[] { "iou", "ioū", "ioú", "ioǔ", "ioù" }; // thành vần iu
        private static string[] _ian = new string[] { "ian", "iān", "ián", "iǎn", "iàn" };
        private static string[] _in = new string[] { "in", "īn", "ín", "ǐn", "ìn" };
        private static string[] _iang = new string[] { "iang", "iāng", "iáng", "iǎng", "iàng" };
        private static string[] _ing = new string[] { "ing", "īng", "íng", "ǐng", "ìng" };
        private static string[] _iong = new string[] { "iong", "iōng", "ióng", "iong", "iòng" };
        private static string[] _u = new string[] { "u", "ū", "ú", "ǔ", "ù" };
        private static string[] _ua = new string[] { "ua", "uā", "uá", "uǎ", "uà" };
        private static string[] _uo = new string[] { "uo", "uō", "uó", "uǒ", "uò" };
        private static string[] _uai = new string[] { "uai", "uāi", "uái", "uǎi", "uài" };
        private static string[] _uei = new string[] { "uei", "uēi", "uéi", "uěi", "uèi" }; // thành vần ui
        private static string[] _uan = new string[] { "uan", "uān", "uán", "uǎn", "uàn" };
        private static string[] _uen = new string[] { "uen", "uēn", "uén", "uěn", "uèn" }; // thành vần un
        private static string[] _uang = new string[] { "uang", "uāng", "uáng", "uǎng", "uàng" };
        private static string[] _ueng = new string[] { "ueng", "uēng", "uéng", "uěng", "uèng" };
        private static string[] _ü = new string[] { "ü", "ǖ", "ǘ", "ǚ", "ǜ" };
        private static string[] _üe = new string[] { "üe", "üē", "üé", "üě", "üè" };
        private static string[] _üan = new string[] { "üan", "üān", "üán", "üǎn", "üàn" };
        private static string[] _ün = new string[] { "ün", "ǖn", "ǘn", "ǚn", "ǜn" };

        // special array
        private static string[] _iu = new string[] { "iu", "iū", "iú", "iǔ", "iù" };
        private static string[] _ue = new string[] { "ue", "uē", "ué", "uě", "uè" };
        private static string[] _ui = new string[] { "ui", "uī", "uí", "uǐ", "uì" };
        private static string[] _un = new string[] { "un", "ūn", "ún", "ǔn", "ùn" };
        private static string[] _er = new string[] { "er", "ēr", "ér", "ěr", "èr" };

        /// <summary> List of full yùnmǔ with mark </summary>
        public static List<string[]> YunmuWithMarkList = new List<string[]>() { _a, _o, _e, _ai, _ei, _ao, _ou, _an, _en, 
			_ang, _eng, _ong, _i, _ia, _ie, _iao, _iou, _ian, _in, _iang, _ing, _iong, _u, _ua, _uo, _uai, 
			_uei, _uan, _uen, _uang, _ueng, _ü, _üe, _üan, _ün, _iu, _ue, _ui, _un, _er };

        // yùnmǔ first characters
        private static char[] _yunmuFirstChar = new char[] { 'a', 'e', 'u', 'i', 'o', 'ü' };

        /// <summary> Get index of the first character of yùnmǔ in pinyin (number) string </summary>
        /// <returns>int: index of fisrt character of yùnmǔ.</returns>
        /// <param name="PinyinWithNumber">Pinyin with number string.</param>
        public static int YunmuFirstCharIndex(string PinyinWithNumber)
        {
            int i = 0;
            foreach (var c in _yunmuFirstChar)
            {
                i = PinyinWithNumber.IndexOf(c);
                if (i > 0)
                {
                    break;
                }
            }
            return i;
        }

        /// <summary>
        /// Get yùnmǔ with number in pinyin string
        /// </summary>
        /// <returns>String of yùnmǔ with number.</returns>
        /// <param name="PinyinWithNumber">Pinyin with number string.</param>
        public static string YunmuWithNumber(string PinyinWithNumber)
        {
            int index = YunmuFirstCharIndex(PinyinWithNumber);
            return index < 0 ? PinyinWithNumber : PinyinWithNumber.Substring(index);
        }

        /// <summary>
        /// Get shengmu in pinyin string
        /// </summary>
        /// <returns>String of shengmu.</returns>
        /// <param name="PinyinWithNumber">Pinyin with number string.</param>
        public static string Shengmu(string PinyinWithNumber)
        {
            int index = YunmuFirstCharIndex(PinyinWithNumber);
            return index < 0 ? "" : PinyinWithNumber.Substring(0, index);
        }

        /// <summary>
        /// Get last character of yùnmǔ string.
        /// </summary>
        /// <returns>char: the last character of yùnmǔ string.</returns>
        /// <param name="Yunmu">Yunmu with number string.</param>
        public static string YunmuLastChar(string Yunmu)
        {
            return (string)Yunmu.Substring(Yunmu.Length - 1);
        }
    }
}