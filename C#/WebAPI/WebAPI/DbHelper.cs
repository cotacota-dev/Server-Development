using System;
namespace WebAPI
{
	public class DbHelper
	{
        private DataContext _context;
        public DbHelper(DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetUsers()
        {
            List<UserModel> response = new List<UserModel>();
            var dataList = _context.User.ToList();
            dataList.ForEach(row => response.Add(new UserModel()
            {
                userId = row.user_id,
                email = row.email,
                password = row.password,
            }));
            return response;
        }
        
    }
}

