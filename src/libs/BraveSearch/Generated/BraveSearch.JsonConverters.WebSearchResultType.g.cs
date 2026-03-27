#nullable enable

namespace BraveSearch.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebSearchResultTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BraveSearch.WebSearchResultType>
    {
        /// <inheritdoc />
        public override global::BraveSearch.WebSearchResultType Read(
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
                        return global::BraveSearch.WebSearchResultTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BraveSearch.WebSearchResultType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BraveSearch.WebSearchResultType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BraveSearch.WebSearchResultType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BraveSearch.WebSearchResultTypeExtensions.ToValueString(value));
        }
    }
}
