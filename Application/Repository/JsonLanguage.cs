using Application.Repository.Interface;
using System.IO;
using System;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace Application.Repository
{
    public class JsonLanguage : IJsonLanguage
    {
        public void AddJsonLanguage<T>(T json, string lang, string path) where T : class
        {
            var pathLang = @$"{path}/{lang}";
            var fileName = $"{lang}.json";
            var fullPath = @$"{pathLang}/{fileName}";
            var directoryOlds = $@"{pathLang}/olds";
            var fileNameBackup = $"{lang}_{(DateTime.Now).ToString("dd.MM.yyyy-HH.mm")}.json";

            if (!Directory.Exists(pathLang))
            {
                Directory.CreateDirectory(pathLang);
                CreateJsonFile(json, fullPath);
            }
            else
            {
                if (!File.Exists(@$"{fullPath}"))
                {
                    CreateJsonFile(json, fullPath);
                }
                else
                {
                    if (!Directory.Exists(directoryOlds))
                    {
                        Directory.CreateDirectory(directoryOlds);
                        File.Move(fullPath, @$"{directoryOlds}/{fileNameBackup}");
                        CreateJsonFile(json, fullPath);
                    }
                    else
                    {
                        File.Move(fullPath, @$"{directoryOlds}/{fileNameBackup}");
                        CreateJsonFile(json, fullPath);
                    }
                }
            }
        }

        private void CreateJsonFile<T>(T json, string fullPath) where T : class
        {
            byte[] jsonUtf8Bytes;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            };
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(json, options);
            File.WriteAllBytes(fullPath, jsonUtf8Bytes);

        }
    }
}
