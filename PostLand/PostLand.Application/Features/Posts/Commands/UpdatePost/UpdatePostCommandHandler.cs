using AutoMapper;
using PostLand.Application.Contracts.Persistence;
using PostLand.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Commands.UpdatePost
{
    public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand, string>
    {
        private readonly IAsyncRepository<Post> _asyncRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommandHandler(IAsyncRepository<Post> asyncRepository, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            Post test = _mapper.Map<Post>(request);
            await _asyncRepository.UpdateAsync(test);
            return test.Id;
        }

    }
}