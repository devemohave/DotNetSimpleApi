using System;
using SimpleApi.Controllers;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApi.Test
{
    public class WeatherForecastApiTests   
    {
        [Fact]
        public void ShouldDownloadForecastSuccessfullyFromApi()
        {
            // arrange
            IEnumerable<WeatherForecast> forecasts = null;            
            WeatherForecastController controller = new WeatherForecastController();
            int expected = 5;

            // act
           forecasts = controller.Get();
            

            // arrange
            Assert.NotNull(forecasts);
            Assert.Equal(expected, forecasts.Count());
                
        }
    }
}
