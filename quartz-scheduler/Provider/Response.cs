using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;



namespace ScheduleJob.WEB.Provider
{
    public class Response
    {
        public Response(object Items = null, HttpStatusCode StatusCode = HttpStatusCode.OK, string StatusText = "", double TotalItems = 0)
        {
            items = Items;
            status = StatusCode;
            statusText = StatusText;
            totalItems = TotalItems;

        }
        public object items { set; get; }
        public HttpStatusCode status { set; get; }
        public string statusText { get; set; }
        public double totalItems { get; set; }

    }


}