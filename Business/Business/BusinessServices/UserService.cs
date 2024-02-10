using AutoMapper;
using Edulms.Business.IBusinessServices;
using Edulms.Data;
using Edulms.DTO;
using Edulms.Shared.OperationResult;
using System.Linq.Expressions;

namespace Edulms.Business.BusinessServices
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public UserService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public OperationResult Add(UserDto refDataDTO)
        {
            throw new NotImplementedException();
        }

        public UserDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public UserDto Get(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetAll()
        {
            List<User> user =_context.Users.ToList();
            var userDto = _mapper.Map<IList<UserDto>>(user);
            return (List<UserDto>)userDto;
        }

        public OperationResult Remove(int id)
        {
            throw new NotImplementedException();
        }

        public OperationResult Update(UserDto refDataDTO)
        {
            throw new NotImplementedException();
        }
    }
}
