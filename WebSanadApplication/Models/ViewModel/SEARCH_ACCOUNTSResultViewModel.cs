using System.ComponentModel.DataAnnotations;

namespace WebSanadApplication.Models.ViewModel
{
    public class SEARCH_ACCOUNTSResultViewModel
    {
        public int ACC_ID { get; set; }
        public string ACC_CODE { get; set; }=null!;
        [Required(ErrorMessage = "Name Is Requird")]

        public string ACC_AR_NAME { get; set; } = null!;
        public string ACC_EN_NAME { get; set; } = null!;
        public byte ACC_TYPE_ID { get; set; }
        public double? ACC_MAX_DEBIT { get; set; }
        public bool? ACC_MUST_COST_CENTER { get; set; }
        public Get_Entry_SettingViewModel? getEntrySettingView { get; set; }
    }
}
