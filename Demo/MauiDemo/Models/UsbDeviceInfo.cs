using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiDemo.Models;

public partial class UsbDeviceInfo : ObservableObject
{
    [ObservableProperty] public partial int VendorId { get; set; }
    [ObservableProperty] public partial string? SerialNumber { get; set; }
    [ObservableProperty] public partial string? ProductName { get; set; }
    [ObservableProperty] public partial int ProductId { get; set; }
    [ObservableProperty] public partial string? ManufacturerName { get; set; }
    [ObservableProperty] public partial int InterfaceCount { get; set; }
    [ObservableProperty] public partial int DeviceProtocol { get; set; }
    [ObservableProperty] public partial string? DeviceName { get; set; }
    [ObservableProperty] public partial int DeviceId { get; set; }
    [ObservableProperty] public partial int ConfigurationCount { get; set; }
    [ObservableProperty] public partial string? Version { get; set; }
}