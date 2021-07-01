using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Configuration
{
    public class ReCaptchaSettings
    {
        public string SiteKey { get; set; }

        public string SecretKey { get; set; }
    }
}
