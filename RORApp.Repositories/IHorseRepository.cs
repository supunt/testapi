using ROR.Shared.Models;
using RORApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RORApp.Repositories
{
    public interface IHorseRepository
    {
        //Task<string> GetConnection();
        string GetConnection();
        Task<Model.HorseDetails> GetHorses(string hName);
        Task<HorseStatus> GetHorseStatus(string hName);

        Task<List<NamedUserHorse>> GetNamedHorses(int id);

        Task<List<UnnamedUserHorse>> GetUnnamedHorses(int id);

        Task<List<NamedUserHorse>> GetIncativeHorses(int id);

    }
}
