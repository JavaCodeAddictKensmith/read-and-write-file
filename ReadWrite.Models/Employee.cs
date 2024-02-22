using System;
using System.Collections.Generic;
using System.Text;

namespace ReadWrite.Models
{
    public class Employee
    {
        string Name { get; set; }  
        string Email { get; set; } 
        string DateOfBirth { get; set; } = string.Empty;
        string DateOfFirstAppointment { get; set; } = string.Empty;
        /*public override string ToString()
        {
            return Name + " " + Email + " " + DateOfBirth + " " + DateOfFirstAppointment;
        }*/
    }
}
