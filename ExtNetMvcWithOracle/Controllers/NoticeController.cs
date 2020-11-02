using ExtNetMvcWithOracle.Interfaces;
using ExtNetMvcWithOracle.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExtNetMvcWithOracle.Controllers {
    public class NoticeController : Controller {

        INoticeService noticeService;

        public NoticeController(INoticeService _noticeService) {
            noticeService = _noticeService;
        }

        public IActionResult Index() {
            IEnumerable<Notice> notice = noticeService.GetAllNotice();
            return View(notice);
        }
    }
}
