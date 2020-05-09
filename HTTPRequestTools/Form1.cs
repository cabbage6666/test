using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTTPRequestTools
{
    public partial class HTTP请求工具 : Form
    {
        public HTTP请求工具()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrl.Text))
            {
                MessageBox.Show("请输入需要请求的路径");
                txtUrl.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtRequ.Text) && rdoPost.Checked)
            {
                MessageBox.Show("请输入请求参数");
                txtRequ.Focus();
                return;
            }
            if(string.IsNullOrEmpty(txtContentType.Text))
            {
                MessageBox.Show("请输入HTTP标头值");
                txtContentType.Focus();
                return;
            }

            HttpWebRequest request = null;
            StreamReader sr = null;
            string result = string.Empty;
            Stream st = null;
            try
            {
                //http://34.80.249.66:9000/accounts/login/students/?username = zj123 & password =  e10adc3949ba59abbe56e057f20f883e
                //https://XXX.XXX.XXX/:8080/accounts/clientLogin/students/?username = zj123 & password =  e10adc3949ba59abbe56e057f20f883e

                request = (HttpWebRequest)WebRequest.Create(txtUrl.Text.Trim());   //创建连接
              

                request.Method = rdoPost.Checked ? "Post" : rdoPut.Checked?"Put":rdoGet.Checked?"Get":"DELETE";   //请求设置
                if (rdoPost.Checked || (rdoPut.Checked && !string.IsNullOrWhiteSpace(txtRequ.Text))||(rdoDel.Checked&&!string.IsNullOrWhiteSpace(txtRequ.Text)))
                {

                    byte[] by = Encoding.GetEncoding("utf-8").GetBytes(txtRequ.Text.Trim());   //请求参数转码
                    request.ContentType = txtContentType.Text.Trim();
                    request.ContinueTimeout = 500000;
                    request.ContentLength = by.Length;

                    Stream stw = request.GetRequestStream();     //获取绑定相应流
                    stw.Write(by, 0, by.Length);      //写入流
                    stw.Close();    //关闭流
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();    //返回流接收
                st = response.GetResponseStream();
                sr = new StreamReader(st, Encoding.GetEncoding("utf-8"));
                result = sr.ReadToEnd();    //一次读完
            }
            catch (Exception ex)
            {
                result = "请求异常原因:"+ex.ToString();
            }
            finally
            {
                if (request != null)
                {
                    request.Abort();
                }
                if (st != null)
                {
                    st.Close();
                }
                if (sr != null)
                {
                    sr.Close();
                }
            }
            txtReponse.Clear();
            //var val2 = DecodeBase64("utf-8","\u8bf7\u6c42\u6210\u529f");
            //Console.WriteLine(UnicodeTools.DecodeString("\u8bf7\u6c42\u6210\u529f"));
            var val2 = UnicodeTools.DecodeString1(result);
            txtReponse.Text= val2;
            

        }


        public static string DecodeBase64(string code_type, string code)
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }
    }
}
