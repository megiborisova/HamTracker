/*using System.Text.Json;
using System.Text.Json.Serialization;

public class FoodConverter : JsonConverter<Food>
{
    public override Food Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    { as
        using var jsonDoc=JsonDocument.Parsevalue(ref reader);
        var root= jsonDoc.RootElement;

        if (!root.TryGetProperty("Type",out var typeProperty))
            throw new JsonException("Missing Type Info");

        var type=typeProperty.GetString();
        var json=root.GetRawText();

        return type switch
        {
            "SolidFood"=>JsonSerializer.Deserialize<SolidFood>(json,options),
            "DrinkFood"=>JsonSerializer.Deserialize<DrinkFood>(json,options),
            _=>JsonSerializer.Deserialize<Food>(json,options),
        };
    }

    public override void Write(Utf8JsonWriter writer, Food value, JsonSerializerOptions options)
    {
        var type=value.GetCategory();
        using var jsonDoc=JsonDocument.Parse(JsonSerializer.Serialize(value,value.GetType(), options));

        writer.WriteStartObject();
        writer.WriteString("Type",type);

        foreach (var prop in jsonDoc.RootElement.EnumerateObject())
        {
            prop.WriteTo(writer);
        }
        writer.WriteEndobject();
    }
}*/