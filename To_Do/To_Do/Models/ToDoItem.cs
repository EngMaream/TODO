using System;
using System.Collections.Generic;
using System.Text;

namespace To_Do.Models
{
    public class ToDoItem: BaseModel
    {
        private string text;
        private bool isDone;
        private string textDataTime;

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public bool IsDone
        {
            get => isDone;
            set => SetProperty(ref isDone, value);
        }

        public string TextDataTime
        {
            get => textDataTime;
            set => SetProperty(ref textDataTime, value);
        }

        public override string ToString() { return Text; }
    }
}
