namespace EdabitExercises
{
    public static class Intermediate
    {
        //Create a function that finds the word "bomb" in the given string (not case sensitive).
        //If found, return "Duck!!!", otherwise, return "There is no bomb, relax.".
        public static string Bomb(string word) =>
            word.ToUpper().Contains("BOMB") ? "Duck!!!" : "There is no bomb, relax.";

        //In this challenge, you must verify the equality of two different values given the parameters a and b.
        //Both the value and type of the parameters need to be equal.The possible types of the given parameters are:
        //Numbers
        //Strings
        //Booleans (false or true)
        //What have you learned so far that will permit you to do two different checks(value and type) with a single statement?
        //Implement a function that returns true if the parameters are equal, and false if they are not.
        public static bool CheckEquality(object a, object b) =>
            a.Equals(b) ? true : false;

        //Create a function that takes an array of integers and strings, converts integers to strings, and returns the array as a string array.
        public static string?[] ParseArray(object[] arr) =>
            Array.ConvertAll(arr, element => element.ToString());

        //Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.
        public static int[] IndexOfCapitals(string str)
        {
            List<int> list = new List<int>();
            int j = 0;
            foreach (var item in str)
            {
                if(char.IsUpper(item))
                {
                    list.Add(j);
                }
                j++;
            }
            return list.ToArray();
        }
    }
}
