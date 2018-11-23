namespace MyExtensions
{
    public static class ToUpperExtension {

        public static string toUpperExtension(this string str) {
            return str.ToUpper();
        }
    }

    public class ExtensionClass {

        public string toUpperWithExtensions(string str) {
            return str.toUpperExtension();
        }
    }
}
