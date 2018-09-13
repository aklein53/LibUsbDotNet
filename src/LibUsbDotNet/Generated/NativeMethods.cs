//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2018 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//

using System;
using System.Runtime.InteropServices;

namespace LibUsbDotNet
{
    internal static partial class NativeMethods
    {
#if WIN || NET45 || WIN7_X64 // win7-x64 during testing only.
        internal const string LibUsbNativeLibrary = "libusb-1.0.dll";
        internal const CallingConvention LibUsbCallingConvention = CallingConvention.StdCall;
#endif
#if LINUX || UBUNTU || UBUNTU_16_04_X64 || UBUNTU_16_04_ARM64 // ubuntu during testing only.
        internal const string LibUsbNativeLibrary = "libusb-1.0.so";
        internal const CallingConvention LibUsbCallingConvention = CallingConvention.Cdecl;
#endif
#if OSX || OSX_10_12_X64 // osx during testing only
        internal const string LibUsbNativeLibrary = "libusb-1.0.dylib";
        internal const CallingConvention LibUsbCallingConvention = CallingConvention.Cdecl;
#endif

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_init")]
        public static extern int Init(ref IntPtr ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_exit")]
        public static extern void Exit(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_set_debug")]
        public static extern void SetDebug(NativeContext ctx, int level);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_version")]
        public static extern IntPtr GetVersion();

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_has_capability")]
        public static extern int HasCapability(uint capability);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_error_name")]
        public static extern IntPtr ErrorName(int errcode);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_setlocale")]
        public static extern int SetLocale(IntPtr locale);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_strerror")]
        public static extern IntPtr StrError(Error errcode);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_device_list")]
        public static extern long GetDeviceList(NativeContext ctx, ref IntPtr list);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_device_list")]
        public static extern void FreeDeviceList(ref IntPtr list, int unrefDevices);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_ref_device")]
        public static extern NativeDevice RefDevice(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_unref_device")]
        public static extern void UnrefDevice(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_configuration")]
        public static extern int GetConfiguration(NativeDeviceHandle dev, ref int config);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_device_descriptor")]
        public static extern int GetDeviceDescriptor(NativeDevice dev, IntPtr desc);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_active_config_descriptor")]
        public static extern int GetActiveConfigDescriptor(NativeDevice dev, ref IntPtr config);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_config_descriptor")]
        public static extern int GetConfigDescriptor(NativeDevice dev, char configIndex, ref IntPtr config);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_config_descriptor_by_value")]
        public static extern int GetConfigDescriptorByValue(NativeDevice dev, char bconfigurationvalue, ref IntPtr config);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_config_descriptor")]
        public static extern void FreeConfigDescriptor(IntPtr config);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_ss_endpoint_companion_descriptor")]
        public static extern int GetSsEndpointCompanionDescriptor(IntPtr ctx, IntPtr endpoint, ref IntPtr epComp);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_ss_endpoint_companion_descriptor")]
        public static extern void FreeSsEndpointCompanionDescriptor(IntPtr epComp);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_bos_descriptor")]
        public static extern int GetBosDescriptor(NativeDeviceHandle devHandle, ref IntPtr bos);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_bos_descriptor")]
        public static extern void FreeBosDescriptor(IntPtr bos);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_usb_2_0_extension_descriptor")]
        public static extern int GetUsb20ExtensionDescriptor(IntPtr ctx, IntPtr devCap, ref IntPtr usb20Extension);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_usb_2_0_extension_descriptor")]
        public static extern void FreeUsb20ExtensionDescriptor(IntPtr usb20Extension);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_ss_usb_device_capability_descriptor")]
        public static extern int GetSsUsbDeviceCapabilityDescriptor(IntPtr ctx, IntPtr devCap, ref IntPtr ssUsbDeviceCap);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_ss_usb_device_capability_descriptor")]
        public static extern void FreeSsUsbDeviceCapabilityDescriptor(IntPtr ssUsbDeviceCap);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_container_id_descriptor")]
        public static extern int GetContainerIdDescriptor(IntPtr ctx, IntPtr devCap, ref IntPtr containerId);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_container_id_descriptor")]
        public static extern void FreeContainerIdDescriptor(IntPtr containerId);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_bus_number")]
        public static extern char GetBusNumber(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_port_number")]
        public static extern char GetPortNumber(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_port_numbers")]
        public static extern int GetPortNumbers(NativeDevice dev, ref byte portNumbers, int portNumbersLen);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_port_path")]
        public static extern int GetPortPath(NativeContext ctx, NativeDevice dev, ref byte path, char pathLength);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_parent")]
        public static extern NativeDevice GetParent(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_device_address")]
        public static extern char GetDeviceAddress(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_device_speed")]
        public static extern int GetDeviceSpeed(NativeDevice dev);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_max_packet_size")]
        public static extern int GetMaxPacketSize(NativeDevice dev, char endpoint);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_max_iso_packet_size")]
        public static extern int GetMaxIsoPacketSize(NativeDevice dev, char endpoint);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_open")]
        public static extern int Open(NativeDevice dev, ref IntPtr devHandle);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_close")]
        public static extern void Close(NativeDeviceHandle devHandle);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_device")]
        public static extern NativeDevice GetDevice(NativeDeviceHandle devHandle);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_set_configuration")]
        public static extern int SetConfiguration(NativeDeviceHandle devHandle, int configuration);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_claim_interface")]
        public static extern int ClaimInterface(NativeDeviceHandle devHandle, int interfaceNumber);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_release_interface")]
        public static extern int ReleaseInterface(NativeDeviceHandle devHandle, int interfaceNumber);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_open_device_with_vid_pid")]
        public static extern NativeDeviceHandle OpenDeviceWithVidPid(NativeContext ctx, ushort vendorId, ushort productId);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_set_interface_alt_setting")]
        public static extern int SetInterfaceAltSetting(NativeDeviceHandle devHandle, int interfaceNumber, int alternateSetting);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_clear_halt")]
        public static extern int ClearHalt(NativeDeviceHandle devHandle, char endpoint);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_reset_device")]
        public static extern int ResetDevice(NativeDeviceHandle devHandle);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_alloc_streams")]
        public static extern int AllocStreams(NativeDeviceHandle devHandle, uint numStreams, IntPtr endpoints, int numEndpoints);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_streams")]
        public static extern int FreeStreams(NativeDeviceHandle devHandle, IntPtr endpoints, int numEndpoints);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_dev_mem_alloc")]
        public static extern IntPtr DevMemAlloc(NativeDeviceHandle devHandle, ulong length);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_dev_mem_free")]
        public static extern int DevMemFree(NativeDeviceHandle devHandle, IntPtr buffer, ulong length);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_kernel_driver_active")]
        public static extern int KernelDriverActive(NativeDeviceHandle devHandle, int interfaceNumber);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_detach_kernel_driver")]
        public static extern int DetachKernelDriver(NativeDeviceHandle devHandle, int interfaceNumber);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_attach_kernel_driver")]
        public static extern int AttachKernelDriver(NativeDeviceHandle devHandle, int interfaceNumber);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_set_auto_detach_kernel_driver")]
        public static extern int SetAutoDetachKernelDriver(NativeDeviceHandle devHandle, int enable);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_alloc_transfer")]
        public static extern IntPtr AllocTransfer(int isoPackets);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_submit_transfer")]
        public static extern int SubmitTransfer(IntPtr transfer);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_cancel_transfer")]
        public static extern int CancelTransfer(IntPtr transfer);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_transfer")]
        public static extern void FreeTransfer(IntPtr transfer);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_transfer_set_stream_id")]
        public static extern void TransferSetStreamId(IntPtr transfer, uint streamId);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_transfer_get_stream_id")]
        public static extern uint TransferGetStreamId(IntPtr transfer);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_control_transfer")]
        public static extern int ControlTransfer(NativeDeviceHandle devHandle, char requestType, char brequest, ushort wvalue, ushort windex, IntPtr data, ushort wlength, uint timeout);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_bulk_transfer")]
        public static extern int BulkTransfer(NativeDeviceHandle devHandle, char endpoint, IntPtr data, int length, ref int actualLength, uint timeout);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_interrupt_transfer")]
        public static extern int InterruptTransfer(NativeDeviceHandle devHandle, char endpoint, IntPtr data, int length, ref int actualLength, uint timeout);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_string_descriptor_ascii")]
        public static extern int GetStringDescriptorAscii(NativeDeviceHandle devHandle, char descIndex, IntPtr data, int length);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_try_lock_events")]
        public static extern int TryLockEvents(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_lock_events")]
        public static extern void LockEvents(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_unlock_events")]
        public static extern void UnlockEvents(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_event_handling_ok")]
        public static extern int EventHandlingOk(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_event_handler_active")]
        public static extern int EventHandlerActive(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_interrupt_event_handler")]
        public static extern void InterruptEventHandler(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_lock_event_waiters")]
        public static extern void LockEventWaiters(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_unlock_event_waiters")]
        public static extern void UnlockEventWaiters(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_wait_for_event")]
        public static extern int WaitForEvent(NativeContext ctx, IntPtr tv);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_handle_events_timeout")]
        public static extern int HandleEventsTimeout(NativeContext ctx, IntPtr tv);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_handle_events_timeout_completed")]
        public static extern int HandleEventsTimeoutCompleted(NativeContext ctx, IntPtr tv, ref int completed);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_handle_events")]
        public static extern int HandleEvents(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_handle_events_completed")]
        public static extern int HandleEventsCompleted(NativeContext ctx, ref int completed);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_handle_events_locked")]
        public static extern int HandleEventsLocked(NativeContext ctx, IntPtr tv);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_pollfds_handle_timeouts")]
        public static extern int PollfdsHandleTimeouts(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_next_timeout")]
        public static extern int GetNextTimeout(NativeContext ctx, IntPtr tv);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_get_pollfds")]
        public static extern ref IntPtr GetPollfds(NativeContext ctx);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_free_pollfds")]
        public static extern void FreePollfds(ref IntPtr pollfds);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_set_pollfd_notifiers")]
        public static extern void SetPollfdNotifiers(NativeContext ctx, IntPtr addedDelegate, IntPtr removedDelegate, IntPtr userData);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_hotplug_register_callback")]
        public static extern int HotplugRegisterCallback(NativeContext ctx, HotplugEvent events, HotplugFlag flags, int vendorId, int productId, int devClass, IntPtr Delegate, IntPtr userData, ref int callbackHandle);

        [DllImport(LibUsbNativeLibrary, CallingConvention = LibUsbCallingConvention, EntryPoint = "libusb_hotplug_deregister_callback")]
        public static extern void HotplugDeregisterCallback(NativeContext ctx, int callbackHandle);

    }
}
