using AutoMapper;
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
        private readonly IMapper _mapper;

        public SurveyController(ApplicationDbContext db, ILogger<SurveyController> logger, IMapper mapper)
        {
            _db = db;
            _logger = logger;
            _mapper = mapper;
        }

        // GET /survey
        [HttpGet]
        public async Task<IEnumerable<SurveyQuestionDto>> GetSurveyAsync()
        {
            //var items = (await repository.GetItemsAsync())
            //            .Select(item => item.AsDto());

            //IEnumerable<Survey>
            var surveyQuestion = _db.SurveyQuestions
                .Include(u => u.Survey)
                .Include(u => u.Question)
                .Include(u => u.SurveyQuestionOfferedAnswers)
                .ThenInclude(u => u.OfferedAnswer).ToList();

            //var surveyQuestion = _db.SurveyQuestions.ToList();

            var surveyQuestionDto = _mapper.Map<IEnumerable<SurveyQuestionDto>>(surveyQuestion);
            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {surveyQuestion.Count()} items");
            
            return surveyQuestionDto;
        }
    }
}
