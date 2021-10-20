using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StayYonetimProg
{
    public partial class WebFrmTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<veri> chkListDataKaynagi = new List<veri>();
                for (int i = 0; i < 5; i++)
                {
                    veri item = new veri();
                    item.code = i + "code";
                    item.name = i + " adım ";

                    chkListDataKaynagi.Add(item);
                }

                chkKirsatiyeListesi.DataTextField = "name";
                chkKirsatiyeListesi.DataValueField = "code";
                chkKirsatiyeListesi.DataSource = chkListDataKaynagi;
                chkKirsatiyeListesi.DataBind();
            }
        }

        protected void chkKirsatiyeListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBilgi.Text = "";
            for(int i = 0; i < chkKirsatiyeListesi.Items.Count; i++)
            {
                if (chkKirsatiyeListesi.Items[i].Selected)
                    lblBilgi.Text = lblBilgi.Text + " - " + chkKirsatiyeListesi.Items[i].Value + " :" + chkKirsatiyeListesi.Items[i].Text;
            }
        }

        public class veri
        {
            public string name { set; get; }
            public string code { set; get; }
        }
    }
}