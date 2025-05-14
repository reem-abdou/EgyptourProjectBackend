using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgyptourProject.DAL.Data.Models;
using EgyptourProject.DAL.Repository;

namespace EgyptourProject.BLL.Manager
{
    public class BookingManager:IBookingManager
    {
        private readonly BookingRepository _bookingRepository;
        private readonly TripRepository _tourRepository;  
        private readonly ClientRepository _clientRepository;  

        public BookingManager(
            BookingRepository bookingRepository,
            TripRepository tourRepository,
            ClientRepository clientRepository)
        {
            _bookingRepository = bookingRepository;
            _tourRepository = tourRepository;
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync(int clientId)
        {
            var bookings = await _bookingRepository.GetAllAsync();  
            return bookings.Where(b => b.ClientId == clientId).ToList();
        }

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetByIdAsync(id);
        }

        public async Task CreateBookingAsync(int clientId, int tourId, int totalAmount)
        {
            var client = await _clientRepository.GetByIdAsync(clientId);
            if (client == null)
            {
                throw new Exception("Client not found.");
            }

            var tour = await _tourRepository.GetByIdAsync(tourId);
            if (tour == null)
            {
                throw new Exception("Tour not found.");
            }

            if (tour.Date < DateTime.Now)
            {
                throw new Exception("Tour date must be in the future.");
            }

            var booking = new Booking
            {
                ClientId = clientId,
                TripId = tourId,
                Guests = totalAmount
            };
            await _bookingRepository.AddAsync(booking);
        }

        public async Task CancelBookingAsync(int bookingId)
        {
            var booking = await _bookingRepository.GetByIdAsync(bookingId);
            if (booking == null)
            {
                throw new Exception("Booking not found.");
            }

            await _bookingRepository.DeleteAsync(bookingId);
        }
    }
}
