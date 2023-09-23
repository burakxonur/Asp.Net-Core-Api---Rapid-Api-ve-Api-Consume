﻿using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookingDal:IGenericDal<Booking>
    {
        void BookinStatusChangeApproved(Booking booking);
        void BookinStatusChangeApproved2(int id);
        int GetBookingCount();
        List<Booking> Last6Bookings();
    }
}
