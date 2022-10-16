namespace Diamond_Kata
{
    public class DiamondBuilder
    {
        private readonly char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public string Build(string input)
        {
            if (input.Length == 1 && alphabet.Contains(input[0]))
            {
                var index = Array.IndexOf(alphabet, input[0]);

                var length = (index * 2) + 1;

                string[] diamond = new string[length];

                for (int i = 0; i < length; i++)
                {
                    if (i <= index)
                    {
                        diamond[i] = BuildLine(index, i, length);
                    }
                    else
                    {
                        diamond[i] = diamond[i - ((i - index) * 2)];
                    }
                }

                return string.Join(Environment.NewLine, diamond);
            }
            else
            {
                return $"Input value is not valid character: Input: {input}";
            }
        }

        private string BuildLine(int index, int lineIndex, int lineLength)
        {
            var line = new string(' ', lineLength).ToArray();

            line[index - lineIndex] = alphabet[lineIndex];
            line[index + lineIndex] = alphabet[lineIndex];

            return new string(line);
        }
    }
}
