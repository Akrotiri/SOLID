namespace Solid.Banker.Logging
{
    public interface ILogger
    {
        void Log(string message, params object[] param);
    }
}