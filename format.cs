
    
        public static String format(int number)
        {
            string t = number.ToString();
            char[] charArray = t.ToCharArray();
            Array.Reverse(charArray);
            string separator = null, theNumber = null;
            for (int i = (charArray.Length)-1; i >= 0; i--)
            {
                separator = (i % 3 == 0 && i != 0) ? "," : "";
                Console.Write((charArray[i] + separator));
            }
            return theNumber;
        }
        

       