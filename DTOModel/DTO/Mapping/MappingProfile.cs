using AutoMapper;
using Edulms.Data;

namespace Edulms.DTO.Mapping
{
    public class MappersProfile : Profile
    {
        public MappersProfile()
        {
            CreateMap<AssessmentAnswerDto, Assessment_Answer>().ReverseMap();
            CreateMap<AssessmentDataDto, Assessment_Data>().ReverseMap();
            CreateMap<AssessmentDepartmentDto, Assessment_Department>().ReverseMap();
            CreateMap<AssessmentDto, Assessment>().ReverseMap();
            CreateMap<AssessmentEnrolDto, Assessment_Enrol>().ReverseMap();
            CreateMap<AssessmentMatchDto, Assessment_Match>().ReverseMap();
            CreateMap<AssessmentMetaDto, Assessment_Meta>().ReverseMap();
            CreateMap<AssessmentOptionDto, Assessment_Option>().ReverseMap();
            CreateMap<AssessmentQuestionDto, Assessment_Question>().ReverseMap();
            CreateMap<AssessmentSectionDto, Assessment_Section>().ReverseMap();
            CreateMap<AssessmentTextDto, Assessment_Text>().ReverseMap();
            CreateMap<AssessmentTrueFalseDto, Assessment_True_False>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();

        }

    }
}
