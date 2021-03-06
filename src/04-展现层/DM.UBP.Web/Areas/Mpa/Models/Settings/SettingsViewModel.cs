﻿using Abp.Application.Services.Dto;
using DM.UBP.Application.Dto.SysManage.Configuration.Tenants;
using System.Collections.Generic;

namespace DM.UBP.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}