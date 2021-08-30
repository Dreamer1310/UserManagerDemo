using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace UsersViewer.Repository.DTO
{
    public class UserWriteDto
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Description { get; set; }
        public Int64 PositionID { get; set; }
        public Byte[] Image { get; set; }
    }
}