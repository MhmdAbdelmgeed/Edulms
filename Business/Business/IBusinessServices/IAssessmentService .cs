using Edulms.Data;
using Edulms.DTO;
using Edulms.Shared.ServiceRegister;

namespace Edulms.Business.IBusinessServices
{
    public interface IAssessmentService : IGenericService<AssessmentDto, Assessment>, IScopedService
    {
    }
}
