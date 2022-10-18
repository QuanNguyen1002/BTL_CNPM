namespace BTL_CNPM.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly BTL_CNPMDbContext _context;

        public InitialHostDbBuilder(BTL_CNPMDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
