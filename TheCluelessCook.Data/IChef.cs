using System;
using System.Collections.Generic;
using System.Text;
using TheCluelessCook.Data.Models;

namespace TheCluelessCook.Data
{
    public interface IChef
    {
        Chef GetbyId(int Id);
    }
}
