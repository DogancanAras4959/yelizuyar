using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yelizuyar.CORE.EmailConfig;
using yelizuyar.ENGINES.Interface;
using yelizuyar.Models;
using yelizuyar.Models.EmailModel;

namespace yelizuyar.Controllers
{
    public class homeController : Controller
    {
        private readonly IEmailSender _emailSender;
        public homeController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public IActionResult homepage()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Yoga In Town";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yeliz Saraçoğlu Uyar | Yoga In Town";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("booknow")]
        public IActionResult booknow()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Book Now";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("mystory")]
        public IActionResult mystory()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | My Story";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("privateyogalessons")]
        public IActionResult privateyogalessons()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Private Yoga Lessons";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("mindfulnessprogrammeforbusiness")]
        public IActionResult mindfulnessprogrammeforbusiness()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Mindfulness Programme For Business";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("corporatewellbeingworkshops")]
        public IActionResult corporatewellbeingworkshops()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Corporatewell Beign Workshops";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }


        [Route("retreats")]
        public IActionResult retreats()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Retreats";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("teachertrainingcourse")]
        public IActionResult teachertrainingcourse()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Teacher Training Course";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }


        [Route("shop")]
        public IActionResult shop()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Shop";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [Route("contact")]
        public IActionResult contact()
        {
            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Contact";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> sendform(EmailSenderViewModel model)
        {
            try
            {
                string messages = model.content;
                var message = new Message()
                {
                    To = "info@yogaintown.co.uk",
                    Subject = "Book - Yoga In Town",
                    Phone = model.phone,
                    Email = model.email,
                    NameSurname = model.namesurname,
                    Content = $@"<p>{model.namesurname} | {model.city} {model.area} iletişim formunu doldurdu. (Bu form https://yogaintown.co.uk/home/teachertrainingcourse üzerinden gelmiştir.) <p> <hr/> <p>Email Adresi: {model.email}</p> <hr/>  <p>Telefon: {model.phone}</p> <hr/> <p>{messages}</p> <hr/>",
                };

                await _emailSender.SendEmailAsync(message);
                string result = "The application form has been successfully filled! We will contact with you as soon as possible!";

                return RedirectToAction("result", "home", new { result = result, type = 1 });

            }
            catch (Exception ex)
            {
                string result = "The form could not be submitted. But don't worry! Contact our service provider.";
                return RedirectToAction("result", "home", new { result = result, type = 0 });
            }

        }

        [HttpGet]
        [Route("result")]

        public IActionResult result(string result, int type)
        {
            ViewBag.Result = result;
            ViewBag.Type = type;

            #region Meta

            MetaViewModel meta = new MetaViewModel();
            meta.Title = "Yeliz Saraçoğlu Uyar | Result";
            meta.Keywords = "Yoga, England, Mindful, Condition, Sport, Life";
            meta.Description = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness.";
            meta.Image = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.ogDescription = "I am a Yoga Teacher teaching for more than 10 years in various studios.My passion is to offer my clients holistic tools such as yoga, editation, mindfulness..";
            meta.ogTitle = "Yoga In Town | Yeliz Uyar";
            meta.ogImage = "http://uploads.yogaintown.co.uk/site/logo.png";
            meta.Url = "http://yogaintown.co.uk";
            ViewBag.Meta = meta;

            #endregion        

            return View();
        }

    }
}
