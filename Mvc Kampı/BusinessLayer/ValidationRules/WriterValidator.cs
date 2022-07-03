using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x=>x.WriterName).NotEmpty().WithMessage("Yazar adı boş geçilemez");
            RuleFor(x=>x.WriterMail).NotEmpty().WithMessage("Mail geçilemez");
            RuleFor(x=>x.WriterPassword).NotEmpty().WithMessage("Şifre Boş geçilemez");
            RuleFor(x=>x.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter girişi yapın");
            RuleFor(x=>x.WriterName).MaximumLength(50).WithMessage("Max 50 karakter!");
            RuleFor(x=>x.WriterImage).NotEmpty().WithMessage("Image kısmı boş olamaz");
        }
    }
}