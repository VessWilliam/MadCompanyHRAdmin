using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadCompanyHR_API
{
    public interface IMadEmployee
    {
        int Id { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }
        decimal Salary { get; set; }
    }
}
