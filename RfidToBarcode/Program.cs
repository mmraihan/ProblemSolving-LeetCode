namespace RfidToBarcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter RFID numbers one by one. Type 'done' when you are finished:");

            var rfids = new System.Collections.Generic.List<string>();
            while (true)
            {
                Console.Write("RFID: ");
                string input = Console.ReadLine().Trim();
                if (input.ToLower() == "done")
                {
                    break;
                }
                else if (input.Length == 24 && IsHex(input))
                {
                    rfids.Add(input);
                }
                else
                {
                    Console.WriteLine("Invalid RFID number. Please enter a valid 24-character hexadecimal RFID or type 'done' to finish.");
                }
            }

            Console.WriteLine("\nRFID Number to Barcode/UPC Number Conversion");
            foreach (var rfid in rfids)
            {
                try
                {
                    var barcode = ConvertRfidToBarcode(rfid);
                    Console.WriteLine($"RFID: {rfid} -> Barcode/UPC: {barcode}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing RFID: {rfid}. Exception: {ex.Message}");
                }
            }

            Console.ReadLine();
        }

        static bool IsHex(string input)
        {
            foreach (char c in input)
            {
                if (!Uri.IsHexDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        static string ConvertRfidToBarcode(string rfid)
        {
            // Validate RFID length
            if (rfid.Length != 24)
            {
                throw new ArgumentException("RFID number must be exactly 24 characters.");
            }

            // Convert RFID to bytes
            byte[] rfidBytes = ConvertFromHex(rfid);

            // Perform SGTIN-96 encoding
            string gtin = PerformSgtin96Encoding(rfidBytes);

            return gtin;
        }

        static byte[] ConvertFromHex(string hex)
        {
            int numberOfChars = hex.Length;
            byte[] bytes = new byte[numberOfChars / 2];
            for (int i = 0; i < numberOfChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        static string PerformSgtin96Encoding(byte[] rfidBytes)
        {
            // Extracting binary string from RFID bytes
            string binaryString = "";
            foreach (byte b in rfidBytes)
            {
                binaryString += Convert.ToString(b, 2).PadLeft(8, '0');
            }

            // Binary header value for SGTIN-96 is “00110000”
            string binaryHeader = binaryString.Substring(0, 8);

            // Filter value for point of sale item is “1” -> 3 bits
            string filterValue = binaryString.Substring(8, 3);

            // Partition value (example uses 7 digits company prefix, partition value is 5)
            string partitionValue = binaryString.Substring(11, 3);

            // Partition value determines the bit length for the company prefix and item reference
            int companyPrefixBits = GetCompanyPrefixBits(partitionValue);
            int itemReferenceBits = 44 - companyPrefixBits;

            // Extract the company prefix, item reference, and serial number
            string companyPrefixBinary = binaryString.Substring(14, companyPrefixBits);
            string itemReferenceBinary = binaryString.Substring(14 + companyPrefixBits, itemReferenceBits);
            string serialNumberBinary = binaryString.Substring(14 + 44, 38);

            // Convert to decimal
            long companyPrefix = Convert.ToInt64(companyPrefixBinary, 2);
            long itemReference = Convert.ToInt64(itemReferenceBinary, 2);
            long serialNumber = Convert.ToInt64(serialNumberBinary, 2);

            // Construct GTIN-14 (UPC is derived from GTIN-14)
            string gtin = companyPrefix.ToString().PadLeft(6, '0') + itemReference.ToString().PadLeft(5, '0');

            // Perform check digit calculation for UPC
            string upc = gtin.PadLeft(11, '0');
            int checkDigit = CalculateCheckDigit(upc);
            upc += checkDigit.ToString();

            return upc;
        }

        static int CalculateCheckDigit(string upc)
        {
            int sum = 0;
            for (int i = 0; i < upc.Length; i++)
            {
                int digit = int.Parse(upc[i].ToString());
                if (i % 2 == 0)
                {
                    sum += digit * 3;
                }
                else
                {
                    sum += digit;
                }
            }
            int modulo = sum % 10;
            int checkDigit = modulo == 0 ? 0 : 10 - modulo;
            return checkDigit;
        }

        static int GetCompanyPrefixBits(string partitionValue)
        {
            switch (partitionValue)
            {
                case "000": return 40;
                case "001": return 37;
                case "010": return 34;
                case "011": return 30;
                case "100": return 27;
                case "101": return 24;
                case "110": return 20;
                case "111": return 17;
                default: throw new ArgumentException("Invalid partition value");
            }
        }
    }
}
