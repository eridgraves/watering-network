// WateringServer
// Backend server. Controller for WateringNodes, should run on an x86 based machine with wifi or BLE support. Each Node is an Arduino or ESP32 controlling one or more pumps that water plants.
// The controller provides RPC over wifi or BLE-based control and monitoring of the nodes. On BLE master can control up to 20 slave devices.

using System;

namespace WateringServer 
{
    internal class WateringMonitor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}