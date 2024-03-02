using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace projectStreaming.Data
{
    /// <summary>
    /// Ovo mi je datoteka gdje ću navoditi datasetove i načine spajanja u bazi
    /// </summary>
    public class StreamingContext : DbContext
    {
        /// <summary>
        /// Kostruktor
        /// </summary>
        /// <param name="options"></param>
        public StreamingContext(DbContextOptions<StreamingContext> options)
            : base(options)
        {

        }
        /// <summary>
        /// Smjerovi u bazi
        /// </summary>
        public DbSet<Smjer> Smjerovi { get; set; }
    }
}