using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exceptionless;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BasicsService.Controllers
{
    [Authorize("Permission")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            #region Exceptionless测试
            try
            {
                ExceptionlessClient.Default.SubmitLog("调试Exceptionless.Logging.LogLevel.Debu", Exceptionless.Logging.LogLevel.Debug);
                ExceptionlessClient.Default.SubmitLog("错误Exceptionless.Logging.LogLevel.Error", Exceptionless.Logging.LogLevel.Error);
                ExceptionlessClient.Default.SubmitLog("大错Exceptionless.Logging.LogLevel.fatal", Exceptionless.Logging.LogLevel.Fatal);
                ExceptionlessClient.Default.SubmitLog(" Exceptionless.Logging.LogLevel.Info", Exceptionless.Logging.LogLevel.Info);
                ExceptionlessClient.Default.SubmitLog(" Exceptionless.Logging.LogLevel.Off", Exceptionless.Logging.LogLevel.Off);
                ExceptionlessClient.Default.SubmitLog(" Exceptionless.Logging.LogLevel.Other", Exceptionless.Logging.LogLevel.Other);
                ExceptionlessClient.Default.SubmitLog(" Exceptionless.Logging.LogLevel.Trace", Exceptionless.Logging.LogLevel.Trace);
                ExceptionlessClient.Default.SubmitLog("Exceptionless.Logging.LogLevel.Warn", Exceptionless.Logging.LogLevel.Warn);


                var data = new Exceptionless.Models.DataDictionary();
                data.Add("data1key", "data1value");
                ExceptionlessClient.Default.SubmitEvent(new Exceptionless.Models.Event { Count = 1, Date = DateTime.Now, Data = data, Geo = "geo", Message = "message", ReferenceId = "referencelId", Source = "source", Tags = new Exceptionless.Models.TagSet() { "tags" }, Type = "type", Value = 1.2m });
                ExceptionlessClient.Default.SubmitFeatureUsage("feature");
                ExceptionlessClient.Default.SubmitNotFound("404 not found");
                ExceptionlessClient.Default.SubmitException(new Exception("自定义异常"));

                throw new DivideByZeroException("throw DivideByZeroException的异常：" + DateTime.Now);
            }
            catch (Exception exc)
            {
                exc.ToExceptionless().Submit();
            }
            #endregion


            return new string[] { "BasicsService", $"所在服务器：{Environment.MachineName}  OS:{Environment.OSVersion.VersionString }  时间：{DateTime.Now}" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
