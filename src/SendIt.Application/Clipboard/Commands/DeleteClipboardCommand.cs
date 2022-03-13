using MediatR;
using SendIt.Application.Common.Interfaces;

namespace SendIt.Application.Clipboard.Commands
{
    public class DeleteClipboardRequest : IRequest<DeleteClipboardResponse>
    {
        public int ClipboardId { get; set; }
    }

    public class DeleteClipboardResponse
    {
        public bool Success { get; set; }
    }

    internal class DeleteClipboardRequestHandler : IRequestHandler<DeleteClipboardRequest, DeleteClipboardResponse>
    {
        private readonly IClipboardRepository _clipboardRepository;
        public DeleteClipboardRequestHandler(IClipboardRepository clipboardRepository)
        {
            _clipboardRepository = clipboardRepository ?? throw new ArgumentNullException(nameof(DeleteClipboardRequestHandler));
        }

        public Task<DeleteClipboardResponse> Handle(DeleteClipboardRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request), nameof(DeleteClipboardRequestHandler));

            return Handle(request, cancellationToken);
        }

        private Task<DeleteClipboardResponse> HandleAsync(DeleteClipboardRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
