using System;
using System.Collections.Generic;
using System.Text;

namespace HRAdministrationAPI
{
    public interface IEmployee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }
}
