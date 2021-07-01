using Compare.BLL.DTOs.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare.BLL.Services.Language
{
    public interface ILanguageService
    {
        IEnumerable<LanguageDTO> GetAllLanguage();
        
        IEnumerable<LanguageDTO> GetAllPublishLanguage();

        Task RemoveLanguageAsync(int id);
    }
}
