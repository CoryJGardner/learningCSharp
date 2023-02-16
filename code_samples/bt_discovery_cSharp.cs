using InTheHand.Net.Bluetooth;

public class bt_discovery
{
    public static void Main(string[] args)
    {
        // bt discovery
        var client = new BluetoothClient();
        var devices = client.DiscoverDevices();

        // print discovered devices
        foreach (var device in devices)
        {
            Console.WriteLine($"{device.DeviceAddress} ({device.DeviceName})");
        }
    }
}

