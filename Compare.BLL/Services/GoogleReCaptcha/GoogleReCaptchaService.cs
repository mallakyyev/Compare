using Compare.DAL.Models.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.GoogleReCaptcha
{
    public class GoogleReCaptchaService
    {
        private ReCaptchaSettings _reCaptchaSettings;

        public GoogleReCaptchaService(IOptions<ReCaptchaSettings> reCaptchaSettings)
        {
            _reCaptchaSettings = reCaptchaSettings.Value;
        }

        public virtual async Task<GoogleREspo> VerifyCaptcha(string token)
        {
            GoogleReCaptchaData googleReCaptchaData = new GoogleReCaptchaData
            {
                response = token,
                secret = _reCaptchaSettings.SecretKey
            };

            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret={googleReCaptchaData.secret}&response={googleReCaptchaData.response}");

            var capresp = JsonConvert.DeserializeObject<GoogleREspo>(response);

            return capresp;
        }
    }

    public class GoogleReCaptchaData
    {
        /// <summary>
        /// Token
        /// </summary>
        public string response { get; set; }

        public string secret { get; set; }
    }

    public class GoogleREspo
    {
        public bool success { get; set; }

        public double score { get; set; }

        public string action { get; set; }

        public DateTime challenge_ts { get; set; }

        public string hostname { get; set; }
    }
}
