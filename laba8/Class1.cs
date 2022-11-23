class StringEditor
    {
        public static string RemovePunctuation(string str)
        {
            str = Regex.Replace(str, "[.,;:]", string.Empty);
            return str;
        }

        public static string AddSymbol(string str)
        {
            return str += "Laba8";
        }

        public static string ToUpper(string str)
        {
            return str.ToUpper();
        }

        public static string ToLower(string str)
        {
            return str.ToLower();
        }

        public static string RemoveSpace(string str)
        {
            return str.Replace(" ", string.Empty);
        }
    }
