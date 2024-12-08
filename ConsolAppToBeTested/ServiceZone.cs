namespace ConsolAppToBeTested
{
    public class ServiceZone:IServiceZone
    {
        public bool IsDanger { get; set; }
    }
    public interface IServiceZone
    {
        bool IsDanger { get; set; }
    }
}
