﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaPartyKata
{
    public interface ITeaPartyKata
    {
        /// <summary>
        /// Welcome a guest
        /// </summary>
        /// <param name="lastName">the last name of the guest</param>
        /// <param name="isWoman"><c>true</c> if the guest is female</param>
        /// <param name="isSir"><c>true</c> if the guest was knighted by the queen</param>
        /// <returns>issues welcome text to the guest</returns>
        string Welcome(string lastName, bool isWoman, bool isSir);
    }
}
