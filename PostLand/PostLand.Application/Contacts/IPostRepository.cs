using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PostLand.Application.Contracts.Persistence
{
    public interface IPostRepository : IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostsAsync();
        Task<Post> GetPostByIdAsync(string id , bool cat);
    }
}
