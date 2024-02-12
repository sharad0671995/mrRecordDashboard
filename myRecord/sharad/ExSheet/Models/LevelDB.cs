using Microsoft.EntityFrameworkCore;

namespace ExSheet.Models
{
    public class LevelDB :DbContext
    {  

        

        public LevelDB (DbContextOptions<LevelDB> options) : base(options)
        {

        }
        public DbSet<ClientpMaster> Clientpmasterss { get; set; }

        

        public DbSet<Linemaster> lineMasterss { get; set; }
      

        public DbSet<ClientMaster> ClientMasterss { get; set; }

        


    }
}
