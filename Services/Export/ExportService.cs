using System.Text;
using System.Text.Json;

namespace Services.Export;

public class ExportService : IExportService
{
    public string ExportToCsv<T>(IEnumerable<T> data, Dictionary<string, Func<T, object>> properties)
    {
        var sb = new StringBuilder();

        sb.AppendLine(string.Join(",", properties.Keys.Select(EscapeCsvField)));

        foreach (var item in data)
        {
            var values = properties.Values.Select(propertyFunc =>
            {
                var value = propertyFunc(item);
                return EscapeCsvField(value?.ToString() ?? string.Empty);
            });

            sb.AppendLine(string.Join(",", values));
        }

        return sb.ToString();
    }

    public string ExportToJson<T>(IEnumerable<T> data, Dictionary<string, Func<T, object>> properties)
    {
        var result = data.Select(item =>
        {
            var exportObject = new Dictionary<string, object>();

            foreach (var property in properties)
            {
                var value = property.Value(item);
                exportObject.Add(property.Key, value ?? string.Empty);
            }

            return exportObject;
        });

        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        return JsonSerializer.Serialize(result, options);
    }

    private string EscapeCsvField(string field)
    {
        // Escape quotes by doubling them and wrap in quotes if necessary
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            return "\"" + field.Replace("\"", "\"\"") + "\"";
        }

        return field;
    }
}
