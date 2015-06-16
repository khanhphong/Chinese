using System;

namespace net.khanhphong.services.pinyin
{
    public class Pinyin
    {
        private string _numberPinyin;

        public Pinyin(string numberPinyin)
        {
            _numberPinyin = numberPinyin;
        }

        public string YunmuWithNumber
        {
            get
            {
                return Helper.YunmuWithNumber(_numberPinyin);
            }
        }

        public string Shengmu
        {
            get
            {
                return Helper.Shengmu(_numberPinyin);
            }
        }

        public string YunmuWithMark
        {
            get
            {
                string yunmuWithNumber = YunmuWithNumber; // Dùng cái này để giảm việc xử lý cho CPU khi gọi nhiều lần YunmuWithNumber

                int number;
                try
                {
                    number = Int16.Parse(Helper.YunmuLastChar(yunmuWithNumber));
                }
                catch (FormatException)
                {
                    number = 0;
                }

                string pureYunmu;
                if (number == 0)
                    pureYunmu = yunmuWithNumber;
                else
                    pureYunmu = yunmuWithNumber.Substring(0, yunmuWithNumber.Length - 1);

                if (number == 5)
                    number = 0;

                string hanYunmu = "";
                foreach (var item in Helper.YunmuWithMarkList)
                {
                    if (item[0].Equals(pureYunmu))
                    {
                        hanYunmu = item[number];
                        break;
                    }
                }

                return hanYunmu;
            }
        }

        public string PinyinWithMark
        {
            get
            {
                return Shengmu + YunmuWithMark;
            }
        }

        public static string ToPinyinWithMark(string PinyinWithNumber)
        {
            Pinyin obj = new Pinyin(PinyinWithNumber);
            return obj.PinyinWithMark;
        }
    }
}