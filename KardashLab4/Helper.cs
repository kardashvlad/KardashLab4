using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace KardashLab4
{
    internal class Helper
    {
        public static async Task<List<Member>?> Deserialize(string path)
        {
            try
            {
                var options = new JsonSerializerOptions()
                {
                    NumberHandling = JsonNumberHandling.AllowReadingFromString |
                    JsonNumberHandling.WriteAsString
                };
                using FileStream fs = new FileStream(path, FileMode.Open);
                var members = await JsonSerializer.DeserializeAsync<List<Member>>(fs, options);
                return members;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static string Serialize(Member member)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                WriteIndented = true
            };
            string jsonMember = JsonSerializer.Serialize(member, options).Replace("\\u002B", "+"); ;
            return jsonMember;
        }
    }
}
