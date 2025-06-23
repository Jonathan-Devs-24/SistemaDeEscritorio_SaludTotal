using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

public class DateOnlyJsonConverter : JsonConverter<DateOnly>
{
    private const string Formato = "yyyy-MM-dd";

    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var fechaTexto = reader.GetString();
        if (DateOnly.TryParseExact(fechaTexto, Formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out var fecha))
        {
            return fecha;
        }

        throw new JsonException($"No se pudo convertir '{fechaTexto}' a DateOnly.");
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Formato));
    }
}
