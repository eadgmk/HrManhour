using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Data.SqlClient;
using RunSP.Models;

namespace RunSP.Controllers
{
    public class FormRunSpController : Controller
    {

                         
        //
        // GET: /FormRunSp/
        public ActionResult Index(Barang model)
        {
            //buttonclick();
            if (!String.IsNullOrEmpty(model.btnsubmit))
            {
                Dataset ds = new Dataset();
                SqlConnection conn;
                SqlCommand cmd = new SqlCommand();

                SqlParameter sp1 = new SqlParameter();
                SqlParameter sp2 = new SqlParameter();

                conn = new SqlConnection("server=10.10.10.26:database=DbTest;uid=sa;pwd=Haan@Colatta138");
                cmd.Parameters.Add("@nama", sqlDbType.Varchar).Value = fromdate.text;
                cmd.Parameters.Add("@jenis", sqlDbType.Varchar).Value = todate.text;
                cmd = new SqlCommand("submitrecord", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return View();
        }

        protected void buttonclick(object sender, EventArgs e)
        {
           /* Dataset ds = new Dataset();
            SqlConnection conn;
            SqlCommand cmd = new SqlCommand();

            SqlParameter sp1 = new SqlParameter();
            SqlParameter sp2 = new SqlParameter();

            conn = new SqlConnection("server=10.10.10.26:database=DbTest;uid=sa;pwd=Haan@Colatta138");
            cmd.Parameters.Add("@nama", sqlDbType.Varchar).Value = fromdate.text;
            cmd.Parameters.Add("@jenis", sqlDbType.Varchar).Value = todate.text;
            cmd = new SqlCommand("submitrecord", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();*/
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }

	}
}