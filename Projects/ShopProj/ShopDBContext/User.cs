﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ShopDBContext
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Password { get; set; }
        public string UserAddress { get; set; }
        public string UserCity { get; set; }
        public string UserState { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
