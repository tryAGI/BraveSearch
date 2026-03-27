
#nullable enable

namespace BraveSearch
{
    /// <summary>
    /// Container for local/location results.
    /// </summary>
    public sealed partial class Locations
    {
        /// <summary>
        /// The type identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// List of location results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::BraveSearch.LocationResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Locations" /> class.
        /// </summary>
        /// <param name="type">
        /// The type identifier.
        /// </param>
        /// <param name="results">
        /// List of location results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Locations(
            string? type,
            global::System.Collections.Generic.IList<global::BraveSearch.LocationResult>? results)
        {
            this.Type = type;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Locations" /> class.
        /// </summary>
        public Locations()
        {
        }
    }
}