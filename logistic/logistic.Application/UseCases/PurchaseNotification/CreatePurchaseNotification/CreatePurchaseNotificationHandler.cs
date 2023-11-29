using AutoMapper;
using MediatR;

public class CreatePurchaseNotificationHandler : IRequestHandler<CreatePurchaseNotificationRequest, CreatePurchaseNotificationResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPurchaseNotificationRepository _purchaseNotificationRepository;
    private readonly IMapper _mapper;

    public CreatePurchaseNotificationHandler(IUnitOfWork unitOfWork, IPurchaseNotificationRepository purchaseNotificationRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _purchaseNotificationRepository = purchaseNotificationRepository;
        _mapper = mapper;
    }
    public async Task<CreatePurchaseNotificationResponse> Handle(CreatePurchaseNotificationRequest request, CancellationToken cancellationToken)
    {
        var purchaseNotification = _mapper.Map<PurchaseNotification>(request);

        _purchaseNotificationRepository.Create(purchaseNotification);

        await _unitOfWork.Commit(cancellationToken);

        return _mapper.Map<CreatePurchaseNotificationResponse>(purchaseNotification);
    }
}