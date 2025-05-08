namespace Services.Export;

public interface IExportService
{
    string ExportToCsv<T>(IEnumerable<T> data, Dictionary<string, Func<T, object>> properties);

    string ExportToJson<T>(IEnumerable<T> data, Dictionary<string, Func<T, object>> properties);
}