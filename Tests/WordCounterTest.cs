using Xunit;
using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounterTest
  {
    // [Fact]
    // public void RepeatCounter_GatherInput_equalTo()
    // {
    //   //Arrange
    //   string input1 = "french";
    //
    //   // Act
    //   CountRepeats newCountRepeats = new CountRepeats();
    //
    //   //Assert
    //   Assert.Equal(true , newCountRepeats.GetRepeatTrue(input1));
    //
    [Fact]
    public void RepeatCounter_GatherInputs_CompairToString()
    {
      //Arrange
      string input1 = "french";
      List<string> input2 = new List<string>();
      input2.Add("jenny");
      input2.Add("was");
      input2.Add("just");
      input2.Add("about");
      input2.Add("french");

      foreach (string match in input2)
      {
        if (match == input1)
        {
          System.Console.WriteLine("match");
        }
      }
    }
  }
}
