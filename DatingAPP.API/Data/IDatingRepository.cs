using System.Collections.Generic;
using System.Threading.Tasks;
using DatingAPP.API.Helpers;
using DatingAPP.API.Models;

namespace DatingAPP.API.Data
{
    public interface IDatingRepository
    {
         void Add<T>(T entity) where T: class;

         void Delete<T>(T entity) where T: class;

         Task<bool> SaveAll();

         Task<PageList<User>> GetUsers(UserParams userParams);

         Task<User> GetUser(int id);

         Task<Photo> GetPhoto(int id);

         Task<Photo> GetMainPhotoForUser(int userId);

         Task<Like> GetLike(int userId, int recipientId);

        // get single message
         Task<Message> GetMessage(int id);

         Task<PageList<Message>> GetMessagesForUser(MessageParams messageParams);

         Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId);
    } 
}