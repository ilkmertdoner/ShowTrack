using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Microsoft.Identity.Client;
using ShowTrack.Entity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ShowTrack.Business
{
    public class MovieApiService
    {
        private readonly HttpClient _httpClient;

        public MovieApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<MovieDescription>> SearchMediaAsync(string query)
        {
            try
            {
                string url = $"https://imdb.iamidiotareyoutoo.com/search?q={query}";

                var response = await _httpClient.GetStringAsync(url);
                var result = JsonSerializer.Deserialize<ApiSearchResponse>(response);

                return result?.description ?? new List<MovieDescription>();

            }
            catch (Exception)
            {
                return new List<MovieDescription>();
            }
        }

        public async Task<MovieDescription> GetMovieByIdAsync(string id)
        {
            try
            {
                string url = $"https://imdb.iamidiotareyoutoo.com/search?q={id}";

                var response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    var searchResult = JsonSerializer.Deserialize<ApiSearchResponse>(content);

                    if (searchResult?.description != null && searchResult.description.Count > 0)
                    {
                        return searchResult.description[0];
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("API Hatası: " + ex.Message);
                return null;
            }
        }

        public async Task<List<MovieDescription>> GetTop6ByRankAsync(string query)
        {
            try
            {
                string url = $"https://imdb.iamidiotareyoutoo.com/search?q={query}";
                var response = await _httpClient.GetStringAsync(url);
                var result = JsonSerializer.Deserialize<ApiSearchResponse>(response);

                if (result?.description != null)
                {
                    var top6 = result.description.
                        OrderBy(x => x.rank).
                        Take(6).
                        ToList();

                    return top6;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("API Hatası: " + ex.Message);
                return new List<MovieDescription>();
            }

            return new List<MovieDescription>();
        }
    }
}
