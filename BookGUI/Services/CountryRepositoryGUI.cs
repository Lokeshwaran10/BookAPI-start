using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace BookGUI.Services
{
    public class CountryRepositoryGUI : ICountryRepositoryGUI
    {
        public IEnumerable<AuthorDto> GetAuthorsFromACountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CountryDto> GetCountries()
        {
            IEnumerable<CountryDto> countries = new List<CountryDto>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60039/api/");

                var reponse = client.GetAsync("countries");
                reponse.Wait();

                var result = reponse.Result;

                if(result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<CountryDto>>();
                    readTask.Wait();

                    countries = readTask.Result;
                }

            }

            return countries;

        }

        public CountryDto GetCountryById(int countryId)
        {
            CountryDto  country = new CountryDto();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:60039/api/");

                var reponse = client.GetAsync($"countries/{countryId}");
                reponse.Wait();

                var result = reponse.Result;

                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<CountryDto>();
                    readTask.Wait();

                    country = readTask.Result;
                }

            }

            return country;
        }

        public CountryDto GetCountryOfAnAuthor(int authorId)
        {
            throw new NotImplementedException();
        }
    }
}
