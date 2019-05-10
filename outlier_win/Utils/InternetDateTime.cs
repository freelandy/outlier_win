using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace outlier_win.Utils
{
    public class InternetDateTime
    {
        public static DateTime GetCurrentTime()
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = "http://www.hko.gov.hk/cgi-bin/gts/time5a.pr?a=2",
                Method = "GET",
            };

            try
            {
                HttpResult R = http.GetHtml(item);
                Regex regex = new Regex(@"0=(?<timestamp>\d{10})\d+");
                Match match = regex.Match(R.Html);
                if (match.Success)
                {
                    return GetTime(match.Groups["timestamp"].Value);
                }
                else
                {
                    return new DateTime(1981, 10, 7);
                }
            }
            catch
            {
                return new DateTime(1981, 10, 7);
            }
        }

        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name=”timeStamp”></param>
        /// <returns></returns>
        private static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }
    }
}
