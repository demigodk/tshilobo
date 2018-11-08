using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using tshilobo.Areas.Identity.Data;
using tshilobo.Areas.Identity.Data.SupportingCode.Register;

/// <summary>
/// Author      :       Bondo Kalombo   
/// Date        :       06/11/2018
/// </summary>
namespace tshilobo.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<tshiloboUser> _signInManager;
        private readonly UserManager<tshiloboUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<tshiloboUser> userManager,
            SignInManager<tshiloboUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }
        public SelectList Genders { get; set; }
        public SelectList Days { get; set; }
        public SelectList Months { get; set; }
        public SelectList Years { get; set; }
        private ListItems listItems = new ListItems();

        [TempData]
        public string Message { get; set; }
        public bool ShowMessage => !string.IsNullOrEmpty(Message);           // Used to determine if I need to show a message in Register

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "* First Name Required")]
            [DataType(DataType.Text)][Display(Name = "First Name")]
            [StringLength(100, ErrorMessage = "The {0} Must Be At Least {2} And At Max {1} Characters Long.", MinimumLength = 2)]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "* Last Name Required")][DataType(DataType.Text)]
            [Display(Name = "Last Name")]
            [StringLength(100, ErrorMessage = "The {0} Must Be At Least {2} And At Max {1} Characters Long.", MinimumLength = 2)]
            public string LastName { get; set; }

            [Required(ErrorMessage = "* Gender Required")]
            public string GenderId { get; set; }

            [Display(Name = "Birth Date")][DataType(DataType.Date)]
            public DateTime DateOfBirth { get; set; }

            /// <summary>
            /// Note: The fields GenderId, Day, Month, & Year were changed from int
            /// to string, because int is "strongly typed" as a result I could not
            /// customize the ErrorMessage, because it was defaulting to "The value " is invalid"
            /// </summary>
            [Required(ErrorMessage = "* Required")]            
            public string Day { get; set; }

            [Required(ErrorMessage = "* Required")]
            public string Month { get; set; }

            [Required(ErrorMessage = "* Required")]
            public string Year { get; set; }

            [Required(ErrorMessage = "* Email Required")][EmailAddress][Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "* Password Required")][DataType(DataType.Password)][Display(Name = "Password")]
            [StringLength(100, ErrorMessage = "The {0} Must Be At Least {2} And At Max {1} Characters Long.", MinimumLength = 6)]            
            public string Password { get; set; }

            [Required(ErrorMessage = "* Confirm Password Required")][DataType(DataType.Password)][Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The Password And Confirmation Password Do Not Match.")]
            public string ConfirmPassword { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;

            if (Genders == null || Days == null || Months == null || Years == null)            
                Genders = listItems.Genders(); Days = listItems.Days(); Months = listItems.Months(); Years = listItems.Years();                       
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (Genders == null || Days == null || Months == null || Years == null)            
                Genders = listItems.Genders(); Days = listItems.Days(); Months = listItems.Months(); Years = listItems.Years();            
           
            if (ModelState.IsValid)
            {                                                                            
                if (Convert.ToInt32(Input.Day) <= 30 && (Convert.ToInt32(Input.Month) == 4 || Convert.ToInt32(Input.Month) == 6
                    || Convert.ToInt32(Input.Month) == 9 || Convert.ToInt32(Input.Month) == 11))
                {
                    await CreateUserAsync(returnUrl);       // Validation for the months April, June, September & November
                }
                else if((Convert.ToInt32(Input.Day) <= 29) && (Convert.ToInt32(Input.Month) == 2) && (Convert.ToInt32(Input.Year) % 4 == 0))
                { 
                    await CreateUserAsync(returnUrl);       // Validation for Leap Year (February 29 Day Month)
                }
                else if((Convert.ToInt32(Input.Day) <= 28) && (Convert.ToInt32(Input.Month) == 2))
                {
                    await CreateUserAsync(returnUrl);       // Validation for normal February month
                }
                else if(Convert.ToInt32(Input.Day) <= 31 && (Convert.ToInt32(Input.Month) == 1 || Convert.ToInt32(Input.Month) == 3
                   || Convert.ToInt32(Input.Month) == 5 || Convert.ToInt32(Input.Month) == 7 || Convert.ToInt32(Input.Month) == 8
                   || Convert.ToInt32(Input.Month) == 10 || Convert.ToInt32(Input.Month) == 12))
                {
                    await CreateUserAsync(returnUrl);       // Validation for months January, March, May, July, August, October, December
                }
                else
                {                    
                    Message = "The selected date is invalid";
                    return Page();
                }
            }
                // If we got this far, something failed, redisplay form
                return Page();
        }        

        // Creates the user once all validation is done successfully
        public async Task<IActionResult> CreateUserAsync(string returnUrl = null)
        {
            var user = new tshiloboUser
            {
                UserName = Input.Email, Email = Input.Email, FirstName = Input.FirstName, LastName = Input.LastName,
                GenderId = Convert.ToInt32(Input.GenderId), DisplayName = Input.FirstName + " " + Input.LastName,
                DateOfBirth = new DateTime(Convert.ToInt32(Input.Year), Convert.ToInt32(Input.Month), Convert.ToInt32(Input.Day), 0, 0, 0)
            };

            var result = await _userManager.CreateAsync(user, Input.Password);

            if (result.Succeeded)
            {
                _logger.LogInformation("User Created A New Account With Password.");

                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { userId = user.Id, code = code },
                    protocol: Request.Scheme);

                await _emailSender.SendEmailAsync(Input.Email, "Confirm Your Email",
                    $"Please Confirm Your Account By <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Clicking Here</a>.");

                await _signInManager.SignInAsync(user, isPersistent: false);

                return LocalRedirect(returnUrl);
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            // I don't even know what LocalRedirect(returnUrl); redirects to. :(           
            return LocalRedirect(returnUrl);
        }
    }
}
