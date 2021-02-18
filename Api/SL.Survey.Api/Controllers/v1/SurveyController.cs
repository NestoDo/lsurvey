using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SL.Survey.Api.Contracts.V1;
using SL.Survey.DataAccess.Data;
using SL.Survey.Entities.Dto;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SL.Survey.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v1/surveys")]
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
        [HttpGet(ApiRoutes.Survey.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var survey = await _db.Surveys.ToListAsync();

            if (survey.Count == 0)
                return NotFound();

            var surveyDto = _mapper.Map<IEnumerable<SurveyDto>>(survey);

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {survey.Count()} items");

            return Ok(surveyDto);
        }

        // GET /survey/{id}
        [HttpGet(ApiRoutes.Survey.GetQuestionsAnswers)]
        public async Task<IActionResult> GetQuestionsAnswers(int id)
        {
            var question =  await _db.Questions.Where(x => x.QuestionId == id).ToListAsync();
            //    .Include(u => u.SurveyQuestions)
            //    .ThenInclude(u => u.SurveyQuestionOfferedAnswers)
            //    .ThenInclude(u => u.OfferedAnswer).ToListAsync();


            if (question.Count == 0)
                return NotFound();

            var questionDto = _mapper.Map<IEnumerable<QuestionDto>>(question);

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {question.Count()} items");

            return Ok(questionDto);
        }
    }
}
