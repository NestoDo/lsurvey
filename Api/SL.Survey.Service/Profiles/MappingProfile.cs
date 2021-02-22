using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SL.Survey.Entities.Model;
using SL.Survey.Entities.Dto.Response.V1;

namespace SL.Survey.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OfferedAnswer, OfferedAnswerResponse>();
            CreateMap<OfferedAnswerResponse, OfferedAnswer>();

            CreateMap<Question, QuestionResponse>();
            CreateMap<QuestionResponse, Question>();

            CreateMap<QuestionType, QuestionTypeResponse>();
            CreateMap<QuestionTypeResponse, QuestionType>();

            CreateMap<SL.Survey.Entities.Model.Survey, SurveyResponse>();
            CreateMap<SurveyResponse, SL.Survey.Entities.Model.Survey>();

            CreateMap<SurveyQuestion, SurveyQuestionResponse>();
            CreateMap<SurveyQuestionResponse, SurveyQuestion>();

            CreateMap<SurveyQuestionOfferedAnswer, SurveyQuestionOfferedAnswerResponse>();
            CreateMap<SurveyQuestionOfferedAnswer, SurveyQuestionOfferedAnswerResponse>();

        }
    }
}
