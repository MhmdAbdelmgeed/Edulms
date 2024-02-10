using Edulms.Business.IBusinessServices;
using Edulms.Data;
using Edulms.DTO;
using Edulms.Shared.OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Business.BusinessServices
{
    public class AssessmentService : IAssessmentService
    {
        public OperationResult Add(AssessmentDto refDataDTO)
        {
            throw new NotImplementedException();
        }

        public AssessmentDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public AssessmentDto Get(Expression<Func<Assessment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<AssessmentDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public OperationResult Remove(int id)
        {
            throw new NotImplementedException();
        }

        public OperationResult Update(AssessmentDto refDataDTO)
        {
            throw new NotImplementedException();
        }
    }
}
