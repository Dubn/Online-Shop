using System.ComponentModel.DataAnnotations;

namespace Online_Shop.ViewModels
{
    public class RegisterViewModel
    {
    [Required, EmailAddress, MaxLength(255), Display(Name = "Email Adress")]
    public string Email { get; set; }
    [Required, MinLength(5), MaxLength(60), DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
    [Required, MinLength(5), MaxLength(60), DataType(DataType.Password), Display(Name = "Confirm Password")]
    [Compare("Password", ErrorMessage ="The password does not match the confirmation password")]
    public string ConfirmPassword { get; set; }
}
}
