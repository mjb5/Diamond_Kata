using FluentAssertions;

namespace Diamond_Kata.Tests
{
    [TestClass]
    public class DiamondBuilderTests
    {
        [TestMethod]
        public void GivenBuildCalledWhenInputIsAThenCorrectDiamondStringIsReturned()
        {
            var expected = "A";

            var builder = new DiamondBuilder();

            var actual = builder.Build("A");

            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenBuildCalledWhenInputIsBThenCorrectDiamondStringIsReturned()
        {
            var expected = 
                $" A {Environment.NewLine}" +
                $"B B{Environment.NewLine}" +
                $" A ";

            var builder = new DiamondBuilder();

            var actual = builder.Build("B");

            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenBuildCalledWhenInputIsCThenCorrectDiamondStringIsReturned()
        {
            var expected = 
                $"  A  {Environment.NewLine}" +
                $" B B {Environment.NewLine}" +
                $"C   C{Environment.NewLine}" +
                $" B B {Environment.NewLine}" +
                $"  A  ";

            var builder = new DiamondBuilder();

            var actual = builder.Build("C");

            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenBuildCalledWhenInputIsDThenCorrectDiamondStringIsReturned()
        {
            var expected =
                $"   A   {Environment.NewLine}" +
                $"  B B  {Environment.NewLine}" +
                $" C   C {Environment.NewLine}" +
                $"D     D{Environment.NewLine}" +
                $" C   C {Environment.NewLine}" +
                $"  B B  {Environment.NewLine}" +
                $"   A   ";

            var builder = new DiamondBuilder();

            var actual = builder.Build("D");

            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenBuildCalledWhenInputIsMThenCorrectDiamondStringIsReturned()
        {
            var expected =
                $"            A            {Environment.NewLine}" +
                $"           B B           {Environment.NewLine}" +
                $"          C   C          {Environment.NewLine}" +
                $"         D     D         {Environment.NewLine}" +
                $"        E       E        {Environment.NewLine}" +
                $"       F         F       {Environment.NewLine}" +
                $"      G           G      {Environment.NewLine}" +
                $"     H             H     {Environment.NewLine}" +
                $"    I               I    {Environment.NewLine}" +
                $"   J                 J   {Environment.NewLine}" +
                $"  K                   K  {Environment.NewLine}" +
                $" L                     L {Environment.NewLine}" +
                $"M                       M{Environment.NewLine}" +
                $" L                     L {Environment.NewLine}" +
                $"  K                   K  {Environment.NewLine}" +
                $"   J                 J   {Environment.NewLine}" +
                $"    I               I    {Environment.NewLine}" +
                $"     H             H     {Environment.NewLine}" +
                $"      G           G      {Environment.NewLine}" +
                $"       F         F       {Environment.NewLine}" +
                $"        E       E        {Environment.NewLine}" +
                $"         D     D         {Environment.NewLine}" +
                $"          C   C          {Environment.NewLine}" +
                $"           B B           {Environment.NewLine}" +
                $"            A            ";

            var builder = new DiamondBuilder();

            var actual = builder.Build("M");

            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenBuildCalledWhenInputIsZThenCorrectDiamondStringIsReturned()
        {
            var expected =
                $"                         A                         {Environment.NewLine}" +
                $"                        B B                        {Environment.NewLine}" +
                $"                       C   C                       {Environment.NewLine}" +
                $"                      D     D                      {Environment.NewLine}" +
                $"                     E       E                     {Environment.NewLine}" +
                $"                    F         F                    {Environment.NewLine}" +
                $"                   G           G                   {Environment.NewLine}" +
                $"                  H             H                  {Environment.NewLine}" +
                $"                 I               I                 {Environment.NewLine}" +
                $"                J                 J                {Environment.NewLine}" +
                $"               K                   K               {Environment.NewLine}" +
                $"              L                     L              {Environment.NewLine}" +
                $"             M                       M             {Environment.NewLine}" +
                $"            N                         N            {Environment.NewLine}" +
                $"           O                           O           {Environment.NewLine}" +
                $"          P                             P          {Environment.NewLine}" +
                $"         Q                               Q         {Environment.NewLine}" +
                $"        R                                 R        {Environment.NewLine}" +
                $"       S                                   S       {Environment.NewLine}" +
                $"      T                                     T      {Environment.NewLine}" +
                $"     U                                       U     {Environment.NewLine}" +
                $"    V                                         V    {Environment.NewLine}" +
                $"   W                                           W   {Environment.NewLine}" +
                $"  X                                             X  {Environment.NewLine}" +
                $" Y                                               Y {Environment.NewLine}" +
                $"Z                                                 Z{Environment.NewLine}" +
                $" Y                                               Y {Environment.NewLine}" +
                $"  X                                             X  {Environment.NewLine}" +
                $"   W                                           W   {Environment.NewLine}" +
                $"    V                                         V    {Environment.NewLine}" +
                $"     U                                       U     {Environment.NewLine}" +
                $"      T                                     T      {Environment.NewLine}" +
                $"       S                                   S       {Environment.NewLine}" +
                $"        R                                 R        {Environment.NewLine}" +
                $"         Q                               Q         {Environment.NewLine}" +
                $"          P                             P          {Environment.NewLine}" +
                $"           O                           O           {Environment.NewLine}" +
                $"            N                         N            {Environment.NewLine}" +
                $"             M                       M             {Environment.NewLine}" +
                $"              L                     L              {Environment.NewLine}" +
                $"               K                   K               {Environment.NewLine}" +
                $"                J                 J                {Environment.NewLine}" +
                $"                 I               I                 {Environment.NewLine}" +
                $"                  H             H                  {Environment.NewLine}" +
                $"                   G           G                   {Environment.NewLine}" +
                $"                    F         F                    {Environment.NewLine}" +
                $"                     E       E                     {Environment.NewLine}" +
                $"                      D     D                      {Environment.NewLine}" +
                $"                       C   C                       {Environment.NewLine}" +
                $"                        B B                        {Environment.NewLine}" +
                $"                         A                         ";

            var builder = new DiamondBuilder();

            var actual = builder.Build("Z");

            actual.Should().Be(expected);
        }

        [TestMethod]
        public void GivenBuildCalledWhenInputIsNonAlphabetCharacterThenErrorMessageReturned()
        {
            var expected = "Input value is not valid character: Input: !";

            var builder = new DiamondBuilder();

            var actual = builder.Build("!");

            actual.Should().Be(expected);
        }
    }
}