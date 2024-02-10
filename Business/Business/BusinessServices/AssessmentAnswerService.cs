using AutoMapper;
using Edulms.Business;
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
    public class AssessmentAnswerService : IAssessmentAnswerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public AssessmentAnswerService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OperationResult> Add(AssessmentAnswerDto refDataDTO)
        {
            AssessmentAnswerDto AssessmentAnswerDto = _mapper.Map<AssessmentAnswerDto>(refDataDTO);
            Assessment_Answer AssessmentAnswer = _mapper.Map<Assessment_Answer>(AssessmentAnswerDto);
            _context.Assessment_Answer.AddAsync(AssessmentAnswer);
            await _context.SaveChangesAsync();

            return new OperationResult
            {
                Result = QueryResult.Succeeded
            };
        }

        public AssessmentAnswerDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public AssessmentAnswerDto Get(Expression<Func<Assessment_Answer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<AssessmentAnswerDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public OperationResult Remove(int id)
        {
            throw new NotImplementedException();
        }

        public OperationResult Update(AssessmentAnswerDto refDataDTO)
        {
            throw new NotImplementedException();
        }

        OperationResult IGenericService<AssessmentAnswerDto, Assessment_Answer>.Add(AssessmentAnswerDto refDataDTO)
        {
            throw new NotImplementedException();
        }
    }
}
