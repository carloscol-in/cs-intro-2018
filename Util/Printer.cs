using static System.Console;

namespace CoreSchool.Util
{
    public static class Printer
    {
        public static void DrawLine(int size = 10)
        {
            var line = "".PadLeft(size, '=');
            WriteLine(line);
        }

        public static void WriteTitle(string title)
        {
            var line_size = title.Length + 6;
            var title_text = $"|| {title} ||";
            DrawLine(line_size);
            WriteLine(title_text);
            DrawLine(line_size);
        }
    }
}