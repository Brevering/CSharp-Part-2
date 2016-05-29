/*  12. Parse URL
    Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
    and extracts from it the [protocol], [server] and [resource] elements.
    Input: On the only line you will receive an address
    Output: Print the protocol, server and resource as shown below
    Sample tests:
                Input 	                                                Output
                http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
                                                                        [server] = telerikacademy.com
                                                                        [resource] = /Courses/Courses/Details/212
                https://github.com/gentoo/gentoo.git 	                [protocol] = https
                                                                        [server] = github.com
                                                                        [resource] = /gentoo/gentoo.git
 */
namespace _12.ParseURL
{
    using System;
    using System.Text;

    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            builder.Append(input[0]);
            int i = 1;
            while (input[i] != ':')
            {
                builder.Append(input[i]);
                i++;
            }
            string protocol = builder.ToString();
            builder = builder.Clear();
            i += 3;

            while (input[i] != '/')
            {
                builder.Append(input[i]);
                i++;
            }
            string server = builder.ToString();
            builder = builder.Clear();

            while (i < input.Length)
            {
                builder.Append(input[i]);
                i++;
            }
            string resource = builder.ToString();

            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);

        }
    }
}
