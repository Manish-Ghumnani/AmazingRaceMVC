﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using AmazingRaceMVC.Models;
using System.Threading.Tasks;

namespace AmazingRaceMVC
{
    
    public class BoardHub : Hub
    {
        public readonly BoardUpdate _boardUpdate;



        public BoardHub() : this(BoardUpdate.Instance) { }

        public BoardHub(BoardUpdate boardUpdate)
        {
            _boardUpdate = boardUpdate;

        }

        public IEnumerable<Board> GetAllRows()
        {
            return (IEnumerable<Board>)_boardUpdate.GetAllRows();
        }

    }
}
