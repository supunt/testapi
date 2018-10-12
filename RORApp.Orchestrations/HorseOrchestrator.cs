using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using ROR.Shared.Models;
using RORApp.Model;
using RORApp.Repositories;

namespace RORApp.Orchestrations
{

    public class HorseOrchestrator : IHorseOrchestrator
    {
        private readonly IHorseRepository _horseRepository;
        public HorseOrchestrator(IHorseRepository horseRepository)
        {
            _horseRepository = horseRepository;// new HorseRepository();
        }

        //public async Task<string> getConnection()
        //{
        //    return await _horseRepository.GetConnection();
        //}
        public string getConnection()
        {
            return  _horseRepository.GetConnection();
        }

        public async Task<Model.HorseDetails> GetHorses(string hName)
        {
            return await _horseRepository.GetHorses(hName);
        }

        public async Task<HorseStatus> GetHorseStatus(string hName)
        {
            return await _horseRepository.GetHorseStatus(hName);
        }

        public async Task<List<NamedUserHorse>> GetNamedHorses(int id)
        {
            return await _horseRepository.GetNamedHorses(id);
        }

        public async Task<List<UnnamedUserHorse>> GetUnnamedHorses(int id)
        {
            return await _horseRepository.GetUnnamedHorses(id);
        }

        public async Task<List<NamedUserHorse>> GetIncativeHorses(int id)
        {
            return await _horseRepository.GetIncativeHorses(id);
        }
    }
}