/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections;

namespace OutSystems.HubEdition.RuntimePlatform {

    public static class BitArrayUtils {

        public static BitArray SafeOr(BitArray ba1, BitArray ba2) {
            if (ba1 == null) {
                return ba2;
            }
            if (ba2 == null) {
                return ba1;
            }

            // Don't change the original and create a new instance based on the larger array
            BitArray newBa = new BitArray(ba1.Count >= ba2.Count ? ba1 : ba2);
            int count = Math.Min(ba1.Count, ba2.Count);
            for (int i = 0; i < count; i++) {
                newBa[i] = ba1[i] | ba2[i];
            }

            return newBa;
        }

        public static BitArray SafeAnd(BitArray ba1, BitArray ba2) {
            if (ba1 == null && ba2 == null) {
                return new BitArray(0);
            }

            if (ba1 == null) {
                return new BitArray(ba2.Length, false);
            }
            if (ba2 == null) {
                return new BitArray(ba1.Length, false);
            }
            
            // Don't change the original and create a new instance based on the smaller array
            BitArray newBa = new BitArray(ba1.Count <= ba2.Count ? ba1 : ba2);
            int count = Math.Min(ba1.Count, ba2.Count);
            for (int i = 0; i < count; i++) {
                newBa[i] = ba1[i] & ba2[i];
            }

            return newBa;
        }

        private static byte[] BitArrayToByteArray(BitArray bits) {
            int numBytes = bits.Count / 8;
            if (bits.Count % 8 != 0) {
                numBytes++;
            }

            byte[] bytes = new byte[numBytes];
            int byteIndex = 0, bitIndex = 0;

            for (int i = 0; i < bits.Count; i++) {
                if (bits[i]) {
                    bytes[byteIndex] = (byte)(bytes[byteIndex] | (1 << bitIndex));
                }

                bitIndex++;
                if (bitIndex == 8) {
                    bitIndex = 0;
                    byteIndex++;
                }
            }

            return bytes;
        }

        public static object EncodeBitArray(BitArray bits) {
            if (bits == null) {
                return null;
            }

            byte[] bytes = BitArrayToByteArray(bits);

            if (bytes.Length == 1) {
                return bytes[0];
            }

            if (bytes.Length <= 8) {
                Int64 result = 0;
                for (int i = bytes.Length - 1; i >= 0; i--) {
                    result = result << 8 | ((uint) (bytes[i] & 0xFF));
                }

                if (bytes.Length <= 2) {
                    return (Int16)result;
                } else if (bytes.Length <= 4) {
                    return (Int32)result;
                } else {
                    return result;
                }
            }

            return bytes;
        }

        public static BitArray DecodeBitArray(object obj) {
            if (obj == null) {
                return null;
            }

            byte[] bytes;

            if (obj is byte[]) {
                bytes = (byte[])obj;
            } else {
                long value;
                int numBytes;

                if (obj is byte) {
                    value = (byte)obj;
                    numBytes = 1;
                } else if (obj is Int16) {
                    value = (Int16)obj;
                    numBytes = 2;
                } else if (obj is Int32) {
                    value = (Int32)obj;
                    numBytes = 4;
                } else {
                    value = (Int64)obj;
                    numBytes = 8;
                }

                bytes = new byte[numBytes];
                for (int i = 0; i < numBytes; i++) {
                    bytes[i] = (byte)(value & 0xff);
                    value = value >> 8;
                }
            }

            return new BitArray(bytes);
        }
    }
}
