using Microsoft.AspNetCore.Mvc;
using ReadWrite.Core.Interfaces;
using ReadWrite.Models;

namespace ReadWriteTo_FileAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadWriteTextController : ControllerBase
    {
        private readonly IWriteToTextFile _writeToTextFile;

        public ReadWriteTextController(IWriteToTextFile writeToTextFile)
        {
            _writeToTextFile = writeToTextFile;
        }
        [HttpPost("Text")]
        public IActionResult AddEmployee(string[] Text)
        {
            string message = _writeToTextFile.WriteToText(Text);
            if(message == null)
            {
                return BadRequest();
            }
            return Ok(message);
        }
        [HttpGet("Get_Text")]
        public IActionResult GetText()
        {
            string message = _writeToTextFile.ReadTextFile();
            if (message == null)
            {
                return BadRequest();
            }
            return Ok(message);
        }
        [HttpDelete("Delete-File")]
        public IActionResult DeleteFile()
        {
            string message = _writeToTextFile.DeleteFromFile();
            if(message == null)
            {
                return NotFound("Error");
            }
            return Ok(message);
        }
    }
}
