using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Collections.Generic;
using WebApplication2.Models;
using Microsoft.Extensions.Logging;
using static WebApplication2.Models.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        private readonly CommonService _commonService;

        private readonly HomeService _service;

        public HomeController(AppDbContext context,HomeService service,CommonService commonService)
        {
            _context = context;
            _service = service;
            _commonService = commonService;
        }
        

        public IActionResult Home()
        {
            return View();
        }

        public ActionResult GetMessage()
        {
            return Json(new { message = "Greetings from server!" });
        }

        public ActionResult GetData()
        {
            return Json(new { data = _service.GetDataService() });
        }

        public ActionResult GetDataTodo()
        {
            return Json(new { data = _service.GetDataServiceTodo() });
        }

        [HttpPost]
        public ActionResult CreateData(HomeViewModel viewModel)
        {
            return Json(new { result = _service.CreateDataService(viewModel) });
        }

        [HttpPost]
        public ActionResult CreateDataTodo(HomeViewModel viewModel)
        {
            return Json(new { result = _service.CreateDataServiceTodo(viewModel) });
        }

        public ActionResult GetDataById(int id)
        {
            return Json(new { data = _service.GetDataByIdService(id) });
        }

        //�ڕW:GetDataByIdTodo���\�b�h���C�����AService/HomeService.cs��GetDataByIdServiceTodo���\�b�h���Ăяo���āA�f�[�^�x�[�X�R���e�L�X�g����擾�����f�[�^��homeViewModel�Ɋi�[���ĕԂ�
        //�q���g:GetDataById���\�b�h���Q�l�ɂ��ĉ������B
        public ActionResult GetDataByIdTodo()
        {
            return null;
        }

        [HttpPost]
        public ActionResult EditData(HomeViewModel viewModel) 
        {
            return Json(new { result = _service.EditDataService(viewModel) });
        }

        [HttpPost]
        public ActionResult EditDataTodo(HomeViewModel viewModel)
        {
            return Json(new { result = _service.EditDataServiceTodo(viewModel) });
        }
    }
}
