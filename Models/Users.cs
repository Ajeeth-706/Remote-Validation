using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Remote_Validation.Models
{
    [MetadataType(typeof(UsersMetaData))]
    public partial class User
    {
    }

    public class UsersMetaData
    {
        public int Id { get; set; }
        [DisplayAttribute(Name ="Full Name")]
        public string FullName { get; set; }
        [Remote("IsUserNameValidation","Home",ErrorMessage ="UserName is Already exist")]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}