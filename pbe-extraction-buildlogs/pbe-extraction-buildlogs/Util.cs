using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.ProgramSynthesis.DslLibrary;
using Microsoft.ProgramSynthesis.Extraction.Text;

namespace pbeextractionbuildlogs
{
	public static class Util
	{
		private static Random rng = new Random();

		// from https://stackoverflow.com/a/1262619/6456126
		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}

		public static string NormalizeBuildLogString(string log)
		{
			return log.Replace("\r\n", "\n").Replace("\n\r", "\n").Replace("\r", "\n").Replace(((char)0x1b).ToString(), "");
		}
	}

	/// <summary>
	///  Invariant: Files do not move or disappear.
	/// </summary>
	///
	public static class AnalysisUtil
	{
		private static readonly Dictionary<string, StringRegion> fileCache = new Dictionary<string, StringRegion>();

		public static StringRegion RegionFromFile(string path)
		{
			if (fileCache.ContainsKey(path))
			{
				return fileCache[path];
			}
			string text = Util.NormalizeBuildLogString(File.ReadAllText(path));
			StringRegion region = RegionSession.CreateStringRegion(text);
			fileCache[path] = region;
			return region;
		}
	}

	public class ConsolePrinter
	{
		public bool Verbose { get; set; }

		public ConsolePrinter(bool verbose)
		{
			Verbose = verbose;
		}

		public void WriteLine(object output)
		{
			if (Verbose)
			{
				Console.WriteLine(output);
			}
		}
	}


	[XmlRoot("dictionary")]
	public class SerializableDictionary<TKey, TValue>
		: Dictionary<TKey, TValue>, IXmlSerializable
	{
		public SerializableDictionary() { }
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary) { }
		public SerializableDictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> comparer) : base(dictionary, comparer) { }
		public SerializableDictionary(IEqualityComparer<TKey> comparer) : base(comparer) { }
		public SerializableDictionary(int capacity) : base(capacity) { }
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer) : base(capacity, comparer) { }

		#region IXmlSerializable Members
		public System.Xml.Schema.XmlSchema GetSchema()
		{
			return null;
		}

		public void ReadXml(System.Xml.XmlReader reader)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

			bool wasEmpty = reader.IsEmptyElement;
			reader.Read();

			if (wasEmpty)
				return;

			while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
			{
				reader.ReadStartElement("item");

				reader.ReadStartElement("key");
				TKey key = (TKey)keySerializer.Deserialize(reader);
				reader.ReadEndElement();

				reader.ReadStartElement("value");
				TValue value = (TValue)valueSerializer.Deserialize(reader);
				reader.ReadEndElement();

				this.Add(key, value);

				reader.ReadEndElement();
				reader.MoveToContent();
			}
			reader.ReadEndElement();
		}

		public void WriteXml(System.Xml.XmlWriter writer)
		{
			XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
			XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

			foreach (TKey key in this.Keys)
			{
				writer.WriteStartElement("item");

				writer.WriteStartElement("key");
				keySerializer.Serialize(writer, key);
				writer.WriteEndElement();

				writer.WriteStartElement("value");
				TValue value = this[key];
				valueSerializer.Serialize(writer, value);
				writer.WriteEndElement();

				writer.WriteEndElement();
			}
		}
		#endregion
	}
}
