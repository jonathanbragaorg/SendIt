using FluentValidation.Results;

namespace SendIt.Application.Common.Exception
{
    public class ValidationException: System.Exception
    {
        public IDictionary<string, string[]> Errors { get; private set; }

        public ValidationException()
            : base("One or more Validation failures have occurred.")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures)
           : this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary(failureGroup => failureGroup.Key, failureGroup => failureGroup.ToArray());
        }
    }
}
