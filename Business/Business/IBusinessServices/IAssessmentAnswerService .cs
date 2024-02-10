using Edulms.Data;
using Edulms.DTO;
using Edulms.Shared.OperationResult;
using Edulms.Shared.ServiceRegister;

namespace Edulms.Business.IBusinessServices
{
    public interface IAssessmentAnswerService : IGenericService<AssessmentAnswerDto, Assessment_Answer>, IScopedService
    {
        Task<OperationResult> Add(AssessmentAnswerDto refDataDTO);

    }
}
