﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using waEntitys;

namespace waRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            List <CategoriaEmpleado> lstcategoriaEmpleados = new List<CategoriaEmpleado>();
            lstcategoriaEmpleados = waServices.CategoriaEmpleadoService.GetAllCategoriaEmpleado();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] CategoriaEmpleado empleado)
        {
            try
            {
                waServices.CategoriaEmpleadoService.AltaCategoriaEmpleado(empleado);
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            try
            {
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
