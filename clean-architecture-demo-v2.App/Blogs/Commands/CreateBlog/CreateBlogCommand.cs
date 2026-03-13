using clean_architecture_demo_v2.App.Blogs.Queries.GetBlogs;
using MediatR;

namespace clean_architecture_demo_v2.App.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommand : IRequest<BlogVm>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
    }
}
