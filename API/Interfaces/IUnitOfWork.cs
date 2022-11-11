using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get;}
        IMessageRepository MessageRepository {get;}
        ILikeRepository LikesRepository {get;}
        IPhotoRepository PhotoRepository {get;}
        Task<bool> Complete();
        bool HasChanges();
    }
}