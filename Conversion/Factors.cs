using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    public static class Factors
    {
        public static readonly double Unit = 1.0;
        public static readonly double Deca = 10.0;
        public static readonly double Hecto = 100.0;
        public static readonly double Kilo = 1000.0;
        public static readonly double Mega = 1e6;
        public static readonly double Giga = 1e9;
        public static readonly double Tera = 1e12;
        public static readonly double Peta = 1e15;
        public static readonly double Exa = 1e18;
        public static readonly double Zetta = 1e21;
        public static readonly double Yotta = 1e24;
        public static readonly double Deci = 0.1;
        public static readonly double Centi = 0.01;
        public static readonly double Milli = 0.001;
        public static readonly double Micro = 1e-6;
        public static readonly double Nano = 1e-9;
        public static readonly double Pico = 1e-12;
        public static readonly double Femto = 1e-15;
        public static readonly double Atto = 1e-18;
        public static readonly double Zepto = 1e-21;
        public static readonly double Yocto = 1e-24;

        public static readonly double Angstrom = 1e-10;
        public static readonly double AstronomicalUnit = 149597870700.0; // exact value ref. https://www.iau.org/static/resolutions/IAU2012_English.pdf
        public static readonly double LightYear = 9460730472580800.0; // exact value https://www.iau.org/public/themes/measuring/
        public static readonly double Parsec = (60.0*60.0*180.0 / Math.PI) * AstronomicalUnit; // 1 Astronomical Unit subtends an angle of 1 second of arc https://imagine.gsfc.nasa.gov/features/cosmic/milkyway_info.html
        public static readonly double Inch = 0.0254; // ref. https://www.nist.gov/pml/owm/si-units-length
        public static readonly double Foot = 12.0 * Inch;
        public static readonly double Yard = 3.0 * Foot;
        public static readonly double USSurveyFoot = 1200.0 / 3937.0; // exact value ref. https://www.nist.gov/pml/us-surveyfoot
        public static readonly double Fathom = 6.0 * Foot; // exact value https://www.britannica.com/science/fathom
        public static readonly double SurveyorChain = 22.0 * Yard; // exact value https://www.britannica.com/technology/surveyors-chain
        public static readonly double Mile = 1760.0 * Yard; // exact value https://dictionary.cambridge.org/dictionary/english/mile
        public static readonly double InternationalNauticalMile = 1852.0; // exact value https://www.merriam-webster.com/dictionary/nautical%20mile
        public static readonly double UKNauticalMile = 6080 * Foot; // exact value https://www.rmg.co.uk/stories/topics/nautical-mile
        public static readonly double ScandinavianMile = 10000.0;
        public static readonly double InchPer32 = Inch / 32.0;
        public static readonly double Mil = 0.001 * Inch; // exact value https://en.wikipedia.org/wiki/Thousandth_of_an_inch
        public static readonly double Thou = Mil; // synonym of Mil
        public static readonly double Hand = 4.0 * Inch; // exact value https://en.wikipedia.org/wiki/Hand_(unit)
        public static readonly double Furlong = 660.0 * Foot; // exact value https://www.britannica.com/science/furlong

        public static readonly double Degree = 180.0 / Math.PI;
        public static readonly double Grad = 200.0 / Math.PI;

        public static readonly double Minute = 60.0;
        public static readonly double Hour = 60.0 * Minute;
        public static readonly double Day = 24.0 * Hour;
        public static readonly double Week = 7.0 * Day;
        public static readonly double Fortnight = 14.0 * Day;
        public static readonly double YearJulian = 365.25 * Day;
        public static readonly double MonthCommon = YearJulian / 12.0; 
        public static readonly double MonthSideral = 27.32166 * Day; // approxmiate https://en.wikipedia.org/wiki/Month
        public static readonly double MonthSynodic = 29.53059 * Day; // approximate https://en.wikipedia.org/wiki/Month
        public static readonly double QuarterCommon = YearJulian / 4.0;
        public static readonly double YearCommon = 365 * Day;
        public static readonly double YearAverageGregorian = (365.0 + 97 / 400) * Day; // https://en.wikipedia.org/wiki/Gregorian_calendar
        public static readonly double YearLeap = 366 * Day;
        public static readonly double YearTropical = 365.2422 * Day; // https://www.grc.nasa.gov/www/k-12/Numbers/Math/Mathematical_Thinking/calendar_calculations.htm
        public static readonly double Decade = 10.0 * YearJulian;
        public static readonly double Century = 10.0 * Decade;
        public static readonly double Millenia = 10.0 * Century;
        public static readonly double MillionYear = 1000.0 * Millenia;

        public static readonly double ZeroCelsius = 273.15; // exact https://www.nist.gov/pml/owm/si-units-temperature
        public static readonly double FahrenheitSlope = 5.0 / 9.0; // exact https://nn.wikipedia.org/wiki/Fahrenheit
        public static readonly double FahrenheitBias = 459.67; // exact https://nn.wikipedia.org/wiki/Fahrenheit
        public static readonly double ReaumurSlope = 5.0 / 4.0; // exact https://en.wikipedia.org/wiki/R%C3%A9aumur_scale
        public static readonly double ReaumurBias = ZeroCelsius / ReaumurSlope;

        public static readonly double C_cgs = 2.99792458e10; // https://en.wikipedia.org/wiki/Statampere

        public static readonly double Hefnerkerze = 0.92; // approximate https://en.wikipedia.org/wiki/Hefner_lamp
        public static readonly double InternationalCandle = 1.02; // approximate 
        public static readonly double DVGWCandle = 1.162 * Hefnerkerze; // approximate https://fr.wikipedia.org/wiki/Bougie_(unit%C3%A9)
        public static readonly double Violle = 60.0; // exact https://en.wikipedia.org/wiki/Jules_Violle
        public static readonly double Carcel = 9.74; // approximate https://en.wikipedia.org/wiki/Carcel

        public static readonly double AtomicMass = 1.66053906660e-27; // approximate https://en.wikipedia.org/wiki/Atomic_mass
        public static readonly double Pound = 0.45359237; // legal https://en.wikipedia.org/wiki/Pound_(mass)
        public static readonly double Ounce = (1.0 / 16.0) * Pound; // exact https://en.wikipedia.org/wiki/Ounce
        public static readonly double Stone = 14.0 * Pound; // exact https://simple.wikipedia.org/wiki/Stone_(unit)
        public static readonly double TonUK = 2240.0 * Pound; // exact https://en.wikipedia.org/wiki/Ton
        public static readonly double TonUS = 2000.0 * Pound; // exact https://en.wikipedia.org/wiki/Ton
        public static readonly double EarthMass = 5.9722e24; // approximate https://en.wikipedia.org/wiki/Earth_mass
        public static readonly double SolarMass = 332946.0487 * EarthMass; // approximate https://en.wikipedia.org/wiki/Earth_mass
        public static readonly double Grain = (1.0 / 7000.0) * Pound; // exact https://en.wikipedia.org/wiki/Grain_(unit)

        public static readonly double Calorie = 4.184; // exact https://en.wikipedia.org/wiki/Calorie

        public static readonly double Litre = 0.001; // exact
        public static readonly double GallonUK = 4.54609e-3; // exact https://en.wikipedia.org/wiki/Gallon
        public static readonly double GallonUS = 231.0 * Inch * Inch * Inch; // exact https://en.wikipedia.org/wiki/Gallon

        public static readonly double BTU = 1054.35; // approximate https://en.wikipedia.org/wiki/British_thermal_unit
        public static readonly double BTUGasPrice = 1054.80; // approximate https://en.wikipedia.org/wiki/British_thermal_unit

        public static readonly double Poise = 0.1; // exact https://en.wikipedia.org/wiki/Poise_(unit)

        public static readonly double G = 9.80665; // standard https://en.wikipedia.org/wiki/Gravity_of_Earth
        public static readonly double WaterDensity4degC1Atm = 999.9720; // approximate https://en.wikipedia.org/wiki/Relative_density
        public static readonly double SpecificGavity4degC = 1.0 / WaterDensity4degC1Atm;
        public static readonly double PPGUK = Pound / GallonUK;
        public static readonly double PPGUS = Pound / GallonUS;

        public static readonly double Knot = 1.852 * Kilo / Hour; // exact https://en.wikipedia.org/wiki/Knot_(unit)
    }
}
