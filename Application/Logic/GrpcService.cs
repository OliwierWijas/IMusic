using Grpc.Core;
using Grpc.Net.Client;

namespace Application.Logic;

public class GrpcService
{
    public readonly GrpcChannel Channel;

    public GrpcService()
    {
        Channel = GrpcChannel.ForAddress("http://localhost:8080", new GrpcChannelOptions
        {
            Credentials = ChannelCredentials.Insecure
        });
    }
}