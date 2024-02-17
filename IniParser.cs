using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace L
{
    class SectionPair
    {
        public string Key { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public override int GetHashCode()
        {
            return ("[" + Key + "]" + Value).GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj != null && (obj as SectionPair).Key == this.Key && (obj as SectionPair).Value == this.Value;
        }
    }
    class IniParser
    {
        public static IniParser Load(string path)
        {
            try
            {
                return new IniParser(File.ReadAllText(path));
            }
            catch
            {
                return new IniParser(string.Empty);
            }
        }

        public IniParser(string ini)
        {
            var iniFile = default(TextReader);
            var strLine = default(string);
            var currentRoot = default(string);
            var keyPair = default(string[]);
            try
            {
                var buffer = Encoding.UTF8.GetBytes(ini);
                iniFile = new StreamReader(new MemoryStream(buffer));
                while ((strLine = iniFile.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(strLine))
                    {
                        if (strLine.StartsWith("[") && strLine.EndsWith("]"))
                        {
                            currentRoot = strLine.Substring(1, strLine.Length - 2);
                        }
                        else
                        {
                            keyPair = strLine.Split(new char[] { '=' }, 2);
                            var sectionPair = new SectionPair
                            {
                                Key = currentRoot ?? "ROOT",
                                Value = keyPair[0]
                            };
                            keyPairs[sectionPair] = keyPair[1].Replace("\\n", "\r\n");
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Do nothing
            }
            finally
            {
                iniFile?.Dispose();
            }
        }

        private Dictionary<SectionPair, string> keyPairs = new Dictionary<SectionPair, string>();
        public string Read(string sectionName, string settingName)
        {
            var section = new SectionPair { Key = sectionName, Value = settingName };
            if (keyPairs.TryGetValue(section, out var value))
            {
                return value ?? string.Empty;
            }
            return string.Empty;
        }

        public void Write(string section, String key, string value)
        {
            keyPairs[new SectionPair { Key = section, Value = key }] = value;
        }

        public void Save(string path)
        {
            try
            {
                File.WriteAllText(path, ToString());
            }
            catch { }
        }

        public override string ToString()
        {
            var sections = keyPairs.Keys.Select(k => k.Key).Distinct();
            var sb = new StringBuilder();
            foreach (var section in sections)
            {
                sb.AppendLine("[" + section + "]");
                foreach (var pair in keyPairs.Where(p => p.Key.Key == section))
                {
                    if (!string.IsNullOrEmpty(pair.Value))
                    {
                        var value = pair.Value.Replace("\r", "").Replace("\n", "\\n");
                        sb.AppendLine(pair.Key.Value + "=" + value);
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }

}