using System;
using System.Collections.Generic;
using System.Text;

namespace Compare.DAL.Models.Enums
{
    /// <summary>
    /// Enum для проверки добавления, редактирования и удаления
    /// </summary>
    public enum ModelStatus
    {
        Success = 0,
        Error = 1,
        Duplicate = 2
    }
}
