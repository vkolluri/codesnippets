JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Formatting.Indented,
    ReferenceResolverProvider = () => new ReferenceResolverWithNames()
}