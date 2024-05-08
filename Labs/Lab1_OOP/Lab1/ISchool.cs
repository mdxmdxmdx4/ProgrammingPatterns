using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public delegate void SomeEvent();
    public interface ISchool
    {
        public bool isWorking { get; set; }
        public void ShowPupils();
        public event SomeEvent SchoolEvent;
        public string this[int indexer] { get;}

    }
}
