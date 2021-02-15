using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SL.Survey.DataAccess.Data;
using SL.Survey.Entities.Dto;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SL.Survey.Api.Controllers
{
    [ApiController]
    [Route("survey")]
    public class SurveyController : Controller
    {
        private readonly ILogger<SurveyController> _logger;
        private readonly ApplicationDbContext _db;

        public SurveyController(ApplicationDbContext db, ILogger<SurveyController> logger)
        {
            _db = db;
            _logger = logger;
        }

        // GET /survey
        [HttpGet]
        public async Task<IEnumerable<SurveyQuestion>> GetSurveyAsync()
        {
            //var items = (await repository.GetItemsAsync())
            //            .Select(item => item.AsDto());

            //IEnumerable<Survey>
            var objList = _db.SurveyQuestions
                .Include(u => u.Survey)
                .Include(u => u.Question)
                .Include(u => u.SurveyQuestionOfferedAnswers)
                .ThenInclude(u => u.OfferedAnswer).ToList();

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {objList.Count()} items");
            
            return objList;
        }
    }
}
