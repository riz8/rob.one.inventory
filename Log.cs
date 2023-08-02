using BepInEx.Logging;

namespace RobOne.Inventory;

internal static class Log
{
    public static void Initialize(ManualLogSource logger)
        => _logger = logger;

    #region Interface
    public static void Debug(object text)
        => _logger.Log(LogLevel.Debug, text);

    public static void Message(object text)
        => _logger.Log(LogLevel.Message, text);

    public static void Warning(object text)
        => _logger.Log(LogLevel.Warning, text);

    public static void Error(object text)
        => _logger.Log(LogLevel.Error, text);
    #endregion

    private static ManualLogSource _logger;
}
