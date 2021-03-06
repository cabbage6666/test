﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTTPRequestTools
{
    class UnicodeTools
    {
        /// <summary>
        /// 标准unicode编码
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string EncodeString(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            int len = text.Length;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                builder.Append("\\u");
                builder.Append(UShortToHex((ushort)text[i]));
            }
            return builder.ToString();
        }
        /// <summary>
        /// 编码Unicode
        /// </summary>
        /// <param name="text">原字符串</param>
        /// <returns>unicode编码</returns>
        public static string EncodeString1(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            var bytes = Encoding.Unicode.GetBytes(text);
            int len = bytes.Length;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < len; i += 2)
            {
                builder.Append("\\u");
                builder.Append(bytes[i + 1].ToString("x2"));
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        public static string EncodeString2(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            int len = text.Length;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                builder.Append("\\u");
                builder.Append(((ushort)text[i]).ToString("x4"));
            }
            return builder.ToString();
        }


        private static char[] UShortToHex(ushort n)
        {
            int num;
            char[] hex = new char[4];
            for (int i = 0; i < 4; i++)
            {
                num = n % 16;

                if (num < 10)
                    hex[3 - i] = (char)('0' + num);
                else
                    hex[3 - i] = (char)('A' + (num - 10));

                n >>= 4;
            }
            return hex;
        }
        private static char[] UShortToHexE(ushort n)
        {
            var hex = n.ToString("x").ToCharArray();
            return hex;
        }

        public static string DecodeString(string unicode)
        {
            if (string.IsNullOrEmpty(unicode))
            {
                return string.Empty;
            }
            //string[] ls = unicode.Replace("\\", "").Split(new char[]{'u'},StringSplitOptions.RemoveEmptyEntries);
            string[] ls = unicode.Split(new string[] { "\\u" }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder builder = new StringBuilder();
            int len = ls.Length;
            for (int i = 0; i < len; i++)
            {
                //builder.Append((Char)ushort.Parse(ls[i], System.Globalization.NumberStyles.HexNumber));
                builder.Append(Convert.ToChar(ushort.Parse(ls[i], System.Globalization.NumberStyles.HexNumber)));

            }
            return builder.ToString();
        }


        /// <summary>
        /// 这种只能解出标准unicode编码
        /// </summary>
        /// <param name="unicode"></param>
        /// <returns></returns>
        public static string DecodeString1(string unicode)
        {
            if (string.IsNullOrEmpty(unicode))
            {
                return string.Empty;
            }
            return System.Text.RegularExpressions.Regex.Unescape(unicode);
        }
    }
}
