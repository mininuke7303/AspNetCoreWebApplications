using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using CoreMvcWithOracle.Interfaces;
using CoreMvcWithOracle.Models;
using CoreMvcWithOracle.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoreMvcWithOracle.Controllers {
    public class NoticeController : Controller {
        
        INoticeService noticeService;

        public NoticeController(INoticeService _noticeService) {
            noticeService = _noticeService;   
        }

        public IActionResult Index() {
            IEnumerable<Notice> noticeList = noticeService.GetAllNotice();
            return View(noticeList);
        }
    }
}
