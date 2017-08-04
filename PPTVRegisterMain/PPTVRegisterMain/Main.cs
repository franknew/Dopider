using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QConnectSDK.Api;
using SOAFramework.Library;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using System.Configuration;
using BLL;
using Entity;
using System.IO;
using System.Threading;
using System.Net;
using System.Threading.Tasks;

namespace PPTVRegisterMain
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //QConnectSDK.Api.RestApi api = new RestApi();


        }

        private void btnUnicodeTo_Click(object sender, EventArgs e)
        {
            txbChinese.Text = UnicodeHelper.UnicodeToGB(txbUnicode.Text);
        }



        private void btnSinaReg_Click(object sender, EventArgs e)
        {
            BeginRequest();
        }

        public async void BeginRequest()
        {
            string url = ConfigurationManager.AppSettings["PPTVRegPage"];
            url = "http://game.g.pptv.com/api/ajax/glist.php?gid=mfwz&cb=jQuery18303589057802020937_1484226060841&_=1484226061010";
            string json = HttpHelper.Get(url);
            string parsedjson = UnicodeHelper.UnicodeToGB(json.Remove(0, json.IndexOf("(") + 1).TrimEnd(')'));
            var list = JsonHelper.Deserialize<List<Server>>(parsedjson);
            while (true)
            {
                WebProxy proxy = null;
                if (!string.IsNullOrEmpty(txbUrl.Text)) proxy = new WebProxy(txbUrl.Text, true);
                bool valid = await Handle(list, proxy);
                if (!valid) break; 
            }
            MessageBox.Show("处理结束");
        }

        public async Task<bool> Handle(List<Server> servers, IWebProxy proxy)
        {
            foreach (var t in servers)
            {
                string html = await GetHtml(t, proxy);
                if (string.IsNullOrEmpty(html)) return false;
                if (html.Contains("非法操作#")) return false;
                var doc = HtmlParser.Parse(html);
                if (doc.FirstChild.Name.Equals("script")) return false;
                var ems = doc.FindAll(p => !string.IsNullOrEmpty(p.Name) && p.Name.Equals("em"));
                if (ems.Count == 0) return true;
                string userName = ems[0].FirstChild.Value;
                string pwd = ems[1].FirstChild.Value;

                string line = string.Format("{0}   {1}{2}", userName, pwd, Environment.NewLine);
                File.AppendAllText(@"\account.txt", line);
                BindingList<User> datasource = dataGridView1.DataSource as BindingList<User>;
                if (datasource == null) datasource = new BindingList<User>();
                datasource.Add(new User { UserName = userName, Password = pwd });
            }
            return true;
        }

        public async Task<string> GetHtml(Server server, IWebProxy proxy)
        {
            string accountUrl = string.Format("http://game.g.pptv.com/guest/index?gid=mfwz&sid={0}", server.sid);
            string html = "";
            try
            {
                html = HttpHelper.Get(accountUrl, null, 5000, false, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586", proxy);
                //html = HttpHelper.Get("http://www.whatismyip.com.tw", null, 5000, false, "Mozilla /5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2486.0 Safari/537.36 Edge/13.10586", proxy);
                txbChinese.Text = html;
            }
            catch (WebException ex)
            {
                txbChinese.Text = txbUrl.Text + "不可用";
                return null;
            }
            return html;
        }
    }

    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
