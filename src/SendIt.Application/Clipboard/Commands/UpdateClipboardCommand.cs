using MediatR;
using SendIt.Application.Common.Interfaces;
using SendIt.Application.Dtos;

namespace SendIt.Application.Clipboard.Commands
{
    public class UpdateClipboardRequest : IRequest<UpdateClipboardResponse>
    {
        public ClipboardDto Data { get; set; }
    }

    public class UpdateClipboardResponse
    {
        public ClipboardDto Data { get; set; }
    }

    internal class UpdateClipboardRequestHandler : IRequestHandler<UpdateClipboardRequest, UpdateClipboardResponse>
    {
        private readonly IClipboardRepository _clipboardRepository;
        public UpdateClipboardRequestHandler(IClipboardRepository clipboardRepository)
        {
            _clipboardRepository = clipboardRepository ?? throw new ArgumentNullException(nameof(UpdateClipboardRequestHandler));
        }

        public Task<UpdateClipboardResponse> Handle(UpdateClipboardRequest request, CancellationToken cancellationToken)
        {
            if(request == null)
                throw new ArgumentNullException(nameof(request), nameof(UpdateClipboardResponse));

            return HandleAsync(request, cancellationToken);
        }
        private Task<UpdateClipboardResponse> HandleAsync(UpdateClipboardRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
