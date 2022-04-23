using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EternalKit.Domain.Entities
{
    public static class LengthConversionFactor
    {
        public static IDictionary<string, decimal> LengthUnits = new Dictionary<string, decimal>()
        {
            {"متر (Meter)", 1},
            {"دسی متر (Decimeter)", 0.1m},
            {"سانتی متر (Centimeter)", 0.01m},
            {"میلی متر (Millimeter)", 0.001m},
            {"میکرو متر (Micrometer)", 0.000001m},
            {"نانو متر (Nanometer)", 0.000000001m},
            {"آنگستروم (Angstrom)", 0.0000000001m},
            {"پیکومتر (Picometer)", 0.000000000001m},
            {"فمتو متر (Femtometer)", 0.000000000000001m},

            {"اینچ (Inch)", 0.0254000000001016m},
            {"پا (Foot)", 0.30480000000121928m},
            {"یارد (Yard)", 0.9144000000315285m},
            {"وجب (Span)", 0.225000000225m},
            {"پوینت (Point)", 0.00035277777777669984m},

            {"کیلو متر (Kilometer)", 1000},

            {"مایل (Mile)", 1609.3439798947877m},
            { "مایل دریایی (NauticalMile)", 1852.0000118528m},
            { "فرسنگ - فرسخ (Parasang)", 6239.860227130913m},
            { "فرسنگ شرعی دین اسلام (IslamicParasang)", 5366.534292154127m},
            { "ذرع (Cubit)", 1.040000001664m},
            { "فاتوم (Fathom)", 1.8287999972202242m},
            { "چِین - زنجیر (Chain)", 20.116798129942445m},
            { "فرلانگ (Ffurlong)", 201.16838598580557m},
            { "سال نوری (LightYear)", 9460730472801122},
            { "شعاع خورشیدی (SolarRadius)", 695699999.3557818m},
            { "واحد نجومی (AstronomicalUnit)", 149597870750.76672m}
        };
    }
}
