using System;
namespace GF.PropertyDumper.Sample {
  class Program {
    static void Main(string[] args) {
      DateTime dt = DateTime.MaxValue;
      var product = new Tuple<int, string, decimal>(1, "Box", 50);

      PropertyDumper.Dump(dt);
      PropertyDumper.Dump(product);
    }
  }
}
