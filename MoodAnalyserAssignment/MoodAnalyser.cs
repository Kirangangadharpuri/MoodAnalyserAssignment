using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserAssignment
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if(this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.Empty_Message, "Mood should not be null");

                }
                if(this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
                
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            
        }
    }
}
