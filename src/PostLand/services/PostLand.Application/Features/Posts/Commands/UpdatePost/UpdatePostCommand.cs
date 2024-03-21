using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommand : IRequest<string>
    {
        public string Id { get; set; }
        public string Title { get; set; }
       
    }
}
