using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace restful
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addition/{a}/{b}")]
        public person Addition(string a,string b)
        {
            double c;
            int x1 = Convert.ToInt32(a);
            int x2 = Convert.ToInt32(b);
            c = x1 + x2;
            return new person()
            {
                Operation = "Addition",
                Output =  Convert.ToDouble(c)
            };
        }
         [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "subtraction/{a}/{b}")]
        public person Subtraction(string a,string b)
        {
            double c;
            int x1 = Convert.ToInt32(a);
            int x2 = Convert.ToInt32(b);
            c = x1 - x2;
            return new person()
            {
                Operation = "Subtraction",
                Output = Convert.ToDouble(c)
            };
        }
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "multiplication/{a}/{b}")]
        public person Multiplication(string a,string b)
        {
            double c;
            int x1 = Convert.ToInt32(a);
            int x2 = Convert.ToInt32(b);
            c = x1 * x2;
            return new person()
            {
                Operation = "Multiplication",
                Output = Convert.ToDouble(c)
            };
        }
         [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "division/{a}/{b}")]
        public person Division(string a,string b)
        {
            double c;
            int x1 = Convert.ToInt32(a);
            int x2 = Convert.ToInt32(b);
            c = x1 / x2;
            return new person()
            {
                Operation = "Division",
                Output = Convert.ToDouble(c)
            };
        }

         public CompositeType GetDataUsingDataContract(CompositeType composite)
         {
             if (composite == null)
             {
                 throw new ArgumentNullException("composite");
             }
             if (composite.BoolValue)
             {
                 composite.StringValue += "Suffix";
             }
             return composite;
         }
    }
   
    public class person
    {
        public string Operation { get; set; }
        public double Output { get; set; }
    }
}
