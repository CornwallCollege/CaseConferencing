/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace OutSystems.RuntimeCommon {

    public static class StreamUtils {

        private const int BufferSize = 65536;
        private const int GuidSize = 16;
        
        public static void PumpStream(Stream inputStream, Stream outputStream) {
            byte[] buffer = new byte[BufferSize];
            while (true) {
                int bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                if (bytesRead > 0) {
                    outputStream.Write(buffer, 0, bytesRead);
                } else {
                    break;
                }
            }
        }

        public static void WriteString(Stream outputStream, string value) {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            int size = bytes.Length;
            WriteInt32(outputStream, size);
            outputStream.Write(bytes, 0, size);
        }

        public static string ReadString(Stream inputStream) {
            int size = ReadInt32(inputStream);
            byte[] buffer = new byte[size];
            inputStream.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer);
        }

        public static void WriteInt32(Stream outputStream, int value) {
            byte[] buffer = BitConverter.GetBytes(value);
            outputStream.Write(buffer, 0, buffer.Length);
        }

        public static int ReadInt32(Stream inputStream) {
            byte[] buffer = new byte[sizeof(int)];
            inputStream.Read(buffer, 0, buffer.Length);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static void WriteBool(Stream outputStream, bool value) {
            outputStream.WriteByte(value ? (byte)1 : (byte)0);
        }
        
        public static bool ReadBool(Stream inputStream) {
            byte[] buffer = new byte[1];
            inputStream.Read(buffer, 0, 1);
            return buffer[0] != 0;
        }

        public static void WriteGuid(Stream outputStream, Guid guid) {
            byte[] bytes = guid.ToByteArray();
            outputStream.Write(bytes, 0, bytes.Length);
        }
        
        public static Guid ReadGuid(Stream inputStream) {
            byte[] guidBytes = new byte[GuidSize];
            inputStream.Read(guidBytes, 0, GuidSize);
            return new Guid(guidBytes);
        }

        public static Stream ToStream(string str) {
            return new MemoryStream(Encoding.UTF8.GetBytes(str));
        }

        public static byte[] ToArray(Stream stream) {
            var memoryStream = stream as MemoryStream;
            if (memoryStream == null) {
                memoryStream = new MemoryStream();
                PumpStream(stream, memoryStream);
            }
            return memoryStream.ToArray();
        }

        [DebuggerNonUserCode]
        public static T SafeDeserialize<T>(BinaryFormatter formatter, Stream stream) where T : class {
            try {
                return formatter.Deserialize(stream) as T;
            } catch (FileLoadException) {
                return null;
            }
        }
    }
}
