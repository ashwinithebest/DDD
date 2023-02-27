using Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interface
{
    public interface IAppSettingsRepository : IRepository<AppSetting>
    {
        IEnumerable<AppSetting> GetAppSettings();
    }
}
