using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Serialization;
using ROR.Shared.Models;
using RORApp.Model;


namespace RORApp.Repositories
{
    public class HorseRepository : IHorseRepository
    {
        private static Uri baseUrl = new Uri(ConfigurationManager.AppSettings["Uri"]);

        public HorseRepository()
        {

        }
        //public async Task<string> GetConnection()
        //{
        //    //return "ok";
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://10.1.0.163:9001/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // HTTP GET
        //        HttpResponseMessage response = await client.GetAsync("TestDataFeed/TestConnection");
        //        string data = await response.Content.ReadAsStringAsync();
        //        return data;
        //    }
        //}
        public string GetConnection()
        {
            return "ok";
            //using (var client = new HttpClient())
            //{
            //    client.BaseAddress = new Uri("http://10.1.0.163:9001/");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    // HTTP GET
            //    HttpResponseMessage response = await client.GetAsync("TestDataFeed/TestConnection");
            //    string data = await response.Content.ReadAsStringAsync();
            //    return data;
            //}
        }
        public async Task<Model.HorseDetails> GetHorses(string hName)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://10.1.0.163:9001/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync("TestDataFeed/TestConnection");
                string data = await response.Content.ReadAsStringAsync();
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                //deserialize to your class
                var products = JSserializer.Deserialize<Model.HorseDetails>(data);
                return await response.Content.ReadAsAsync<Model.HorseDetails>();

               // if (response.IsSuccessStatusCode)
                //{
                    
                //    //var cnt = thisBlogList.Count();
                   
                //}

            }
            //var path = string.Format(_options.GetMembershipAdditionalDetailsPath, membershipRouteRequest.MembershipId);

            //using (var response = await _httpClient.GetAsync(path).ConfigureAwait(false))
            //{
            //    return await response.ReadAsAsync<MembershipAdditionalInfo>(ErrorMessageMapping).ConfigureAwait(false);
            //}
        }



        public async Task<HorseStatus> GetHorseStatus(string hName)
        {
            using (var client = new HttpClient())
            {
                //enable for local enviroment
               //client.BaseAddress = new Uri("http://10.1.0.203:9001/");
                
                //enable for azure
                client.BaseAddress = new Uri("http://116.240.194.179:9001/");
                

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync(string.Format("Horse/IsHorseNameAvialable?horseName={0}", hName));
                //var response = await client.GetAsync(string.format("api/products/id={0}&type={1}", param.Id.Value, param.Id.Type));
                string data = await response.Content.ReadAsStringAsync();
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                //deserialize to your class
                //var products = JSserializer.Deserialize<HorseStatus>(data);
                return await response.Content.ReadAsAsync<HorseStatus>();

                // if (response.IsSuccessStatusCode)
                //{

                //    //var cnt = thisBlogList.Count();

                //}

            }
            //var path = string.Format(_options.GetMembershipAdditionalDetailsPath, membershipRouteRequest.MembershipId);

            //using (var response = await _httpClient.GetAsync(path).ConfigureAwait(false))
            //{
            //    return await response.ReadAsAsync<MembershipAdditionalInfo>(ErrorMessageMapping).ConfigureAwait(false);
            //}
        }

        public async Task<List<NamedUserHorse>> GetNamedHorses(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = baseUrl;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync($"mynamedhorses/{id}");
                string data = await response.Content.ReadAsStringAsync();
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                //deserialize to your class
                var products = JSserializer.Deserialize<List<NamedUserHorse>>(data);
                return await response.Content.ReadAsAsync<List<NamedUserHorse>>();
            }
        }

        public async Task<List<UnnamedUserHorse>> GetUnnamedHorses(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = baseUrl;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync($"myunnamedhorses/{id}");
                string data = await response.Content.ReadAsStringAsync();
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                //deserialize to your class
                var products = JSserializer.Deserialize<List<UnnamedUserHorse>>(data);
                return await response.Content.ReadAsAsync<List<UnnamedUserHorse>>();
            }
        }

        public async Task<List<NamedUserHorse>> GetIncativeHorses(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = baseUrl;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // HTTP GET
                HttpResponseMessage response = await client.GetAsync($"myinactivehorses/{id}");
                string data = await response.Content.ReadAsStringAsync();
                JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                //deserialize to your class
                var products = JSserializer.Deserialize<List<NamedUserHorse>>(data);
                return await response.Content.ReadAsAsync<List<NamedUserHorse>>();
            }
        }
    }
}