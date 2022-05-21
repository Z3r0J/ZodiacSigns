using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ZodiacService
    {
        ZodiacInformationViewModel zodiac = new();
        public ResultViewModel GetResult(InformationViewModel vm) {
            var zodiaco = zodiac.GetZodiacs().Where(x => (vm.BirthDate.Month== x.StartDate.Month && vm.BirthDate.Day>=x.StartDate.Day) || (vm.BirthDate.Month==x.EndDate.Month&&vm.BirthDate.Day<=x.EndDate.Day)).Select(x => x.Name).FirstOrDefault().ToString();

            ResultViewModel result = new()
            {
                Name = vm.Name,
                ZodiacSign = zodiaco,
                BirthDay = vm.BirthDate
            };

            return result;
        }
    }
}
