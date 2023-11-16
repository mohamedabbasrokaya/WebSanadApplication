using System.ComponentModel.DataAnnotations.Schema;

namespace WebSanadApplication.Models.ViewModel
{
    public class allViewModel
    {

        public short ENTRY_SETTING_ID { get; set; }
        public string ENTRY_SETTING_AR_NAME { get; set; }
        public string ENTRY_SETTING_EN_NAME { get; set; }
        public string ENTRY_SETTING_AR_ABRV { get; set; }
        public string ENTRY_SETTING_EN_ABRV { get; set; }
        [Column("ACCOUNT CODE")]
        public string ACCOUNTCODE { get; set; }
        [Column("ACCOUNT NAME")]
        public string ACCOUNTNAME { get; set; }
        public string CURRENCY_NAME { get; set; }
        [Column("CURRENCY CODE")]
        public string CURRENCYCODE { get; set; }
        public bool AUTO_POSTING { get; set; }
        [Column("ENTRY TYPE NAME")]
        public string ENTRYTYPENAME { get; set; }
        public bool ACCEPT_DIST_ACC { get; set; }
        public byte CREDIT_INDEX { get; set; }
        public short CREDIT_WIDTH { get; set; }
        public int CREDIT_COLOR { get; set; }
        public byte DEBIT_INDEX { get; set; }
        public short DEBIT_WIDTH { get; set; }
        public int DEBIT_COLOR { get; set; }
        public byte ACC_INDEX { get; set; }
        public short ACC_WIDTH { get; set; }
        public int ACC_COLOR { get; set; }
        public byte COST_CENTER_INDEX { get; set; }
        public short COST_CENTER_WIDTH { get; set; }
        public int COST_CENTER_COLOR { get; set; }
        public byte REMARKS_INDEX { get; set; }
        public short REMARKS_WIDTH { get; set; }
        public int REMARKS_COLOR { get; set; }
        public int? ENTRY_ACC_ID { get; set; }
        public bool PRINT_AS_RESET { get; set; }
        public bool SHOW_THE_LAST_BALANCE { get; set; }
        public byte NUMBEROFCOPIES { get; set; }
        List<SEARCH_ACCOUNTSResult> SEARCH_ACCOUNT = new List<SEARCH_ACCOUNTSResult>();

    }
}
