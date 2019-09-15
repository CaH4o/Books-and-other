using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
	class Program
	{
		//static void Main(string[] args)
		//{
		//	Console.OutputEncoding = Encoding.GetEncoding(866);
		//	try
		//	{
		//		Communicate("localhost", 8888);
		//	}
		//	catch (Exception ex)
		//	{
		//		Console.WriteLine(ex.ToString());
		//	}
		//	finally
		//	{
		//		Console.ReadLine();
		//	}
		//}

		//static void Communicate(string hostname, int port)
		//{
		//	// Буфер для входящих данных
		//	byte[] bytes = new byte[1024];

		//	// Соединяемся с удаленным сервером
		//	// Устанавливаем удаленную точку (сервер) для сокета
		//	IPHostEntry ipHost = Dns.GetHostEntry(hostname);
		//	IPAddress ipAddr = ipHost.AddressList[0];
		//	IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);
		//	Socket sock = new Socket(ipAddr.AddressFamily,
		//	SocketType.Stream, ProtocolType.Tcp);
		//	// Подключаемся к серверу
		//	sock.Connect(ipEndPoint);
		//	Console.Write("Введите сообщение: ");
		//	string message = Console.ReadLine();
		//	Console.WriteLine("Подключаемся к порту {0} ",
		//	sock.RemoteEndPoint.ToString());
		//	byte[] data = Encoding.UTF8.GetBytes(message);
		//	// Получаем к-во отправленных байтов
		//	int bytesSent = sock.Send(data);
		//	// Получаем ответ от сервера, bytesRec - к-во принятых байтов
		//	int bytesRec = sock.Receive(bytes);
		//	Console.WriteLine("\nОтвет сервера: {0}\n\n",
		//	Encoding.UTF8.GetString(bytes, 0, bytesRec));
		//	// Вызываем Communicate() еще
		//	if (message.IndexOf("<TheEnd>") == -1)
		//		Communicate(hostname, port);
		//	// Освобождаем сокет
		//	sock.Shutdown(SocketShutdown.Both);
		//	sock.Close();
		//}

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.GetEncoding(866);

			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("\n Соединение # " + i.ToString() + "\n");
				Connect("127.0.0.1", "Hello World! #" + i.ToString());
			}

			Console.WriteLine("\n Нажмите Enter...");
			Console.Read();
		}

		static void Connect(String server, String message)
		{
			try
			{
				// Создаём TcpClient.
				// Для созданного в предыдущем проекте TcpListener 
				// Настраиваем его на IP нашего сервера и тот же порт.
				Int32 port = 9595;
				TcpClient client = new TcpClient(server, port);

				// Переводим наше сообщение в ASCII, а затем в массив Byte.
				Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

				// Получаем поток для чтения и записи данных.
				NetworkStream stream = client.GetStream();

				// Отправляем сообщение нашему серверу. 
				stream.Write(data, 0, data.Length);
				Console.WriteLine($"Отправлено: {message}");

				// Получаем ответ от сервера.
				// Буфер для хранения принятого массива bytes.
				data = new Byte[256];

				// Строка для хранения полученных ASCII данных.
				String responseData = String.Empty;

				// Читаем первый пакет ответа сервера. 
				// Можно читать всё сообщение.
				// Для этого надо организовать чтение в цикле как на сервере.
				Int32 bytes = stream.Read(data, 0, data.Length);
				responseData = System.Text.Encoding.ASCII.
				GetString(data, 0, bytes);
				Console.WriteLine("Получено: {0}", responseData);

				// Закрываем всё.
				stream.Close();
				client.Close();
			}
			catch (ArgumentNullException e)
			{
				Console.WriteLine("ArgumentNullException: {0}", e);
			}
			catch (SocketException e)
			{
				Console.WriteLine("SocketException: {0}", e);
			}
		}
	}
}
