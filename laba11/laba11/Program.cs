using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "laba11.Candy";
            using (StreamWriter sw = new StreamWriter(@"Reflection.txt", false, Encoding.Default))
            {
                sw.WriteLine("- - - - - определение имени сборки - - - - -");
                sw.WriteLine(Reflector.GetAssemblyName());
                sw.WriteLine("- - - - - публичные конструкторы - - - - -");
                sw.WriteLine(Reflector.HasPublicConstructors(name));
                sw.WriteLine("- - - - - все общедоступные публичные методы - - - - -");
                Reflector.PublicMethods(name, sw);
                sw.WriteLine("- - - - - информация о полях и свойствах класса - - - - -");
                Reflector.FieldsAndProperties(name, sw);
                sw.WriteLine("- - - - - все реализованные классом интерфейсы - - - - -");
                Reflector.Interfaces(name, sw);
                sw.WriteLine("- - - - - выводит по имени класса имена методов - - - - -");
                Reflector.MethodType(name, "String", sw);
                sw.WriteLine("- - - - - метод Invoke - - - - -");
                Reflector.Invoke(name, "PrintCandies");
                sw.WriteLine(Reflector.Create(name).ToString());
                sw.WriteLine("///////////////////////////////////////////////////////////");
            }

            name = "laba11.Developer";
            using (StreamWriter sw = new StreamWriter(@"Reflection.txt", true, Encoding.Default))
            {
                sw.WriteLine("- - - - - определение имени сборки - - - - -");
                sw.WriteLine(Reflector.GetAssemblyName());
                sw.WriteLine("- - - - - публичные конструкторы - - - - -");
                sw.WriteLine(Reflector.HasPublicConstructors(name));
                sw.WriteLine("- - - - - все общедоступные публичные методы - - - - -");
                Reflector.PublicMethods(name, sw);
                sw.WriteLine("- - - - - информация о полях и свойствах класса - - - - -");
                Reflector.FieldsAndProperties(name, sw);
                sw.WriteLine("- - - - - все реализованные классом интерфейсы - - - - -");
                Reflector.Interfaces(name, sw);
                sw.WriteLine("- - - - - выводит по имени класса имена методов - - - - -");
                Reflector.MethodType(name, "Int32", sw);
                sw.WriteLine(Reflector.Create(name).ToString());
                sw.WriteLine("///////////////////////////////////////////////////////////");
            }

            name = "System.Type";
            using (StreamWriter sw = new StreamWriter(@"Reflection.txt", true, Encoding.Default))
            {
                sw.WriteLine("- - - - - определение имени сборки - - - - -");
                sw.WriteLine(Reflector.GetAssemblyName());
                sw.WriteLine("- - - - - публичные конструкторы - - - - -");
                sw.WriteLine(Reflector.HasPublicConstructors(name));
                sw.WriteLine("- - - - - все общедоступные публичные методы - - - - -");
                Reflector.PublicMethods(name, sw);
                sw.WriteLine("- - - - - информация о полях и свойствах класса - - - - -");
                Reflector.FieldsAndProperties(name, sw);
                sw.WriteLine("- - - - - все реализованные классом интерфейсы - - - - -");
                Reflector.Interfaces(name, sw);
                sw.WriteLine("- - - - - выводит по имени класса имена методов - - - - -");
                Reflector.MethodType(name, "value", sw);
            }
        }
    }
}