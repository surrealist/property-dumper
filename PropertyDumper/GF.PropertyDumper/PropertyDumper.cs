using System;
using System.ComponentModel;

namespace GF.PropertyDumper {
  public static class PropertyDumper {

    private static readonly string separateLine = new string('-', 60);

    public static void Dump(object obj, Action<string> writer = null) {
      if (writer == null) writer = Console.WriteLine;
      writer(separateLine);
      writer(string.Format("[{0}]", obj.GetType().ToString()));
      foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj)) {
        writer(string.Format("  {0}={1}", descriptor.Name, descriptor.GetValue(obj)));
      }
    }
  }
}
