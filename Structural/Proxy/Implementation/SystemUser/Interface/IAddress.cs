using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Implementation.SystemUser.Interface
{
    public interface IAddress
    {
        public string Street { get; set; }

        public int Number { get; set; }
    }
}