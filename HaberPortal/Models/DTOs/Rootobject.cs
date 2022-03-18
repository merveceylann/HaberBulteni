using System.Collections.Generic;

namespace HaberPortal.Models.DTOs
{
        public class Rootobject
        {
            public int errorCode { get; set; }
            public string errorMessage { get; set; }
            public List<MainData> data { get; set; }
        }
}