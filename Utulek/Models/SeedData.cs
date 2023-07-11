using Microsoft.EntityFrameworkCore;
using Utulek.Data;

namespace Utulek.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UtulekContext(serviceProvider.GetRequiredService<DbContextOptions<UtulekContext>>()))
            {
                if (context == null || context.Pes == null)
                {
                    throw new ArgumentNullException("Null UtulekContext");
                }
                if (context.Pes.Any())
                {
                    return;
                }
                context.Pes.AddRange(
                    new Pes
                    {
                        Jmeno = "Tadeáš",
                        Plemeno = "Německý ovčák",
                        Pohlavi = Pohlavi.Samec,
                        Vek = 4,
                        Hmotnost = 26,
                        MestoNalezu = "Ostrava",
                        Foto = "",
                        Volny = true
                    },
                    new Pes
                    {
                        Jmeno = "Gaia",
                        Plemeno = "Labrapudl",
                        Pohlavi = Pohlavi.Samice,
                        Vek = 7,
                        Hmotnost = 32.7m,
                        MestoNalezu = "Tábor",
                        Foto = "",
                        Volny = true
                    },
                    new Pes
                    {
                        Jmeno = "Robert",
                        Plemeno = "Afgánský chrt",
                        Pohlavi = Pohlavi.Samec,
                        Vek = 11,
                        Hmotnost = 34,
                        MestoNalezu = "Opava",
                        Foto = "",
                        Volny = true
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
