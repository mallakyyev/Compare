using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Enums
{
    public enum OrderStatus
    {
        New = 0, //Новый
        InProcessing = 1, //В обработке
        Submitted = 2, //Отправелен
        Delivered = 3, //Доставлен
        Canceled = 4 //Отменен
    }
}
