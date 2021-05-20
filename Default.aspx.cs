using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{

    IServiceLocator locator = new ServiceLocator();
    protected ICidRepository repo;

    public _Default()
    {
        repo = locator.GetService<ICidRepository>();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = repo.Listar();
        GridView1.DataBind();
    }
}

