using System;

namespace Pencil.Gaming {
    public delegate void GlfwWindowSizeFun(int width,int height);
    public delegate int  GlfwWindowCloseFun();
    public delegate void GlfwWindowRefreshFun();
    public delegate void GlfwMouseButtonFun(MouseButton btn,Keystate state);
    public delegate void GlfwMousePosFun(int x,int y);
    public delegate void GlfwMouseWheelFun(int state);
    public delegate void GlfwKeyFun(Key key,Keystate state);
    public delegate void GlfwCharFun(char ch,Keystate state);
}

