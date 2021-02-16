using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SL.Survey.Entities.Model;
using SL.Survey.Entities.Dto;

namespace SL.Survey.Api.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OfferedAnswer, OfferedAnswerDto>();
            CreateMap<OfferedAnswerDto, OfferedAnswer>();

            CreateMap<Question, QuestionDto>();
            CreateMap<QuestionDto, Question>();

            CreateMap<QuestionType, QuestionTypeDto>();
            CreateMap<QuestionTypeDto, QuestionType>();

            CreateMap<SL.Survey.Entities.Model.Survey, SurveyDto>();
            CreateMap<SurveyDto, SL.Survey.Entities.Model.Survey>();

            CreateMap<SurveyQuestion, SurveyQuestionDto>();
            CreateMap<SurveyQuestionDto, SurveyQuestion>();                       

            CreateMap<SurveyQuestionOfferedAnswer, SurveyQuestionOfferedAnswerDto>();
            CreateMap<SurveyQuestionOfferedAnswer, SurveyQuestionOfferedAnswerDto>();

        }
    }
}
