namespace NuGet.Commands
{
  internal class NuGetSpecValidationStrings
  {
    public const string MissingRequiredProperty = "Missing required property '{0}'.";
    public const string MissingRequiredPropertyForProjectType = "Missing required property '{0}' for project type '{1}'.";
    public const string InvalidRestoreInput = "Invalid restore input. {0}";
    public const string ErrorXprojNotAllowed = "Invalid input '{0}'. XProj support has been removed. Support for XProj and standalone project.json files has been removed, to continue working with legacy projects use NuGet 3.5.x from https://nuget.org/downloads";
    public const string PropertyNotAllowedForProjectType = "Invalid input combination. Property '{0}' is not allowed for project type '{1}'.";
    public const string SpecValidationInvalidFramework = "Invalid target framework '{0}'.";
    public const string SpecValidationNoFrameworks = "No target frameworks specified.";
    public const string SpecValidationDuplicateFrameworks = "Duplicate frameworks found: '{0}'.";
    public const string SpecValidationUAPSingleFramework = "UAP projects must contain exactly one target framework.";
    public const string PropertyNotAllowed = "Invalid input combination. Property '{0}' is not allowed.";
  }
}
