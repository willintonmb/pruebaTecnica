using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using prueba.WebApi.Models;

namespace prueba.WebApi.Controllers
{
    public class PacientesController : ApiController
    {
        private EntityModel db = new EntityModel();

        // GET: api/Pacientes
        public IQueryable<Paciente> GetPacientes()
        {
            return db.Pacientes;
        }

        // GET: api/Pacientes/5
        [ResponseType(typeof(Paciente))]
        public async Task<IHttpActionResult> GetPaciente(Guid id)
        {
            Paciente paciente = await db.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            return Ok(paciente);
        }

        // PUT: api/Pacientes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPaciente(Guid id, Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != paciente.id)
            {
                return BadRequest();
            }

            db.Entry(paciente).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PacienteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pacientes
        [ResponseType(typeof(Paciente))]
        public async Task<IHttpActionResult> PostPaciente(Paciente paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pacientes.Add(paciente);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PacienteExists(paciente.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = paciente.id }, paciente);
        }

        // DELETE: api/Pacientes/5
        [ResponseType(typeof(Paciente))]
        public async Task<IHttpActionResult> DeletePaciente(Guid id)
        {
            Paciente paciente = await db.Pacientes.FindAsync(id);
            if (paciente == null)
            {
                return NotFound();
            }

            db.Pacientes.Remove(paciente);
            await db.SaveChangesAsync();

            return Ok(paciente);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PacienteExists(Guid id)
        {
            return db.Pacientes.Count(e => e.id == id) > 0;
        }
    }
}