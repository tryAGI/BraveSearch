
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace BraveSearch
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::BraveSearch.JsonConverters.WebSearchResultTypeJsonConverter),

            typeof(global::BraveSearch.JsonConverters.WebSearchResultTypeNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.SummarizerSearchResultStatusJsonConverter),

            typeof(global::BraveSearch.JsonConverters.SummarizerSearchResultStatusNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.WebSearchSafesearchJsonConverter),

            typeof(global::BraveSearch.JsonConverters.WebSearchSafesearchNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.WebSearchUnitsJsonConverter),

            typeof(global::BraveSearch.JsonConverters.WebSearchUnitsNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.ImageSearchSafesearchJsonConverter),

            typeof(global::BraveSearch.JsonConverters.ImageSearchSafesearchNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.VideoSearchSafesearchJsonConverter),

            typeof(global::BraveSearch.JsonConverters.VideoSearchSafesearchNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.NewsSearchSafesearchJsonConverter),

            typeof(global::BraveSearch.JsonConverters.NewsSearchSafesearchNullableJsonConverter),

            typeof(global::BraveSearch.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Query))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.MetaUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Thumbnail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Profile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.WebSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.WebSearchResultType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.WebSearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.WebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.DiscussionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.DiscussionResultData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Discussions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.DiscussionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.FaqResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Faq))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.FaqResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.InfoboxResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.InfoboxResultAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.InfoboxResultAttribute))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.Profile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.InfoboxResultRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.InfoboxResultRating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Infobox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.InfoboxResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.VideoData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.VideoResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.VideoResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.VideoResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.NewsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.NewsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.NewsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ImageProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ImageResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ImageSearchResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.ImageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SuggestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SuggestResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.SuggestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SummarizerSearchResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SummarizerSearchResultStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.SummaryMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SummaryMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SummarizerSearchResultEnrichments))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::BraveSearch.EntityInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.EntityInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultPostalAddress))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultOpeningHours))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.LocationResultOpeningHoursCurrentDayItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultOpeningHoursCurrentDayItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::BraveSearch.LocationResultOpeningHoursDay>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.LocationResultOpeningHoursDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultOpeningHoursDay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultContact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultRating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.LocationResultReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultReview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.LocationResultReviewRating))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.Locations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.LocationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.MixedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::BraveSearch.ResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ResultReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.WebSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ImageSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.VideoSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.NewsSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.SuggestSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.WebSearchSafesearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.WebSearchUnits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.ImageSearchSafesearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.VideoSearchSafesearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::BraveSearch.NewsSearchSafesearch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.WebSearchResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.DiscussionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.FaqResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.InfoboxResultAttribute>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.Profile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.InfoboxResultRating>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.InfoboxResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.VideoResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.NewsResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.ImageResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.SuggestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.SummaryMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.LocationResultOpeningHoursCurrentDayItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::BraveSearch.LocationResultOpeningHoursDay>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.LocationResultOpeningHoursDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.LocationResultReview>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.LocationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::BraveSearch.ResultReference>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}