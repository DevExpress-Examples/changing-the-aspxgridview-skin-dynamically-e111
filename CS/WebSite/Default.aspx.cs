using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;
using DevExpress.Xpo;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.Data;
using System.Collections;
using System.Data.OleDb;
using DevExpress.Web.Internal;
using System.IO;
using DevExpress.Data.Filtering;

public partial class Change_Skin_ID: System.Web.UI.Page 
{

    protected void Page_PreInit(object sender, EventArgs e) {
        int index = 0;
        int.TryParse(Request.Form["ASPxRadioButtonList1"], out index);
        ASPxGridView1.SkinID = Convert.ToString(ASPxRadioButtonList1.Items[index].Value);
    }

    protected void Page_Load(object sender, EventArgs e) {
   }
}
