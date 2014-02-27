using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double Addition(int a, int b)
    {
        double c;
        c = a + b;
        return c;
    }
    [WebMethod]
    public double Subtraction(int a, int b)
    {
        double c;
        c = a + b;
        return c;
    }
    [WebMethod]
    public double multiplication(int a, int b)
    {
        double c;
        c = a + b;
        return c;
    }
    [WebMethod]
    public double division(int a, int b)
    {
        double c;
    c = a + b;
    return c;

}
    
}
