using AutoMapper;
using System;

namespace Twinkle.Mvc.Converter
{

    public class DateTimeConverterForString : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return System.Convert.ToDateTime(source);
        }
    }

    public class StringConverterForDatetime : ITypeConverter<DateTime, string>
    {
        public string Convert(DateTime source,  string destination, ResolutionContext context)
        {
            return source.ToString();
        }
    }


    public class LongConverterForString : ITypeConverter<string, long>
    {
        public long Convert(string source, long destination, ResolutionContext context)
        {
            return System.Convert.ToInt64(source);
        }
    }

    public class StringConverterForLong : ITypeConverter<long, string>
    {
        public string Convert(long source, string destination, ResolutionContext context)
        {
            return source.ToString();
        }
    }


    public class DoubleConverterForString : ITypeConverter<string, double>
    {
        public double Convert(string source, double destination, ResolutionContext context)
        {
            return System.Convert.ToDouble(source);
        }
    }

    public class StringConverterForDouble : ITypeConverter<double, string>
    {
        public string Convert(double source, string destination, ResolutionContext context)
        {
            return source.ToString();
        }
    }
}
