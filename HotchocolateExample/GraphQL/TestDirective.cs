namespace HotchocolateExample.GraphQL;
public sealed class TestDirective : DirectiveType
{
    protected override void Configure(IDirectiveTypeDescriptor descriptor)
    {
        descriptor
            .Name("Test")
            .Description("Test")
            .Location(DirectiveLocation.FieldDefinition)
            .Location(DirectiveLocation.ArgumentDefinition)
            .Location(DirectiveLocation.InputFieldDefinition)
            .Location(DirectiveLocation.EnumValue);
    }
}
