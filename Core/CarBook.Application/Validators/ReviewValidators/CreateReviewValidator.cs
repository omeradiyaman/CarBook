using CarBook.Application.Features.Mediator.Commands.ReviewCommands;
using CarBook.Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Validators.ReviewValidators
{
	public class CreateReviewValidator : AbstractValidator<CreateReviewCommand>
	{
        public CreateReviewValidator()
        {
            RuleFor(x=>x.CustomerName).NotEmpty().WithMessage("Lütfen Müşteri Adını Boş Geçmeyiniz!");
            RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen Ad Soyad Giriniz!");
            RuleFor(x => x.RatingValue).NotEmpty().WithMessage("Lütfen Puan Değerini Boş Geçmeyiniz!");
            RuleFor(x => x.Comment).MinimumLength(20).WithMessage("Yorum en az 20 karakterden oluşmalı!");
            RuleFor(x => x.Comment).MaximumLength(100).WithMessage("Lütfen yorumunuzu 100 karakterden az tutun!");
        }
    }
}
