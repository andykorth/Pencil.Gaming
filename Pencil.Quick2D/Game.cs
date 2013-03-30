using System;
using System.Collections.Generic;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public class Game : IDisposable {
        public Camera Camera { get; set; }
        public float Speed { get; set; }
        public int Width {
            get {
                int width, height;
                Glfw.GetWindowSize(out width, out height);
                return width;
            }
            set {
                Glfw.SetWindowSize(value, Height);
            }
        }
        public int Height {
            get {
                int width, height;
                Glfw.GetWindowSize(out width, out height);
                return height;
            }
            set {
                Glfw.SetWindowSize(Width, value);
            }
        }
        public Vector2i Size {
            get {
                int width, height;
                Glfw.GetWindowSize(out width, out height);
                return new Vector2i(width, height);
            }
            set {
                Glfw.SetWindowSize(value.X, value.Y);
            }
        }
        public Vector2 Center {
            get {
                Vector2i vec = Size;
                return new Vector2(vec.X / 2f, vec.Y / 2f);
            }
        }
        public Color4 Background { get; set; }
        public float TotalElapsedTime { get; private set; }

        private Graphics graphics;

        private List<IDisposable> resources = new List<IDisposable>();

        public Game(int width, int height, string title, int aa) {
            Glfw.Init();

            Glfw.OpenWindowHint(OpenWindowHint.FSAASamples, aa);
            Glfw.OpenWindow(width, height, 8, 8, 8, 0, 0, 0, WindowMode.Window);
            Glfw.SetWindowTitle(title);

            Width = width;
            Height = height;
            Speed = 1f;
            Camera = Camera.Default;

            graphics = new DirectModeGraphics(this);

            Glfw.SetWindowSizeCallback(Resized);

            Gl.Enable(EnableCap.TextureRectangle);
            Gl.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            Gl.Enable(EnableCap.Blend);

            LoadContent();
            Initialize();
        }
        public Game(int width, int height, string title) : this(width, height, title, 0) {
        }
        public Game(int width, int height) : this(width, height, string.Empty) {
        }
        public Game() : this(800, 600) {
        }

        public void RegisterResource(IDisposable disposable) {
            resources.Add(disposable);
        }

        private void ReleaseRegisteredResources() {
            foreach (IDisposable idis in resources) {
                if (idis != null) {
                    idis.Dispose();
                }
            }
        }

        public void Run() {
            while (Glfw.GetWindowParam(WindowParam.Opened) == 1) {
                float time = (float)Glfw.GetTime();
                Glfw.SetTime(0.0);

                Tick(time);
                graphics.SwapBuffers();
            }

            ReleaseRegisteredResources();
            UnloadContent();
        }

        protected virtual void Resized(int width, int height) {
            graphics.Resize(width, height);
        }

        private void Tick(float time) {
            float timeWithSpeed = time * Speed;
            TotalElapsedTime += timeWithSpeed;

            Camera.Update(this);

            Update(timeWithSpeed);

            graphics.TimeDelta = timeWithSpeed;
            graphics.Clear(Background);
            Render(graphics);
        }

        protected virtual void Initialize() {
        }

        protected virtual void LoadContent() {
        }

        protected virtual void UnloadContent() {
        }

        protected virtual void Update(float time) {
        }

        protected virtual void Render(Graphics g) {
        }

        public void Dispose() {
            UnloadContent();
            Glfw.Terminate();
        }
    }
}
