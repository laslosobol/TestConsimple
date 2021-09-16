using System.Text.Json;
using TestConsimple.Data;

namespace TestConsimple.Logic
{
    public static class Deserializer
    {
        public static Root Deserialize(string input)
        {
            return JsonSerializer.Deserialize<Root>(input);
        }
    }
}