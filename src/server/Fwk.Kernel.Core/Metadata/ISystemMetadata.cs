namespace Fwk.Kernel.Core.Metadata
{
    public interface ISystemMetadata
    {
        CancellationToken cancellationToken { get; }

        Dictionary<string, string> Metadata { get; }
    }
}
