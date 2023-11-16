

using WebSanadApplication.Interface;

namespace WebSanadApplication.Reposaitry
{
    public class UniteOfWork : IUniteOfWork
    {
       
      
        public IEntrySettingRepo entrySettingRepo { get; set ; }
      
        public UniteOfWork(IEntrySettingRepo entrySettingRepo)
        {
            
           
            this.entrySettingRepo = entrySettingRepo;
            
        }
    }
    
}
