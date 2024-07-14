﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_server_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, void> _on_server_created;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, void> _on_server_destroyed;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, int, void> _on_client_connected;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, int, void> _on_client_disconnected;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, int, cef_string_t*, cef_request_t*, void> _on_http_request;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, int, cef_string_t*, cef_request_t*, cef_callback_t*, void> _on_web_socket_request;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, int, void> _on_web_socket_connected;
        internal delegate* unmanaged<cef_server_handler_t*, cef_server_t*, int, void*, UIntPtr, void> _on_web_socket_message;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_server_handler_t* self)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_server_handler_t* self)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_server_handler_t* self)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_server_handler_t* self)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static void on_server_created(cef_server_handler_t* self, cef_server_t* server)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_server_created(self, server);
        }
        
        [UnmanagedCallersOnly]
        public static void on_server_destroyed(cef_server_handler_t* self, cef_server_t* server)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_server_destroyed(self, server);
        }
        
        [UnmanagedCallersOnly]
        public static void on_client_connected(cef_server_handler_t* self, cef_server_t* server, int connection_id)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_client_connected(self, server, connection_id);
        }
        
        [UnmanagedCallersOnly]
        public static void on_client_disconnected(cef_server_handler_t* self, cef_server_t* server, int connection_id)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_client_disconnected(self, server, connection_id);
        }
        
        [UnmanagedCallersOnly]
        public static void on_http_request(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_http_request(self, server, connection_id, client_address, request);
        }
        
        [UnmanagedCallersOnly]
        public static void on_web_socket_request(cef_server_handler_t* self, cef_server_t* server, int connection_id, cef_string_t* client_address, cef_request_t* request, cef_callback_t* callback)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_web_socket_request(self, server, connection_id, client_address, request, callback);
        }
        
        [UnmanagedCallersOnly]
        public static void on_web_socket_connected(cef_server_handler_t* self, cef_server_t* server, int connection_id)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_web_socket_connected(self, server, connection_id);
        }
        
        [UnmanagedCallersOnly]
        public static void on_web_socket_message(cef_server_handler_t* self, cef_server_t* server, int connection_id, void* data, UIntPtr data_size)
        {
            var obj = (CefServerHandler)self->_obj.Target;
            obj.on_web_socket_message(self, server, connection_id, data, data_size);
        }
        
        internal static cef_server_handler_t* Alloc(CefServerHandler obj)
        {
            var ptr = (cef_server_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_server_handler_t));
            *ptr = default(cef_server_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_server_handler_t);
            ptr->_obj = GCHandle.Alloc(obj);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_server_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_server_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_server_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_server_handler_t*, int>)&has_at_least_one_ref;
            ptr->_on_server_created = &on_server_created;
            ptr->_on_server_destroyed = &on_server_destroyed;
            ptr->_on_client_connected = &on_client_connected;
            ptr->_on_client_disconnected = &on_client_disconnected;
            ptr->_on_http_request = &on_http_request;
            ptr->_on_web_socket_request = &on_web_socket_request;
            ptr->_on_web_socket_connected = &on_web_socket_connected;
            ptr->_on_web_socket_message = &on_web_socket_message;
            return ptr;
        }
        
        internal static void Free(cef_server_handler_t* ptr)
        {
            ptr->_obj.Free();
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
