﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005Indexers
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book";
            key[1] = "ручка"; value[1] = "pen";
            key[2] = "солнце"; value[2] = "sun";
            key[3] = "яблоко"; value[3] = "apple";
            key[4] = "стол"; value[4] = "table";
        }

        public string this[string index]
        {
            get
            {

                for (int i = 0; i < key.Length; i++)
                {
                    if (key[i] == index)
                    {
                        return key[i] + " - " + value[i];
                    }
                    
                }
                return string.Format("{0} - нет перевода этого слова.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                {
                    return key[index] + " - " + value[index];
                }
                else
                    return "Попытка обращения за пределы массиваю";
            }
        }
    }
}
