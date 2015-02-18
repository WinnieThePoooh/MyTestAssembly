using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JetBrains.WinnieThePooh.MyTestAssembly
{
  public class MyTestPublicClassInRootNamespace
  {
    public class MyInnerClass { }
  }

  public class MyTestProtectedClassInRootNamespace
  {
  }

  public class MyTestPrivateClassInRootNamespace
  {
  }

  public interface IMyTestInterfaceInRootNamespace
  {
  }

  public struct MyPublicStruct
  {
  }

  public enum MyPublicEnum
  {
    ToBe = 0,
    NotToBe = 1
  }
}

namespace JetBrains.WinnieThePooh.MyTestAssembly.MinorNamespace
{
  public class MyTestPublicClassInMinorNamespace
  {
  }

  public class MyTestProtectedClassInMinorNamespace
  {
  }

  public class MyTestPrivateClassInMinorNamespace
  {
  }

  public interface IMyTestInterfaceInMinorNamespace
  {
  }
}