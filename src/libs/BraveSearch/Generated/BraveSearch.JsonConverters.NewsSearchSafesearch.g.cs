#nullable enable

namespace BraveSearch.JsonConverters
{
    /// <inheritdoc />
    public sealed class NewsSearchSafesearchJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BraveSearch.NewsSearchSafesearch>
    {
        /// <inheritdoc />
        public override global::BraveSearch.NewsSearchSafesearch Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::BraveSearch.NewsSearchSafesearchExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BraveSearch.NewsSearchSafesearch)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BraveSearch.NewsSearchSafesearch);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BraveSearch.NewsSearchSafesearch value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BraveSearch.NewsSearchSafesearchExtensions.ToValueString(value));
        }
    }
}
