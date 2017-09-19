using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;

namespace RunSP.Controllers
{
    public class FormRunSpController : Controller
    {

       

            
        //
        // GET: /FormRunSp/
        public void Index()
        {
            Dataset ds = new Dataset();
            SqlConnection conn;
            SqlCommand cmd = new SqlCommand();

            SqlParameter sp1 = new SqlParameter();
            SqlParameter sp2 = new SqlParameter();

            conn = new SqlConnection("server=10.10.10.212:database=AXGMKDW;uid=sa;pwd=Haan@123");
            cmd.Parameters.Add("@fromdate", sqlDbType.Varchar).Value = fromdate.text;
            cmd.Parameters.Add("@todate", sqlDbType.Varchar).Value = todate.text;
            cmd = new SqlCommand("submitrecord", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            //return View();
        }

        protected void buttonclick(object sender, EventArgs e)
        {
            
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

	}
}