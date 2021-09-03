using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sample_api_mongodb.Services;
using sample_api_mongodb.Models;

namespace sample_api_mongodb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagesController : Controller 
    {
        private readonly PagesService _pagesService;

        public PagesController(PagesService pagesService)
        {
            _pagesService = pagesService;
        }

        
        [HttpPost("CreatePage")]
        public ActionResult CreatePage(Page page) {
            _pagesService.CreatePage(page);
            return Ok();
        }

        [HttpGet("GetPages")]
        public ActionResult<List<Page>> GetPages() => _pagesService.GetPages();

        [HttpGet("GetPage/{id}")]
        public ActionResult<Page> GetPage(string id) => _pagesService.GetPage(id);

        [HttpPost("UpdatePage")]
        public ActionResult UpdatePage(Page page) {
            _pagesService.UpdatePage(page);
            return Ok();
        }

        [HttpPost("DeletePage/{id}")]
        public ActionResult DeletePage(string id) {
            _pagesService.DeletePage(id);
            return Ok();
        }

    }
}