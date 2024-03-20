using MediatR;
using System;

namespace PostLand.Application.Features.Posts.Commands.DeletePost
{
    public class DeletePostCommand : IRequest<string>
    
    {
        public string PostId { get; set; }
    }

}