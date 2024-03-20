using AutoMapper;
using MediatR;
using PostLand.Application.Contracts.Persistence;
using PostLand.Application.Features.Posts.Commands.DeletePost;
using PostLand.Domain;


namespace TestProject.Application.Features.Test.Commands.DeleteTest;

public class DeleteTestCommandHandler : IRequestHandler<DeletePostCommand, string>
{
    private readonly IAsyncRepository<Post> _asyncRepository;

    public DeleteTestCommandHandler(IAsyncRepository<Post> asyncRepository)
    {
        _asyncRepository = asyncRepository;
    }

    public async Task<string> Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        var post = await _asyncRepository.GetByIdAsync(request.PostId);
        await _asyncRepository.DeleteAsync(post);
        return post.Id;

    }
}