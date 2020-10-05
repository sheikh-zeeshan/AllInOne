using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Helpers
{
    public class CustomValidationAttribute : ValidationAttribute
    {
        public CustomValidationAttribute(string text)
        {
            Text = text;
        }
        public CustomValidationAttribute()
        {

        }

        public CustomValidationAttribute(string ErrorMessage, string Text)
        {
            this.ErrorMessage = ErrorMessage;
            this.Text = Text;
        }

        public string Text { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string bookName = value.ToString();
                if (bookName.Contains(Text))
                {
                    return ValidationResult.Success;
                }
                // return base.IsValid(value, validationContext);
                return new ValidationResult(ErrorMessage ?? "value is not correct");
            }

            return new ValidationResult(ErrorMessage ?? "value is empty");
        }
    }
}
