using CoreMvcWithOracle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcWithOracle.Interfaces {
    public interface INoticeService {

        IEnumerable<Notice> GetAllNotice();


        Notice GetNoticeById(int eid);



        void AddNotice(Notice notice);


        void EditStudent(Notice notice);


        void DeleteStudent(Notice notice);
    }
}
