using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Compare.DAL.Models.Enums
{
    public enum InformationStatus
    {
        About = 1, //О нас
        Advertising = 2, //Реклама
        PrivacyPolicy = 3, //Политика конфиденциальности
        Vacancies = 4, //Вакансии
        Info = 5, //Информация
        FooterInfo = 6 //Короткая информация внизу
    }
}
