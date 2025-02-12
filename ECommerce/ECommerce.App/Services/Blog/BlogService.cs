using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerce.App.Interfaces.Admin;
using ECommerce.App.Interfaces.Blog;
using ECommerce.Core.DataTransferObjects;
using ECommerce.Core.DataTransferObjects.Responses;
using ECommerce.Core.Entities.Blog;
using ECommerce.Core.Interfaces.Blog;

namespace ECommerce.App.Services.Blog
{
    public class BlogService : IBlogService
    {
        private readonly IBlogsRepository<BlogEf> _blogsRepository;
        
        public BlogService(IBlogsRepository<BlogEf> blogsRepository)
        {
            _blogsRepository = blogsRepository;
        }


        public Task<ResponseType1<bool>> CreateBlogAsync(BlogDto blog)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResponseType1<BlogDto>> GetBlogAsync(int idBlog)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResponseType1<IEnumerable<BlogDto>>> GetBlogsAsync(int currentPage = 1, int amountOfItems = 16)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<BlogDto>> FindBlogsAsync(string search, int currentPage = 1, int amountOfItems = 16)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResponseType1<bool>> UpdateBlogAsync(BlogDto blog)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResponseType1<bool>> DeleteBlogAsync(int idBlog)
        {
            throw new System.NotImplementedException();
        }
    }
}