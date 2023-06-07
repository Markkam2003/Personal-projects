using System;
using System.Linq;
using System.Threading.Tasks;
using DuetRecordingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DuetRecordingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecordingsController : ControllerBase
    {
        private readonly DuetRecordingContext _context;

        public RecordingsController(DuetRecordingContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecording(Recording recording)
        {
            if (recording.UserId == recording.GuestId)
            {
                return BadRequest("User and guest cannot be the same.");
            }

            if (!_context.Users.Any(u => u.Id == recording.UserId))
            {
                return BadRequest($"User with id {recording.UserId} not found.");
            }

            if (!_context.Users.Any(u => u.Id == recording.GuestId))
            {
                return BadRequest($"User with id {recording.GuestId} not found.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            recording.ExpirationDate = DateTime.Now.AddDays(30);

            _context.Recordings.Add(recording);

