using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id =1, Name = "Apple Pie", Price = 12.95M, ShortDescription = " Sweet roll", LongDescription = "Icing Carrot cake Jell-o cheesecake. Sweet roll", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", IsPieOfTheWeek = true},
                new Pie {Id = 2, Name = "Blueberry Cheese Cake", Price = 18.95M, ShortDescription = " Sweet roll", LongDescription = "Icing Carrot cake Jell-o cheesecake. Sweet roll", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", IsPieOfTheWeek = false},
                new Pie {Id = 3, Name = "Cheese Cake", Price = 18.95M, ShortDescription = " Sweet roll", LongDescription = "Icing Carrot cake Jell-o cheesecake. Sweet roll", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", IsPieOfTheWeek = false},
                new Pie {Id = 4, Name = "Cherry Pie", Price = 15.95M, ShortDescription = " Sweet roll", LongDescription = "Icing Carrot cake Jell-o cheesecake. Sweet roll", ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", IsPieOfTheWeek = false}
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
