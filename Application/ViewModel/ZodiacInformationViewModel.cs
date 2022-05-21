using System;
using System.Collections.Generic;

namespace Application.ViewModel
{
    public class ZodiacInformationViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<ZodiacInformationViewModel> Zodiacs = new();

        public List<ZodiacInformationViewModel> GetZodiacs()
        {
            Zodiacs.Clear();

            Zodiacs.Add(
            new ZodiacInformationViewModel()
            {
                Name = "Aquarius",
                StartDate = new(DateTime.Now.Year, 1, 20),
                EndDate = new(DateTime.Now.Year, 2, 18)
            }
            );
            Zodiacs.Add(new()
            {
                Name = "Pisces",
                StartDate = new(DateTime.Now.Year, 2, 19),
                EndDate = new(DateTime.Now.Year,3,20)
            });
            Zodiacs.Add(new()
            {
                Name = "Aries",
                StartDate = new(DateTime.Now.Year, 3, 21),
                EndDate = new(DateTime.Now.Year, 4, 19)
            });
            Zodiacs.Add(new()
            {
                Name = "Taurus",
                StartDate = new(DateTime.Now.Year, 4, 20),
                EndDate = new(DateTime.Now.Year, 5, 20)
            });
            Zodiacs.Add(new()
            {
                Name = "Gemini",
                StartDate = new(DateTime.Now.Year, 5, 21),
                EndDate = new(DateTime.Now.Year, 6, 20)
            });
            Zodiacs.Add(new()
            {
                Name = "Cancer",
                StartDate = new(DateTime.Now.Year, 6, 21),
                EndDate = new(DateTime.Now.Year, 7, 22)
            });
            Zodiacs.Add(new()
            {
                Name = "Leo",
                StartDate = new(DateTime.Now.Year, 7, 23),
                EndDate = new(DateTime.Now.Year, 8, 22)
            });
            Zodiacs.Add(new()
            {
                Name = "Virgo",
                StartDate = new(DateTime.Now.Year, 8, 23),
                EndDate = new(DateTime.Now.Year, 9, 22)
            });
            Zodiacs.Add(new()
            {
                Name = "Libra",
                StartDate = new(DateTime.Now.Year, 9, 23),
                EndDate = new(DateTime.Now.Year, 10, 22)
            });
            Zodiacs.Add(new()
            {
                Name = "Scorpio",
                StartDate = new(DateTime.Now.Year, 10, 23),
                EndDate = new(DateTime.Now.Year, 11, 21)
            });
            Zodiacs.Add(new()
            {
                Name = "Saggitarius",
                StartDate = new(DateTime.Now.Year, 11, 22),
                EndDate = new(DateTime.Now.Year, 12, 21)
            });
            Zodiacs.Add(new()
            {
                Name = "Capricorn",
                StartDate = new(DateTime.Now.Year, 12, 22),
                EndDate = new(DateTime.Now.Year, 1, 19)
            });

            return Zodiacs;
        }
    }

}
