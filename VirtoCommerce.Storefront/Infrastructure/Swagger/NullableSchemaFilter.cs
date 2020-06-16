using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace VirtoCommerce.Storefront.Infrastructure.Swagger
{
    public class NullableSchemaFilter: ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            var type = context.Type;
            if (type.IsReferenceOrNullableType())
            {
                schema.Nullable = true;
            }
        }
    }
}
