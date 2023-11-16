

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebSanadApplication.Models.ViewModel;

namespace WebSanadApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
/* public SettingController(IUniteOfWork uniteOfWork, IMapper mapper, MohamedContext context, IConfiguration config)
        {


            UniteOfWork = uniteOfWork;
            Mapper = mapper;
            Context = context;
            CandaSql = config.GetConnectionString("DefaultConnection");
        }



        private readonly string CandaSql;

        public IUniteOfWork UniteOfWork { get; }
        public IMapper Mapper { get; }
        public MohamedContext Context { get; }

/*[HttpGet()]
        public async Task<IActionResult> Basics()
        {

            var MappedResult = Mapper.Map<IEnumerable<GET_ENTRY_SETTINGResult>, IEnumerable<Get_Entry_SettingViewModel>>(UniteOfWork.entrySettingRepo.GetResultWithEntrySetting());

            return View(MappedResult);
        }

/*[HttpGet("ENTRY_SETTING_ID,LANG")]
        public async Task<IActionResult> Basics(short? ENTRY_SETTING_ID, string LANG)
        {

            var EntrySettingResult = await Context.GET_ENTRY_SETTINGResultasync.FromSqlRaw($"EXEC GET_ENTRY_SETTING {ENTRY_SETTING_ID = 1},{LANG = "A"}").ToListAsync();

            return View(EntrySettingResult[0]);
        }
        public async Task<IActionResult> Basics(string LANG)
        {
            var CurencyResult=await Context.SELECT_ALL_CURRENCIESResultasync.FromSqlRaw($"EXEC SELECT_ALL_CURRENCIES {LANG="a"}").ToListAsync();
            return View(CurencyResult);
        }

        public async Task<IActionResult> Basics(int ENTRY_SETTING_ID ,int SHIFT_NUMBER )
        {
            var Get_New_Entry = await Context.Get_New_Entry_NumberResultasync.FromSqlRaw($"EXEC Get_New_Entry_Number {ENTRY_SETTING_ID=1} {SHIFT_NUMBER = 1}").ToListAsync();
            return View(Get_New_Entry);
        }

        public async Task<IActionResult> Search(string SEARCH_CODE)
        {
            var GetSearchResult = await Context.SELECT_SEARCH_ACCOUNTSResult.FromSqlRaw($"EXEC SEARCH_ACCOUNTS {SEARCH_CODE = "ali"}").ToListAsync();

            return View(GetSearchResult);
        }
        /*
        public async Task<IActionResult> Basics(short? ENTRY_SETTING_ID, string LANG, string SEARCH_CODE)
        {
            var EntrySettingResult = await Context.GET_ENTRY_SETTINGResultasync.FromSqlRaw($"EXEC GET_ENTRY_SETTING {ENTRY_SETTING_ID = 1},{LANG = "A"}").ToListAsync();

            var GetSearchResult = await Context.SELECT_SEARCH_ACCOUNTSResult.FromSqlRaw($"EXEC SEARCH_ACCOUNTS {SEARCH_CODE = "ali"}").ToListAsync();
            allViewModel allviewmodel=new allViewModel();

            return View(GetSearchResult);
        }*/