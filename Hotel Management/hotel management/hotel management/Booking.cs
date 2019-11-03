using System;
using System.Collections.Generic;
using System.Text;

namespace hotel_management
{
    enum PaymentStatus{
        PAID,
        UNPAID,
    }
    class Booking
    {
        Guid bookingID;
        Room room;
        PaymentStatus paymentStatus;
        Guest guestId;
        DateTime bookingTime;
        DateTime dateFrom;
        DateTime dateTo;

        public Booking(Room room,PaymentStatus paymnetStatus,Guest guest,DateTime from,DateTime to )
        {
            this.bookingID = Guid.NewGuid();
            this.room = room;


        }

    }
}
