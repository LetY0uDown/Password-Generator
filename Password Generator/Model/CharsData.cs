namespace Password_Generator.Model;

public class CharsData
{
    public static string BigChars { get; set; } = "QWERTYUIOPASDFGHJLKZXCVBNM";
    public static string SmallChars { get; set; } = "qwertyuiopasdfghjklzxcvbnm";

    public static string Numbers { get; set; } = "0123456789";
    public static string Symbols { get; set; } = "!@#$%^&*?_-.,<>";

    public static string TargetWord { get; set; }
}