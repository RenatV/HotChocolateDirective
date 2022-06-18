namespace HotchocolateExample.GraphQL;

public class UserType : ObjectType<User>
{
    protected override void Configure(IObjectTypeDescriptor<User> descriptor)
    {
        descriptor.Field(x => x.Name)
            .Directive<TestDirective>()
            .Deprecated();

        descriptor.Field(x => x.Email)
            .Directive("Test");

        descriptor.Field(x => x.Id)
            .Directive<TestDirective>();
    }
}