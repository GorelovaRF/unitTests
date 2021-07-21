using System;
using System.Threading.Tasks;

namespace MSTest_tests_example.Mocks.Date
{   
    public class ImageManagement
    {


        public virtual int setTime()
        {
            int selectesHour = 12;
            return selectesHour;
        }

        public string GetImageForTimeOfDay()
        {
           
            int currentHour = 12;

            if (currentHour > 6 && currentHour < 21)
                return "sun.jpg";
            else
                return "moon.jpg";
        }

        


    }
}
 