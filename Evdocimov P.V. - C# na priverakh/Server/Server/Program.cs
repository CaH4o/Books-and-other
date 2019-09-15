using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
	class Program
	{
		//static void Main(string[] args)
		//{

		//	Console.OutputEncoding = Encoding.GetEncoding(866);
		//	Console.WriteLine("Однопоточный сервер запущен");

		//	// Подготавливаем конечную точку для сокета
		//	IPHostEntry ipHost = Dns.GetHostEntry("localhost");
		//	IPAddress ipAddr = ipHost.AddressList[0];
		//	IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 8888);

		//	// Создаем потоковый сокет, протокол TCP/IP
		//	Socket sock = new Socket(ipAddr.AddressFamily,
		//	SocketType.Stream, ProtocolType.Tcp);

		//	try
		//	{
		//		// связываем сокет с конечной точкой
		//		sock.Bind(ipEndPoint);
		//		// начинаем прослушку сокета
		//		sock.Listen(10);

		//		// Начинаем слушать соединения
		//		while (true)
		//		{
		//			Console.WriteLine("Слушаем, порт {0}", ipEndPoint);
		//			// Программа приостанавливается, 
		//			// ожидая входящее соединение
		//			// сокет для обмена данными с клиентом
		//			Socket s = sock.Accept();
		//			// сюда будем записывать полученные от клиента данные
		//			string data = null;
		//			// Клиент есть, начинаем читать от него запрос
		//			// массив полученных данных
		//			byte[] bytes = new byte[1024];
		//			// длина полученных данных 
		//			int bytesCount = s.Receive(bytes);
		//			// Декодируем строку
		//			data += Encoding.UTF8.GetString(bytes, 0, bytesCount);
		//			// Показываем данные на консоли
		//			Console.Write("Данные от клиента: " +data + "\n\n");
		//			// Отправляем ответ клиенту
		//			string reply = "Query size: " + data.Length.ToString() + " chars";
		//			// кодируем ответ сервера 
		//			byte[] msg = Encoding.UTF8.GetBytes(reply);
		//			// отправляем ответ сервера
		//			s.Send(msg);
		//			if (data.IndexOf("< TheEnd >") > -1)
		//			{
		//				Console.WriteLine("Соединение завершено.");
		//				break;
		//			}
		//			s.Shutdown(SocketShutdown.Both);
		//			s.Close();
		//		}
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

		static void Main(string[] args)
		{
			TcpListener server = null;
			try
			{
				int MaxThreadsCount = Environment.ProcessorCount * 4;

				// Установим максимальное количество рабочих потоков
				ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);

				// Установим минимальное количество рабочих потоков
				ThreadPool.SetMinThreads(2, 2);

				// Устанавливаем порт для TcpListener = 9595.
				Int32 port = 9595;
				IPAddress localAddr = IPAddress.Parse("127.0.0.1");
				int counter = 0;
				server = new TcpListener(localAddr, port);
				Console.OutputEncoding = Encoding.GetEncoding(866);

				Console.WriteLine("Конфигурация многопоточного сервера:");
				Console.WriteLine(" IP-адрес : 127.0.0.1");
				Console.WriteLine(" Порт : " + port.ToString());
				Console.WriteLine(" Потоки : " + MaxThreadsCount.ToString());
				Console.WriteLine("\nСервер запущен\n");

				// Запускаем TcpListener и начинаем слушать клиентов.
				server.Start();

				// Принимаем клиентов в бесконечном цикле.
				while (true)
				{
					Console.Write("\nОжидание соединения... ");
					ThreadPool.QueueUserWorkItem(ClientProcessing,
					server.AcceptTcpClient());
					// Выводим информацию о подключении.
					counter++;
					Console.Write("\nСоединение №" + counter.ToString() + "!");
				}
			}
			catch (SocketException e)
			{
				Console.WriteLine("SocketException: {0}", e);
			}
			finally
			{
				// Останавливаем сервер
				server.Stop();
			}
			Console.WriteLine("\nНажмите Enter...");
			Console.Read();
		}

		static void ClientProcessing(object client_obj)
		{
			// Буфер для принимаемых данных.
			Byte[] bytes = new Byte[256];
			String data = null;
			TcpClient client = client_obj as TcpClient;
			data = null;

			// Получаем информацию от клиента
			NetworkStream stream = client.GetStream();
			int i;

			// Принимаем данные от клиента в цикле пока не дойдём до конца.
			while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
			{
				// Преобразуем данные в ASCII string.
				data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
				// Преобразуем строку к верхнему регистру.
				data = data.ToUpper();
				// Преобразуем полученную строку в массив Байт.
				byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);
				// Отправляем данные обратно клиенту (ответ).
				stream.Write(msg, 0, msg.Length);
			}

			// Закрываем соединение.
			client.Close();
		}
	}
}
