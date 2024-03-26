using System;
namespace GraphQLWithNetCore.Schema.Queries
{
    public class LocationQueryType : ObjectType<LocationQueries>
    {
        protected override void Configure(IObjectTypeDescriptor<LocationQueries> descriptor)
        {
            base.Configure(descriptor);

            descriptor
              .Field(f => f.GetLocations(default!));
    
      descriptor
        .Field(f => f.GetLocation(default!, default!))
        .Argument("code", a => a.Type<StringType>());
        }
    }
}

