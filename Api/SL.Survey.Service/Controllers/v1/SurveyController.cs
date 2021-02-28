using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SL.Misc.Extensions;
using SL.Survey.Api.Contracts.V1;
using SL.Survey.DataAccess.Data;
using SL.Survey.Entities.Dto.Response.V1;
using SL.Survey.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SL.Survey.Api.Controllers.V1
{
    [ApiController]
    [Authorize(AuthenticationSchemes =JwtBearerDefaults.AuthenticationScheme)]
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

            var aaa = HttpContext.GetUserId();

            if (survey.Count == 0)
                return NotFound();

            var surveyDto = _mapper.Map<IEnumerable<SurveyResponse>>(survey);

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {survey.Count()} items");

            return Ok(surveyDto);
        }

        // GET /survey/{id}
        [HttpGet(ApiRoutes.Survey.GetQuestionsAnswers)]
        public async Task<IActionResult> GetQuestionsAnswers(int id)
        {
            var question = await _db.Questions
                .Include(u => u.SurveyQuestions.Where(x => x.SurveyId == id))
                .ThenInclude(u => u.SurveyQuestionOfferedAnswers)
                .ThenInclude(u => u.OfferedAnswer).ToListAsync();

            //var question = from q in _db.Questions
            //               join sq in _db.SurveyQuestions on q.QuestionId equals sq.QuestionId
            //               join sqoa in _db.SurveyQuestionOfferedAnswers on sq.SurveyQuestionId equals sqoa.SurveyQuestionId
            //               join oa in _db.OfferedAnswers on sqoa.OfferedAnswerId equals oa.OfferedAnswerId
            //               select new
            //               {
            //                   QuestionId = q.QuestionId,
            //                   Description = q.Description,
            //                   Name =  q.Name
            //               };


            if (question.Count == 0)
                return NotFound();

            var questionDto = _mapper.Map<IEnumerable<QuestionResponse>>(question);

            _logger.LogInformation($"{DateTime.UtcNow.ToString("hh:mm:ss")}: Retrieved {question.Count()} items");

            return Ok(questionDto);
        }
    }
}
