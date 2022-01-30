using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<User>
    {
        
        public UserValidator()
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[$@!%*?+#&'()[=\"€])[A-Za-z\\d$@!%*?+#&'()[=\"€']{8,}");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Yazar adı soyadı alanı doldurulmalıdır!!");
            RuleFor(x => x.UserTcIdentificationNumber).NotEmpty().WithMessage("Tc Kimlik alanı doldurulmalıdır.");
            RuleFor(x => x.UserEmail).NotEmpty().WithMessage("Email alanı doldurulmalıdır.");
            RuleFor(x => x.UserMobileNumber).NotEmpty().WithMessage("Email alanı doldurulmalıdır.");
            RuleFor(x => x.UserPassword).NotEmpty().WithMessage("Email alanı doldurulmalıdır.");
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Lütfen en az 2 karakterlik veri girişi yapın!!");
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakterlik veri girişi yapın!!");
            RuleFor(x => x.UserPassword).Matches(regex).WithMessage("Şifre en az bir küçük harf, bir büyük harf, 1 özel karakter ve 1 rakam içermelidir. Ve en az 8 karakter olmalıdır!!");
            RuleFor(x => x.UserEmail).EmailAddress().WithMessage("Lütfen doğru bir formatta mail adresinizi girin.");
    
            RuleFor(x => x.UserTcIdentificationNumber).Length(11).WithMessage("Tc Kimlik numarası 11 haneli olmalıdır.");






        }
    }
}



        

