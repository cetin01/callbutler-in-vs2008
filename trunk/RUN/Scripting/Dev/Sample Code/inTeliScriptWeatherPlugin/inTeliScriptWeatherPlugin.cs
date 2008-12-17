using System;
using System.Collections.Generic;
using System.Text;
using WOSI.IVR.IML.Plugins;

namespace inTeliScriptWeatherPlugin
{
    public class inTeliScriptWeatherPlugin : WOSI.IVR.IML.Plugins.ImlActionPlugin
    {
        public override Guid PluginGuid
        {
            get
            {
                return new Guid("D7988E91-674F-43c3-8110-4B264301B2C4");
            }
        }

        public override string PluginName
        {
            get
            {
                return "inTeliScript Weather Plugin";
            }
        }

        public override string PluginDescription
        {
            get
            {
                return "inTeliScript Weather Plugin. Copyright 2007 Telephony2 Corporation.";
            }
        }

        public override void OnExecuteAction(string command, string data)
        {
            try
            {
                net.webservicex.www.WeatherForecast forecast = new global::inTeliScriptWeatherPlugin.net.webservicex.www.WeatherForecast();

                net.webservicex.www.WeatherForecasts forecasts = forecast.GetWeatherByZipCode(InterpreterContext.GetScriptVariable("ZipCode"));

                if (forecasts.Details.Length > 0)
                {
                    InterpreterContext.SetScriptVariable("Location", forecasts.PlaceName + " " + forecasts.StateCode);
                    InterpreterContext.SetScriptVariable("MaxTempF", forecasts.Details[0].MaxTemperatureF);
                    InterpreterContext.SetScriptVariable("MaxTempC", forecasts.Details[0].MaxTemperatureC);
                    InterpreterContext.SetScriptVariable("MinTempF", forecasts.Details[0].MinTemperatureF);
                    InterpreterContext.SetScriptVariable("MinTempC", forecasts.Details[0].MinTemperatureC);

                    return;
                }
            }
            catch
            {
            }
            
            InterpreterContext.RaiseExternalEvent("WeatherNotFound");
        }
    }
}
