using clean_architecture_demo_v2.Domain.Entity;
using clean_architecture_demo_v2.Domain.Repository;
using clean_architecture_demo_v2.Framing.Data;
using Microsoft.EntityFrameworkCore;

namespace clean_architecture_demo_v2.Framing.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _blogDbcontext;

        public BlogRepository(BlogDbContext blogDbcontext)
        {
            _blogDbcontext = blogDbcontext;
        }

        public async Task<Blog> CreateBlogAsync(Blog blog)
        {
            await _blogDbcontext.Blogs.AddAsync(blog);
            await _blogDbcontext.SaveChangesAsync();
            return blog;
        }

        public async Task<int> DeleteBlogAsync(int id)
        {
            return await _blogDbcontext.Blogs
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            return await _blogDbcontext.Blogs.ToListAsync();
        }

        public async Task<Blog> GetByIdAsync(int id)
        {
            return await _blogDbcontext.Blogs
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> UpdateBlogAsync(int id, Blog blog)
        {
            return await _blogDbcontext.Blogs
                .Where(b => b.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(p => p.Name, blog.Name)
                    .SetProperty(p => p.Description, blog.Description)
                    .SetProperty(p => p.Author, blog.Author)
                );
        }
    }
}
