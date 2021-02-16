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
    [Route("surveys")]
    public class SurveysController : Controller
    {
        private readonly ILogger<SurveysController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public SurveysController(ApplicationDbContext db, ILogger<SurveysController> logger, IMapper mapper)
        {
            _db = db;
            _logger = logger;
            _mapper = mapper;
        }

        // GET /survey
        [HttpGet]
        public async Task<IEnumerable<SurveyDto>> GetSurveys()
        {
            var surveyQuestion = await _db.Surveys.ToListAsync();                

            var surveyQuestionDto = _mapper.Map<IEnumerable<SurveyDto>>(surveyQuestion);

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {surveyQuestion.Count()} items");

            return surveyQuestionDto;
        }

        // GET /survey/{id}
        [HttpGet("{id}")]
        public async Task<IEnumerable<QuestionDto>> GetQuestionsAnswers(int id)
        {
            var surveyQuestion = await _db.Questions
                .Include(u => u.SurveyQuestions)
                .ThenInclude(u => u.SurveyQuestionOfferedAnswers)
                .ThenInclude(u => u.OfferedAnswer).ToListAsync();

            var questionDto = _mapper.Map<IEnumerable<QuestionDto>>(surveyQuestion);

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {surveyQuestion.Count()} items");

            return questionDto;
        }
    }
}
