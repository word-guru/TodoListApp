﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private bool _isDone;
        private string _text;

        public bool IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }


    }
}
