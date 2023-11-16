using AutoMapper;


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSanadApplication.Interface;
using WebSanadApplication.Models;
using WebSanadApplication.Models.ViewModel;
using System.Data.SqlClient;
using System.Data;

namespace WebSanadApplication.Controllers
{
  
    public class SettingController : Controller
    {
        private readonly string CandaSql;
        public SettingController(IConfiguration config)
        {
            CandaSql = config.GetConnectionString("DefaultConnection");
        }
        [HttpGet]
        public JsonResult DataTableSearch(string SEARCH_CODE)
        {
            List<SEARCH_ACCOUNTSResult> SearchAccountResult = new List<SEARCH_ACCOUNTSResult>();
            using (var Result = new SqlConnection(CandaSql))
            {
                Result.Open();
                SqlCommand cmd = new SqlCommand("SEARCH_ACCOUNTS", Result);
                cmd.Parameters.AddWithValue("SEARCH_CODE", SEARCH_CODE);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        SearchAccountResult.Add(
                            new SEARCH_ACCOUNTSResult()
                            {
                                
                                ACC_ID =Convert.ToInt32(dr["ACC_ID"]),
                                ACC_CODE = dr["ACC_CODE"].ToString(),
                                ACC_AR_NAME = dr["ACC_AR_NAME"].ToString(),
                                ACC_EN_NAME = dr["ACC_EN_NAME"].ToString()
                               
                                /*
                                ACC_TYPE_ID = Convert.ToByte(dr["ACC_TYPE_ID"]),
                                ACC_MAX_DEBIT = Convert.ToDouble(dr["ACC_MAX_DEBIT"]),
                                ACC_MUST_COST_CENTER = Convert.ToBoolean(dr["ACC_MUST_COST_CENTER"])
                                */
                            }
                            );

                    }
                }
            }

            return Json(SearchAccountResult);
        }


        public IActionResult Basics()
        {
            return View();
        }
        
      

    }

}












