#nullable enable

namespace BraveSearch.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebSearchUnitsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::BraveSearch.WebSearchUnits>
    {
        /// <inheritdoc />
        public override global::BraveSearch.WebSearchUnits Read(
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
                        return global::BraveSearch.WebSearchUnitsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::BraveSearch.WebSearchUnits)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::BraveSearch.WebSearchUnits);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::BraveSearch.WebSearchUnits value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::BraveSearch.WebSearchUnitsExtensions.ToValueString(value));
        }
    }
}
