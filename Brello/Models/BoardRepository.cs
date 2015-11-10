using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brello.Models
{
    public class BoardRepository
    {
        private BoardContext context;
        public BoardRepository(BoardContext _context) {
            context = _context;
        }

        // void or bool or BrelloList
        public bool AddList(Board _board, BrelloList _list)
        {
            return false;
        }

        public List<BrelloList> GetAllLists()
        {
            var query = from l in context.Boards select l;

            /* trying to make the SelectMany example work
            Board[] petOwners =
            {
                new Board {Title = "Higa, Sidney",
                Lists = new List<BrelloList>()},
                new Board {Title = "Higa, ronen",
                Lists = new List<BrelloList>()},
                new Board {Title = "Higa, vernette",
                Lists = new List<BrelloList>()}
            };


            IEnumerable<BrelloList> query1 = petOwners.SelectMany(petOwner => petOwner.Lists); */
            return query.SelectMany(board => board.Lists).ToList();
        }




        // This is an example of overloading a method
        public List<BrelloList> GetAllLists(int _board_id)
        {
            var query = from b in context.Boards where b.BoardId == _board_id select b.Lists;
            return query.Single<List<BrelloList>>();
        }

        public Board CreateBoard(string title, ApplicationUser owner)
        {
            Board my_board = new Board { Title = title, Owner = owner};
            context.Boards.Add(my_board);
            context.SaveChanges(); // This saves something to the Database

            return my_board;
        }

        public List<Board> GetAllBoards()
        {
            return context.Boards.ToList();
        }

        public int GetBoardCount()
        {
            var query = from b in context.Boards select b;
            // Same As -> context.Boards.ToList().Count
            
            return query.Count();
        }

        public int GetListCount()
        {
            return GetAllLists().Count;
        }
    }
}