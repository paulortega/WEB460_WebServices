using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebServiceMaths
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebServiceMaths : System.Web.Services.WebService {

    public WebServiceMaths () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string Add(string x, string y)
    {
        
        return (int.Parse(x) + int.Parse(y)).ToString();
    }

    [WebMethod]
    public string Subtract(string x, string y)
    {
        return (int.Parse(x) - int.Parse(y)).ToString();
    }

    [WebMethod]
    public string Multiply(string x, string y)
    {
        return (int.Parse(x) * int.Parse(y)).ToString();
    }

    [WebMethod]
    public string Divide(string x, string y)
    {
        return (int.Parse(x) / int.Parse(y)).ToString();
    }
    
}
