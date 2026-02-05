using System;
using System.Collections.Generic;
using System.Text;

namespace ShowTrack.Entity
{
    public class ApiSearchResponse
    {
        public List<MovieDescription> description { get; set; }
        public int status { get; set; }
    }
}
