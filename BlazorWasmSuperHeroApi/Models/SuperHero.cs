using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models;

public sealed record SuperHeroResponse(string? Response, List<SuperHero>? Results, string? Error);

public sealed record SuperHero(
    string Id,
    string Name,
    Powerstats? Powerstats,
    Biography? Biography,
    Appearance? Appearance,
    Work? Work,
    Connections? Connections,
    ImageInfo? Image);

public sealed record Powerstats(
    string? Intelligence,
    string? Strength,
    string? Speed,
    string? Durability,
    string? Power,
    string? Combat);

public sealed record Biography(
    [property: JsonPropertyName("full-name")] string? FullName,
    [property: JsonPropertyName("alter-egos")] string? AlterEgos,
    List<string>? Aliases,
    [property: JsonPropertyName("place-of-birth")] string? PlaceOfBirth,
    [property: JsonPropertyName("first-appearance")] string? FirstAppearance,
    string? Publisher,
    string? Alignment);

public sealed record Appearance(
    string? Gender,
    string? Race,
    List<string>? Height,
    List<string>? Weight,
    [property: JsonPropertyName("eye-color")] string? EyeColor,
    [property: JsonPropertyName("hair-color")] string? HairColor);

public sealed record Work(string? Occupation, string? Base);

public sealed record Connections(
    [property: JsonPropertyName("group-affiliation")] string? GroupAffiliation,
    string? Relatives);

public sealed record ImageInfo(string? Url);

[JsonSourceGenerationOptions(PropertyNameCaseInsensitive = true, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(SuperHeroResponse))]
internal sealed partial class SuperHeroJsonContext : JsonSerializerContext;
