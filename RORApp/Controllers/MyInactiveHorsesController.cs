// <copyright file="MyInactiveHorsesController.cs" company="Racing Australia (C) 2018">
// Copyright (c) Racing Australia (C) 2018. All rights reserved.
// </copyright>

namespace RORApp.Controllers
{
    using ROR.Shared.Models;
    using RORApp.Orchestrations;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;

    /// <summary>
    /// My Horse Controller
    /// </summary>
    /// <seealso cref="System.Web.Http.ApiController" />
    public class MyInactiveHorsesController : ApiController
    {
        private IHorseOrchestrator _horseOrchestrator;

        public MyInactiveHorsesController(IHorseOrchestrator horseOrchestrator)
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
        [Route("api/MyInactiveHorses/{id}")]
        [HttpGet]
        public async Task<List<NamedUserHorse>> Get(int id)
        {
            var result = await _horseOrchestrator.GetIncativeHorses(id);
            return result;
        }
    }
}