using Application.Common.Interface;
using Domain.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppSettingsRepository : Repository<AppSetting> , IAppSettingsRepository 
    {
        public AppSettingsRepository(ApplicationDBContext context) : base(context)
        {
        }
       

        IEnumerable<AppSetting> IAppSettingsRepository.GetAppSettings()
        {
            return GetItems();
        }
    }
}
