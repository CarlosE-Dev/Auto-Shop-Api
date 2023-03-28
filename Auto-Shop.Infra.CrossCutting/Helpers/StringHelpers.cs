namespace Auto_Shop.Infra.CrossCutting.Helpers
{
    public static class StringHelpers
    {
        public static string TransformToCamelCase(string text)
        {
            return char.ToUpper(text[0]) + text.Substring(1).ToLower();
        }
    }
}
