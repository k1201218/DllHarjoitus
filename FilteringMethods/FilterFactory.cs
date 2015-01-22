using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteringMethods
{

    public enum FilterTypes
    {
        Median, Avarage
    }


    public class FilterFactory
    {
        public static Filter CreateFilter(FilterTypes type, int length)
        {
            Filter f = null;
            switch (type)
            {


                case FilterTypes.Median:
                    f = new MedianFilter(length);
                    break;

                case FilterTypes.Avarage:
                    f = new AverageFilter(length);
                    break;

                default:
                    // throw some exception
                    break;
            }
            return f;
        }
    }
}
