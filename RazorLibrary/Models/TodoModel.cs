using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorLibrary.Models;

public class TodoModel
{
    public string TodoItem { get; set; }
    public bool IsComplete { get; set; }
}
