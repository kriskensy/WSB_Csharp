using System;
using System.Collections.Generic;

namespace Lab_06_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketChecker ticketChecker = new TicketChecker();

            Ticket ticket1 = new Ticket("T123");
            Ticket ticket2 = new Ticket("T456");
            Ticket ticket3 = new Ticket("T789");
            Ticket ticket4 = new Ticket("T000");
            Ticket ticket5 = new Ticket("T111");
            Ticket ticket6 = new Ticket("T222");

            ticketChecker.AddTicket(ticket1);
            ticketChecker.AddTicket(ticket2);
            ticketChecker.AddTicket(ticket3);

            ticketChecker.CheckTicket(ticket1);
            ticketChecker.CheckTicket(ticket5);

            ticketChecker.AddTicket(ticket1);

            ticketChecker.ClearTickets();
            ticketChecker.CheckTicket(ticket1);
        }
    }

    public class Ticket
    {
        private string TicketCode { get; }

        public Ticket(string ticketCode)
        {
            TicketCode = ticketCode;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Ticket ticket = (Ticket)obj;
            return TicketCode == ticket.TicketCode;
        }

        public override int GetHashCode()
        {
            return TicketCode.GetHashCode();
        }

        public override string ToString()
        {
            return TicketCode;
        }
    }

    public class TicketChecker
    {
        private HashSet<Ticket> tickets = new HashSet<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public bool CheckTicket(Ticket ticketToCheck)
        {
            if (tickets.Contains(ticketToCheck))
            {
                Console.WriteLine($"Ticket {ticketToCheck} invalid.");
                return false;
            }
            else
            {
                Console.WriteLine($"Ticket {ticketToCheck} is valid.");
                return true;
            }
        }

        public void ClearTickets()
        {
            tickets.Clear();
            Console.WriteLine("Tickets cleared.");
        }
    }
}