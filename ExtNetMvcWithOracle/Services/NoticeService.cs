using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExtNetMvcWithOracle.Interfaces;
using ExtNetMvcWithOracle.Models;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace ExtNetMvcWithOracle.Services {
    public class NoticeService : INoticeService {

        private readonly string _connectionString;

        public NoticeService(IConfiguration _configuration) {
            _connectionString = _configuration.GetConnectionString("OracleDbConnection");
        }



        public IEnumerable<Notice> GetAllNotice() {
            List<Notice> noticeList = new List<Notice>();
            using (OracleConnection con = new OracleConnection(_connectionString)) {
                using (OracleCommand cmd = con.CreateCommand()) {
                    con.Open();
                    cmd.CommandText = "Select Id, Title from Notice";
                    OracleDataReader odr = cmd.ExecuteReader();
                    while (odr.Read()) {
                        Notice notice = new Notice {
                            Id = odr["Id"].ToString(),
                            Name = odr["Title"].ToString()
                        };
                        noticeList.Add(notice);
                    }
                }
            }
            return noticeList;
        }



        public Notice GetNoticeById(int eid) {
            throw new NotImplementedException();
        }

        public void AddNotice(Notice notice) {
            throw new NotImplementedException();
        }

        public void DeleteNotice(Notice notice) {
            throw new NotImplementedException();
        }


        public void EditNotice(Notice notice) {
            throw new NotImplementedException();
        }

        //IEnumerable<Notice> INoticeService.GetAllNotice() {
        //    throw new NotImplementedException();
        //}

    


        
    }
}
