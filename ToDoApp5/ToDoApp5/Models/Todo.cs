using System;
using System.Collections.Generic;

namespace ToDoApp5.Models;

public partial class Todo
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Deadline { get; set; }

    public string Title { get; set; }
}
