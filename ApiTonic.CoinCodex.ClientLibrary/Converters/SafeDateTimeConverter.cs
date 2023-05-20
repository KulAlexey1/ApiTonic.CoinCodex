using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ApiTonic.CoinCodex.ClientLibrary.Converters
{
    public class SafeDateTimeConverter : IsoDateTimeConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType,
            object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch(FormatException)
            {
                return existingValue;
            }
        }
    }
}
