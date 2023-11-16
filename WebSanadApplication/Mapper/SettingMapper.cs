using AutoMapper;
using WebSanadApplication.Models;
using WebSanadApplication.Models.ViewModel;

namespace WebSanadApplication.Mapper
{
    public class SettingMapper:Profile
    {
        public SettingMapper()
        {
            CreateMap<GET_ENTRY_SETTINGResult, Get_Entry_SettingViewModel>()
                
                .ReverseMap();
        }
    }
}
