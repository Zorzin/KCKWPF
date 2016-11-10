//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using WPFKCK.Annotations;

namespace WPFKCK.Model1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Activity
    {
        [Key]
        public int idactivities { get; set; }
        public string type { get; set; }
        public float distance { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string note { get; set; }
        public Nullable<int> userid { get; set; }

        public Activity()
        {
            this.idactivities = 0;
            this.type = null;
            this.distance = 0;
            this.date = DateTime.Today;
            this.note = null;
            this.userid = 0;
        }

        public Activity(string type, float distance, DateTime date, int userid, string note)
        {
            this.type = type;
            this.distance = distance;
            this.date = date;
            this.userid = userid;
            this.note = note;
        }

        public override string ToString()
        {
            return date.Value.ToString("dd-MM-yyyy") + ": " + type + ", " + distance + "km";
        }
    }
}