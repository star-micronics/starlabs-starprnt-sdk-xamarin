using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StarIoWrapper;
using Xamarin.Forms;

namespace XamarinSDK.Communication
{
    public enum Result
    {
        Success,
        UnknownError,
        GetPortError,
        BeginCheckedBlockError,
        EndCheckedBlockError,
        GetParsedStatusError,
        WritePortError,
//      ReleasePortError
    }

    class Communication
    {
        public static void SendCommands(byte[] commands, string portName, string portSettings, int timeout, Action<Result> action)
        {
            Task task = new Task(() =>
            {
                Result result = Result.UnknownError;

                IPort port = null;

                IPrinterStatus printerStatus;

                try
                {
                    result = Result.GetPortError;

                    port = Port.GetPort(portName, portSettings, timeout);

                    result = Result.BeginCheckedBlockError;

                    printerStatus = port.BeginCheckedBlock();

                    if (printerStatus.Offline)
                    {
                        throw new Exception("Printer is offline (BeginCheckedBlock)");
                    }

                    result = Result.WritePortError;

                    DateTime startDateTime = DateTime.Now;

                    int total = 0;

                    while (true)
                    {
                        int written = port.WritePort(commands, total, commands.Length - total);

                        total += written;

//                      if (total == commands.Length)
                        if (total >= commands.Length)
                        {
                            break;
                        }

                        TimeSpan timeSpan = DateTime.Now - startDateTime;

                        if (timeSpan.TotalMilliseconds >= 30000)     // 30000mS!!!
                        {
                            throw new Exception("Write port timed out");
                        }
                    }

                    result = Result.EndCheckedBlockError;

                    port.EndCheckedBlockTimeoutMillis = 30000;     // 30000mS!!!

                    printerStatus = port.EndCheckedBlock();

                    if (printerStatus.Offline)
                    {
                        throw new Exception("Printer is offline (EndCheckedBlock)");
                    }

                    result = Result.Success;
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }
                finally
                {
                    if (port != null)
                    {
                        Port.ReleasePort(port);

                        port = null;
                    }
                }

                Device.BeginInvokeOnMainThread(() => {
                    action(result);
                });
            });

            task.Start();
        }

        public static void SendCommandsDoNotCheckCondition(byte[] commands, string portName, string portSettings, int timeout, Action<Result> action)
        {
            Task task = new Task(() =>
            {
                Result result = Result.UnknownError;

                IPort port = null;

                IPrinterStatus printerStatus;

                try
                {
                    result = Result.GetPortError;

                    port = Port.GetPort(portName, portSettings, timeout);

                    result = Result.GetParsedStatusError;

                    printerStatus = port.GetParsedStatus();

//                  if (printerStatus.Offline)     // Do not check condition.
//                  {
//                      throw new Exception("Printer is offline (GetParsedStatus)");
//                  }

                    result = Result.WritePortError;

                    DateTime startDateTime = DateTime.Now;

                    int total = 0;

                    while (true)
                    {
                        int written = port.WritePort(commands, total, commands.Length - total);

                        total += written;

//                      if (total == commands.Length)
                        if (total >= commands.Length)
                        {
                            break;
                        }

                        TimeSpan timeSpan = DateTime.Now - startDateTime;

                        if (timeSpan.TotalMilliseconds >= 30000)     // 30000mS!!!
                        {
                            throw new Exception("Write port timed out");
                        }
                    }

                    result = Result.GetParsedStatusError;

                    printerStatus = port.GetParsedStatus();

//                  if (printerStatus.Offline)     // Do not check condition.
//                  {
//                      throw new Exception("Printer is offline (GetParsedStatus)");
//                  }

                    result = Result.Success;
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }
                finally
                {
                    if (port != null)
                    {
                        Port.ReleasePort(port);

                        port = null;
                    }
                }

                Device.BeginInvokeOnMainThread(() => {
                    action(result);
                });
            });

            task.Start();
        }

        public static void GetDeviceStatus(string portName, string portSettings, int timeout, Action<Result, IPrinterStatus> action)
        {
            Task task = new Task(() =>
            {
                Result result = Result.UnknownError;

                IPort port = null;

                IPrinterStatus printerStatus = null;

                try
                {
                    result = Result.GetPortError;

                    port = Port.GetPort(portName, portSettings, timeout);

                    result = Result.GetParsedStatusError;

                    printerStatus = port.GetParsedStatus();

                    result = Result.Success;
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }
                finally
                {
                    if (port != null)
                    {
                        Port.ReleasePort(port);

                        port = null;
                    }
                }

                Device.BeginInvokeOnMainThread(() => {
                    action(result, printerStatus);
                });
            });

            task.Start();
        }

        public static void SearchPrinter(Action<IList<PortInfo>> action)
        {
            Task task = new Task(() =>
            {
                IList<PortInfo> portInfoList = new List<PortInfo>();

                try
                {
                    portInfoList = Port.SearchPrinter();
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }

                Device.BeginInvokeOnMainThread(() => {
                    action(portInfoList);
                });
            });

            task.Start();
        }

        public static void SearchPrinter(string target, Action<IList<PortInfo>> action)
        {
            Task task = new Task(() =>
            {
                IList<PortInfo> portInfoList = new List<PortInfo>();

                try
                {
                    portInfoList = Port.SearchPrinter(target);
                }
                catch (Exception exception)
                {
                    DebugExt.WriteLine(exception.Message);
                }

                Device.BeginInvokeOnMainThread(() => {
                    action(portInfoList);
                });
            });

            task.Start();
        }
    }
}
