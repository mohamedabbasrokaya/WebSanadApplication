
using Microsoft.EntityFrameworkCore;
using WebSanadApplication.Interface;
using WebSanadApplication.Models;

namespace WebSanadApplication.Reposaitry
{
    public class EntrySettingRepo : GenericReposaitry<GET_ENTRY_SETTINGResult>, IEntrySettingRepo
    {
        public EntrySettingRepo(MohamedContext context) : base(context)
        {
            Context = context;
        }

        public MohamedContext Context { get; }

         public IEnumerable<GET_ENTRY_SETTINGResult> GetResultWithEntrySetting()
        {
          return Context.GET_ENTRY_SETTINGResultasync.ToList();
        }
    

    }

}

