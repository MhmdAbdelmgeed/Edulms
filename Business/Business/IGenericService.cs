using Edulms.Shared.OperationResult;
using System.Linq.Expressions;

namespace Edulms.Business
{
    public interface IGenericService<DTO, Entity>
    {
        List<DTO> GetAll();

        DTO Get(int id);

        DTO Get(Expression<Func<Entity, bool>> expression);

        OperationResult Add(DTO refDataDTO);

        OperationResult Update(DTO refDataDTO);

        OperationResult Remove(int id);
    }

}
