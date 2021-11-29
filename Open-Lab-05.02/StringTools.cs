using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            var list = new List<char>();
            char[] characters = sentence.ToCharArray();
            char to_Add = '\0'; 
            bool can_Add = false;

            for (int i = characters.Length - 1; i >= 0; i -= 1)
            {
                string character = characters[i].ToString();
                if (character == "?" || character == "!" )
                {
                    if (can_Add == false)
                    {
                        to_Add = characters[i];
                    }
                    else
                    {
                        list.Add(characters[i]);
                    }

                }
                else
                {
                    can_Add = true;
                    list.Add(characters[i]);
                } 
            }

            list.Reverse();

            if (to_Add.ToString() != "\0")
            {
                list.Add(to_Add);
            }

            return new string(list.ToArray());
        }
    }
}
