namespace Fwk.Kernel.Core.Metadata
{
    public class SystemMetadata : ISystemMetadata
    {
        public CancellationToken cancellationToken { get; }

        public Dictionary<string, string> Metadata { get; }

        public SystemMetadata()
        {
            cancellationToken = default;
            Metadata = new Dictionary<string, string>();
        }

        public SystemMetadata(CancellationToken token) : this()
        {
            cancellationToken = token;
        }
    }
}
