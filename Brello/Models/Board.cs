using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public string Title { get; set; }

        //changed from ICollection to List
        public virtual List<BrelloList> Lists { get; set; }
        public virtual ICollection<ApplicationUser> Followers { get; set; }

        public Board()
        {
            Lists = new List<BrelloList>();
            Followers = new List<ApplicationUser>();
        }
    }
}