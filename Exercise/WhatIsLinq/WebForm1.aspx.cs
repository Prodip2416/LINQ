using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WhatIsLinq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext sampleData= new SampleDataContext();

            //GridView1.DataSource = from s in sampleData.Students
            //                       where  s.Gender=="Male"
            //                       select s;

            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            GridView1.DataSource = from n in numbers
                                   where (n%2==0)
                                   select n;
            GridView1.DataBind();
        }
    }
}