namespace RoleStore{
    public class Rolestore{
        private AppDbContext _appDbContext;

        public RoleStore(AppDbContext appDbContext)
        {
            _appDbContext=appDbContext;
            
        }
    }
}