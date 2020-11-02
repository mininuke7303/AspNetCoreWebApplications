using ExtNetMvcWithOracle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtNetMvcWithOracle.Interfaces {
    public interface INoticeService {

        IEnumerable<Notice> GetAllNotice();

        Notice GetNoticeById(int eid);
        
        void AddNotice(Notice notice);
        
        void EditNotice(Notice notice);

        void DeleteNotice(Notice notice);


    }
}
