#if USE_GLFW3
using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    public delegate void GlfwErrorFun(GlfwError code,[MarshalAs(UnmanagedType.LPStr)] string desc);
    public delegate void GlfwMonitorFun(GlfwMonitorPtr mtor,ConnectionState @enum);
    public delegate void GlfwWindowCloseFun(GlfwWindowPtr wnd);
    public delegate void GlfwWindowPosFun(GlfwWindowPtr wnd,int x,int y);
    public delegate void GlfwWindowRefreshFun(GlfwWindowPtr wnd);
    public delegate void GlfwWindowSizeFun(GlfwWindowPtr wnd,int width,int height);
    public delegate void GlfwWindowFocusFun(GlfwWindowPtr wnd,bool focus);
    public delegate void GlfwKeyFun(GlfwWindowPtr wnd,Key key,KeyAction action);
    public delegate void GlfwCharFun(GlfwWindowPtr wnd,char ch);
    public delegate void GlfwMouseButtonFun(GlfwWindowPtr wnd,MouseButton btn,KeyAction action);
    public delegate void GlfwWindowIconifyFun(GlfwWindowPtr wnd,bool iconify);
    public delegate void GlfwCursorPosFun(GlfwWindowPtr wnd,int x,int y);
    public delegate void GlfwCursorEnterFun(GlfwWindowPtr wnd,bool enter);
    public delegate void GlfwScrollFun(GlfwWindowPtr wnd,double xoffset,double yoffset);
}

#endif