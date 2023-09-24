using System.ComponentModel;
using System.Dynamic;

namespace AutoEatery.Services;

public static class HAL
{
    public static dynamic PaginateAsDynamic(string baseUrl, int index, int count, int total)
    {
        dynamic links = new ExpandoObject();
        links.self = new { href = baseUrl };
        if (index < total)
        {
            links.next = new { href = $"{baseUrl}?index={index + count}" };
            links.final = new { href = $"{baseUrl}?index={total - total % count}&count={count}" };
        }

        if (index > 0)
        {
            links.prev = new { href = $"{baseUrl}?index={index - count}" };
            links.first = new { href = $"{baseUrl}?index=0" };
        }

        return links;
    }

    public static Dictionary<string, object> PaginateAsDictionary(string baseUrl, int index, int count, int total)
    {
        var links = new Dictionary<string, object>();
        links.Add("self", new { href = "/api/vehicles" });
        if (index < total)
        {
            links["next"] = new { href = $"/api/vehicles?index={index + count}" };
            links["final"] = new { href = $"{baseUrl}?index={total - (total % count)}&count={count}" };
        }

        if (index > 0)
        {
            links["prev"] = new { href = $"/api/vehicles?index={index - count}" };
            links["first"] = new { href = $"/api/vehicles?index=0" };
        }

        return links;
    }

    public static dynamic ToDynamic(this object value)
    {
        IDictionary<string, object> result = new ExpandoObject();
        var properties = TypeDescriptor.GetProperties(value.GetType());
        foreach (PropertyDescriptor prop in properties)
        {
            if (Ignore(prop)) continue;
            result.Add(prop.Name, prop.GetValue(value));
        }

        return result;
    }

    public static dynamic ToResource(this object o, string apiPath, int id)
    {
        var resource = o.ToDynamic();
        resource._links = new {
            self = new {
                href = $"{apiPath}/{id}"
            }
        };
        return resource;
    }

    private static bool Ignore(PropertyDescriptor prop)
    {
        return prop.Attributes.OfType<System.Text.Json.Serialization.JsonIgnoreAttribute>().Any();
    }
}