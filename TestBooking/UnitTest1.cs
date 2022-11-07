using BookingSimulator.BusinessLayers.Models.Hotels;
using BookingSimulator.Das.DasServices;
using BookingSimulator.Das.Interfaces;
using BookingSimulator.PresentationLayers.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;

namespace TestBooking
{
    public class UnitTest1 :
    IClassFixture<WebApplicationFactory<HotelsController>>
    {
        private readonly HttpClient _sut;

        public UnitTest1(
            WebApplicationFactory<HotelsController> factory)
        {
            var setupFactory = factory.WithWebHostBuilder(builder =>
                builder.ConfigureTestServices(services =>
                {
                    var originalServiceDescriptor = services.Single(serviceDescriptor =>
                        serviceDescriptor.ImplementationType == typeof(DbDasHotel));

                    services.AddScoped<IDasHotel, TestDasHotel>();
                }));
            _sut = setupFactory
                .CreateClient();
        }
        [Fact]
        public async void Test1()
        {
            var request = new PostHotelModel()
            {
                Name = "testHotel"
            };
            string expected = "testHotel";

            var response = await _sut.PostAsJsonAsync("hotels",request);

            var content =  await response.Content.ReadFromJsonAsync<Hotel>();

            Assert.True(response.IsSuccessStatusCode);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, content.Name);
        }
    }

    internal class TestDasHotel : IDasHotel
    {
        public Hotel Add(Hotel hotel)
        {
            return new Hotel();
        }

        public Hotel Update(int id, Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}