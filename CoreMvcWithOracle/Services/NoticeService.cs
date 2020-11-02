using CoreMvcWithOracle.Models;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcWithOracle.Interfaces;

namespace CoreMvcWithOracle.Services {
    public class NoticeService : INoticeService {


        private readonly string _connectionString;


        public NoticeService(IConfiguration _configuration) {
            _connectionString = _configuration.GetConnectionString("OracleDbConnection");
        }

        public void AddNotice(Notice notice) {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Notice notice) {
            throw new NotImplementedException();
        }

        public void EditStudent(Notice notice) {
            throw new NotImplementedException();
        }

        public IEnumerable<Notice> GetAllNotice() {
            List<Notice> noticeList = new List<Notice>();
            using(OracleConnection con = new OracleConnection(_connectionString)) {
                using(OracleCommand cmd = con.CreateCommand()) {
                    con.Open();
                    cmd.CommandText = "Select Id, title from HR.Notice";
                    OracleDataReader odr = cmd.ExecuteReader();
                    while(odr.Read()) {
                        Notice notice = new Notice {
                            NoticeId = odr["Id"].ToString(),
                            NoticeTitle = odr["Title"].ToString()
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
    }
}
