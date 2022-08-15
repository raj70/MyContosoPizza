/** 
* Copyright 2022 rajen shrestha
* All right are reserved. Reproduction or transmission in whole or in
* part, in any form or by any means, electronic, mechanical or otherwise
* is published without the prior written consent of the copyright owner.
* 
* [4.0.30319.42000]
* Author: RajenShrestha 
* Machine: DESKTOP-S9S36R1
* Time: 8/14/2022 7:33:49 PM
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContosoPizza.Core.Domain
{
    public class Pizza
    {
        public Pizza()
        {

        }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}

