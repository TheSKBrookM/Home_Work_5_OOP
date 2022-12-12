using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_5_4
{
    internal class Dictionary
    {
        private string[] UA = new string[10];
        private string[] EN = new string[10];
        private string[] PL = new string[10];

        // мряка \ дощ \ хуртовина \ туман \ хмара \ сонце \ холод \ спекотно \ град \ райдуга 
        // drizzle \ rain \ blizzard \ fog \ cloud \ sun \ cold \ hot \ hail \ rainbow
        // zmierzch \ deszcz \ zamieć \ mgła \ chmura \ słońce \ zimno \ gorąco \ grad \ tęcza

        public Dictionary()
        {
            UA[0] = "мряка"; EN[0] = "drizzle"; PL[0] = "zmierzch";
            UA[1] = "дощ"; EN[1] = "rain"; PL[1] = "deszcz";
            UA[2] = "хуртовина"; EN[2] = "blizzard"; PL[2] = "zamiec";
            UA[3] = "туман"; EN[3] = "fog"; PL[3] = "mgla";
            UA[4] = "хмара"; EN[4] = "cloud"; PL[4] = "chmura";
            UA[5] = "сонце"; EN[5] = "sun"; PL[5] = "slonce";
            UA[6] = "холод"; EN[6] = "cold"; PL[6] = "zimno";
            UA[7] = "спекотно"; EN[7] = "hot"; PL[7] = "goraco";
            UA[8] = "град"; EN[8] = "hail"; PL[8] = "grad";
            UA[9] = "райдуга"; EN[9] = "rainbow"; PL[9] = "tecza";
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < UA.Length)
                { 
                    return $"{UA[index]} => {EN[index]} => {PL[index]}";   
                }
                return "out of array";
            }
        }

        public string this[string index]
        { 
            get
            {
                for (int i = 0; i < UA.Length; i++)
                {
                    if (UA[i] == index)
                    {
                        return $"{UA[i]} => {EN[i]} => {PL[i]}\n";
                    }
                    if (EN[i] == index)
                    {
                        return $"{EN[i]} => {UA[i]} => {PL[i]}\n";
                    }
                    if (PL[i] == index)
                    {
                        return $"{PL[i]} => {UA[i]} => {EN[i]}\n";
                    }
                }
                return $"Слова {index} немає у словнику.";
            }
        }

        public void Show()
        {
            for (int i = 0; i < UA.Length; i++)
            {
                Console.Write($"{UA[i]}\n");
            }
        }
    }
}
