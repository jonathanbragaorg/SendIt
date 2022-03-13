using MediatR;
using SendIt.Application.Common.Interfaces;
using SendIt.Application.Dtos;

namespace SendIt.Application.Clipboard.Commands
{
    public class CreateClipboardRequest: IRequest<CreateClipboardResponse>
    {
        public ClipboardDto Data { get; set; }
    }

    public class CreateClipboardResponse
    {
        public ClipboardDto Data { get; set; }
    }

    internal class CreateClipboardRequestHandler : IRequestHandler<CreateClipboardRequest, CreateClipboardResponse>
    {
        private readonly IClipboardRepository _clipboardRepository;
        public CreateClipboardRequestHandler(IClipboardRepository clipboardRepository)
        {
            _clipboardRepository = clipboardRepository ?? throw new ArgumentNullException(nameof(CreateClipboardRequestHandler));
        }

        public Task<CreateClipboardResponse> Handle(CreateClipboardRequest request, CancellationToken cancellationToken)
        {
            if(request == null)
                throw new ArgumentNullException(nameof(request), nameof(CreateClipboardRequestHandler));

            return HandleAsync(request, cancellationToken);
        }

        private Task<CreateClipboardResponse> HandleAsync(CreateClipboardRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
