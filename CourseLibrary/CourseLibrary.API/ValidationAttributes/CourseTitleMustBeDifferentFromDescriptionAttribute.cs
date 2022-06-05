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
                return new ValidationResult(ErrorMessage,
                    new[] { nameof(CourseForCreateDto) });
            }
            return ValidationResult.Success;
        }
    }
}
