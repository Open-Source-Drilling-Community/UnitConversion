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

        public static readonly double Minute = 60.0;
        public static readonly double Hour = 60.0 * Minute;
        public static readonly double Day = 24.0 * Hour;
        public static readonly double Week = 7.0 * Day;
        public static readonly double Fortnight = 14.0 * Day;
        public static readonly double MonthCommon = YearJulian / 12.0; 
        public static readonly double MonthSideral = 27.32166 * Day; // approxmiate https://en.wikipedia.org/wiki/Month
        public static readonly double MonthSynodic = 29.53059 * Day; // approximate https://en.wikipedia.org/wiki/Month
        public static readonly double QuarterCommon = YearJulian / 4.0;
        public static readonly double YearCommon = 365 * Day;
        public static readonly double YearJulian = 365.25 * Day;
        public static readonly double YearAverageGregorian = (365.0 + 97 / 400) * Day; // https://en.wikipedia.org/wiki/Gregorian_calendar
        public static readonly double YearLeap = 366 * Day;
        public static readonly double YearTropical = 365.2422 * Day; // https://www.grc.nasa.gov/www/k-12/Numbers/Math/Mathematical_Thinking/calendar_calculations.htm
        public static readonly double Decade = 10.0 * YearJulian;
        public static readonly double Century = 10.0 * Decade;
        public static readonly double Millenia = 10.0 * Century;
        public static readonly double MillionYear = 1000.0 * Millenia;




    }
}
