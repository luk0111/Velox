namespace Velox.Core.Validation;

public sealed class ValidationResult
{
    private static readonly ValidationResult SuccessResult = new([]);

    public IReadOnlyList<ValidationError> Errors { get; }
    public bool IsValid => Errors.Count == 0;

    private ValidationResult(IReadOnlyList<ValidationError> errors)
    {
        Errors = errors;
    }

    public static ValidationResult Success() => SuccessResult;

    public static ValidationResult Failure(IEnumerable<ValidationError> errors)
    {
        var materialized = errors?.ToList() ?? [];
        return materialized.Count == 0 ? SuccessResult : new ValidationResult(materialized);
    }
}

