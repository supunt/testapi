// <copyright file="MyHorseController.cs" company="Racing Australia (C) 2018">
// Copyright (c) Racing Australia (C) 2018. All rights reserved.
// </copyright>

namespace RORApp.Controllers
{
    using ROR.Shared.Models;
    using RORApp.Model;
    using RORApp.Orchestrations;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    /// <summary>
    /// My Horse Controller
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class MyNamedHorsesController : ApiController
    {

        private IHorseOrchestrator _horseOrchestrator;


        public MyNamedHorsesController(IHorseOrchestrator horseOrchestrator)
        {
            _horseOrchestrator = horseOrchestrator;
        }

        /// <summary>
        /// GET api/values
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// List of objects
        /// </returns>
        [Route("api/MyNamedHorses/{id}")]
        [HttpGet]
        public async Task<List<NamedUserHorse>> Get(int id)
        {
            var result = await _horseOrchestrator.GetNamedHorses(id);
            return result;
        }
    }
}