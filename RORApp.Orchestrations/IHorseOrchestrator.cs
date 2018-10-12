using RORApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using ROR.Shared.Models;

namespace RORApp.Orchestrations
{
    public interface IHorseOrchestrator
    {
        Task<Model.HorseDetails> GetHorses(string hName);
        Task<HorseStatus> GetHorseStatus(string hName);

        Task<List<NamedUserHorse>> GetNamedHorses(int id);

        Task<List<UnnamedUserHorse>> GetUnnamedHorses(int id);

        Task<List<NamedUserHorse>> GetIncativeHorses(int id);

        //Task<string> getConnection();
        string getConnection();

    }
}