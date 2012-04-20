using System;
using NUnit.Framework;
using CSF.Reflection;
using System.Reflection;

namespace Test.CSF.Reflection
{
  [TestFixture]
  public class TestStaticReflectionUtility
  {
    #region tests
    
    [Test]
    public void TestGetMember()
    {
      PropertyInfo property;
      
      property = (PropertyInfo) StaticReflectionUtility.GetMember<SampleObject>(x => x.PropertyOne);
      Assert.IsNotNull(property, "Not null");
      Assert.AreEqual("PropertyOne", property.Name, "Correct name");
      
      property = (PropertyInfo) StaticReflectionUtility.GetMember<SampleObject>(x => x.PropertyTwo);
      Assert.IsNotNull(property, "2 not null");
      Assert.AreEqual("PropertyTwo", property.Name, "2 correct name");
    }
    
    [Test]
    public void TestGetProperty()
    {
      PropertyInfo property;
      
      property = StaticReflectionUtility.GetProperty<SampleObject>(x => x.PropertyOne);
      Assert.IsNotNull(property, "Not null");
      Assert.AreEqual("PropertyOne", property.Name, "Correct name");
      
      property = StaticReflectionUtility.GetProperty<SampleObject>(x => x.PropertyTwo);
      Assert.IsNotNull(property, "2 not null");
      Assert.AreEqual("PropertyTwo", property.Name, "2 correct name");
    }
    
    #endregion
    
    #region contained object
    
    class SampleObject
    {
      public string PropertyOne
      {
        get;
        set;
      }
      
      public int PropertyTwo
      {
        get;
        set;
      }
    }
    
    #endregion
  }
}
