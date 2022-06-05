using CourseLibrary.API.Models;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var course = (CourseForCreateDto)validationContext.ObjectInstance;

            if (course.Title == course.Description)
            {
                return new ValidationResult(
                    "The provided description should be different from the title.",
                    new[] { nameof(CourseForCreateDto) });
            }
            return ValidationResult.Success;
        }
    }
}
