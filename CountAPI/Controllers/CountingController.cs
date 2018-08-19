using CountAPI.Modles;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace CountAPI.Controllers
{
    [Route("api/Count")]
    [ApiController]
    public class CountController : ControllerBase
    {


        [HttpPost]
        public JObject Count(CountedText item)
        {
            string[] jsonResults = new string[2];

            //original text that was GOT
            jsonResults[0] = item.Text;

            //Count the characters
            jsonResults[1] = item.Text.Length.ToString();

            //Split the text into parse-able bits, original text is first, calculated count of text is second
            string jsonString = "{" +
                "OriginalText: '" + jsonResults[0] + "'," +
                "Count: '" + jsonResults[1] + "'" +
                "}";

            JObject j = JObject.Parse(jsonString);
            return j;
        }

    }
}