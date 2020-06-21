using DBHandler;

namespace RealEstate
{
    public class UserController : BaseController<User, UserRepository>
    {
        public UserController(UserRepository userRepository) : base(userRepository)
        {
        }
    }
}