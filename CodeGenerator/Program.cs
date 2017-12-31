using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("aaa");

            
            // SQL(create_sql)ファイル一覧取得
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Directory.GetCurrentDirectory() + @"\sql");
            IEnumerable<System.IO.FileInfo> files = di.EnumerateFiles("*.sql", System.IO.SearchOption.AllDirectories);

            foreach (System.IO.FileInfo f in files)
            {

                string className = f.Name.Replace(".sql", "");

                // スーパークラス定義
                StringBuilder sb = new StringBuilder();
                // NameSpace Class 属性作成
                sb.AppendLine("Namespace app.dto.base");
                sb.AppendLine(String.Format("    Public Class cls{0}BaseDto", className));
                sb.AppendLine("        Inherits clsBaseDto");
                sb.AppendLine();

                System.Text.Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
                var lines = System.IO.File.ReadAllLines(f.FullName, enc);

                foreach(string line in lines){

                    // 特定キーワードは読み込みスキップ
                    if (line.Contains("CREATE") || line.Contains("KEY") || line.Contains("ENGINE")) continue;

                    var strArray = line.Split(" ");
                    string filedName = strArray[2];
                    string filedType = strArray[3];
                    string propertyName = filedName.Replace("`", "");
                    string propertyType = GetPropertyType(filedType);

                    // プロパティの作成
                    String s   = @"            ''' <summary>" + "\n";
                           s  += @"            ''' " + "\n";
                           s  += @"            ''' </summary>" + "\n";
                           s  += @"            ''' <returns></returns>" + "\n";
                           s  += @"            Public Property {0} As {1}" + "\n";
                           s  += @"                Get" + "\n";
                           s  += @"                    Return _{0}" + "\n";
                           s  += @"                End Get" + "\n";
                           s  += @"                Set(ByVal value As {1})" + "\n";
                           s  += @"                    SetProperty(_{0}, value, ""{0}"")" + "\n";
                           s  += @"                End Set" + "\n";
                           s  += @"            End Property" + "\n";
                           s  += @"            Private _{0} As {1}" + "\n";

                    sb.AppendLine(String.Format(s, propertyName, propertyType));

                }

                sb.AppendLine("   End Class");
                sb.AppendLine();
                sb.AppendLine("End Namespace");

                // スーパークラスファイル作成
                System.IO.StreamWriter sw = new System.IO.StreamWriter(
                                        Directory.GetCurrentDirectory() + @"\dto\base\cls" + className + "BaseDto.vb",
                                        false,
                                        System.Text.Encoding.GetEncoding("utf-8"));
                　
                // スーパークラスファイルの書き込み
                sw.Write(sb.ToString());
                //閉じる
                sw.Close();

                // サブクラスファイル作成
                System.IO.StreamWriter sw2 = new System.IO.StreamWriter(
                                        Directory.GetCurrentDirectory() + @"\dto\cls" + className + "Dto.vb",
                                        false,
                                        System.Text.Encoding.GetEncoding("utf-8"));
                // サブクラス定義
                StringBuilder sb2 = new StringBuilder();
                sb2.AppendLine("Namespace app.dto");
                sb2.AppendLine(String.Format("    Public Class cls{0}", className + "Dto"));
                sb2.AppendLine(String.Format("        Inherits cls{0}BaseDto",className));
                sb2.AppendLine();
                sb2.AppendLine("   End Class");
                sb2.AppendLine();
                sb2.AppendLine("End Namespace");

                // サブクラスクラスファイルの書き込み
                sw2.Write(sb2.ToString());
                //閉じる
                sw2.Close();

    
            }
            
        }

        private static string GetPropertyType(string filedType)
        {
            string propertyType = String.Empty;

            if (filedType.Contains("varchar"))
            {
                propertyType = "String";
            }
            else if (filedType.Contains("int"))
            {
                propertyType = "Integer";
            }
            else if (filedType.Contains("decimal"))
            {
                propertyType = "Decimal";
            }
            else if (filedType.Contains("datetime"))
            {
                propertyType = "Datetime";
            }
            else if (filedType.Contains("date"))
            {
                propertyType = "Date";
            }
            else if (filedType.Contains("date"))
            {
                propertyType = "Date";
            }
            else if (filedType.Contains("binary"))
            {
                propertyType = "Boolean";
            }else if (filedType.Contains("text"))
            {
                propertyType = "String";
            }else if (filedType.Contains("varbinary")){
                propertyType = "String";
            }





            return propertyType;
        }
    }
}
