#region License
// Copyright (c) 2013 Antonie Blom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Gaming.Graphics {
	public delegate T[] TArrayFromRetrievedData<out T>(Vector4[] vertexs,Vector3[] normals,Vector2[] texCoords);

	public static partial class Gl {
		public static class Utils {
			#region Image Loading

			public static int LoadImage(string path) {
				using (Bitmap bmp = new Bitmap(path)) {
					return LoadImage(bmp);
				}
			}
			public static int LoadImage(string path, bool square) {
				using (Bitmap bmp = new Bitmap(path)) {
					return LoadImage(bmp, square);
				}
			}
			public static int LoadImage(string path, bool square, TextureMinFilter tmin, TextureMagFilter tmag) {
				using (Bitmap bmp = new Bitmap(path)) {
					return LoadImage(bmp, square, tmin, tmag);
				}
			}
			public static int LoadImage(Stream file) {
				using (Bitmap bmp = new Bitmap(file)) {
					return LoadImage(bmp);
				}
			}
			public static int LoadImage(Stream file, bool square) {
				using (Bitmap bmp = new Bitmap(file)) {
					return LoadImage(bmp, square);
				}
			}
			public static int LoadImage(Stream file, bool square, TextureMinFilter tmin, TextureMagFilter tmag) {
				using (Bitmap bmp = new Bitmap(file)) {
					return LoadImage(bmp, square, tmin, tmag);
				}
			}
			public static int LoadImage(Bitmap bmp) {
				return LoadImage(bmp, true, TextureMinFilter.Nearest, TextureMagFilter.Nearest);
			}
			public static int LoadImage(Bitmap bmp, bool square) {
				return LoadImage(bmp, square, TextureMinFilter.Nearest, TextureMagFilter.Nearest);
			}
			public static int LoadImage(Bitmap bmp, bool square, TextureMinFilter tmin, TextureMagFilter tmag) {
				BitmapData bmpData = bmp.LockBits(
					new System.Drawing.Rectangle(Point.Empty, bmp.Size), 
					ImageLockMode.ReadOnly, 
					System.Drawing.Imaging.PixelFormat.Format32bppArgb
				);
				
				int result;
				TextureTarget target = (square ? TextureTarget.Texture2D : TextureTarget.TextureRectangle);

				try {
					Gl.GenTextures(1, out result);
					Gl.BindTexture(target, result);
					Gl.TexParameter(target, TextureParameterName.TextureMagFilter, (int)tmag);
					Gl.TexParameter(target, TextureParameterName.TextureMinFilter, (int)tmin);
					Gl.TexImage2D(
						target, 
						0, 
						PixelInternalFormat.Rgba,
						bmp.Width,
						bmp.Height,
						0,
						Pencil.Gaming.Graphics.PixelFormat.Bgra,
						PixelType.UnsignedByte,
						bmpData.Scan0
					);
					Gl.BindTexture(target, 0);
				} finally {
					bmp.UnlockBits(bmpData);
				}

				return result;
			}

			#endregion

			#region Wavefront Model Loading

			public static float[] FloatArrayFromVerticesNormalsInterleaved(Vector4[] vertices, Vector3[] normals, Vector2[] texCoords) {
				float[] final = new float[vertices.Length * 4 + normals.Length * 3];
				for (int i = 0; i < final.Length; i += 7) {
					Vector4 vertex = vertices[i / 7];
					Vector3 normal = normals[i / 7];
					final[i] = vertex.X;
					final[i + 1] = vertex.Y;
					final[i + 2] = vertex.Z;
					final[i + 3] = vertex.W;
					final[i + 4] = normal.X;
					final[i + 5] = normal.Y;
					final[i + 6] = normal.Z;
				}
				return final;
			}
			public static float[] FloatArrayFromVerticesNormalsTexCoordsInterleaved(Vector4[] vertices, Vector3[] normals, Vector2[] texCoords) {
				float[] final = new float[vertices.Length * 4 + normals.Length * 3 + texCoords.Length * 2];
				for (int i = 0; i < final.Length; i += 9) {
					Vector4 vertex = vertices[i / 9];
					Vector3 normal = normals[i / 9];
					Vector2 texCoord = texCoords[i / 9];
					final[i] = vertex.X;
					final[i + 1] = vertex.Y;
					final[i + 2] = vertex.Z;
					final[i + 3] = vertex.W;
					final[i + 4] = normal.X;
					final[i + 5] = normal.Y;
					final[i + 6] = normal.Z;
					final[i + 7] = texCoord.X;
					final[i + 8] = texCoord.Y;
				}
				return final;
			}
			public static float[] FloatArrayFromVerticesNormals(Vector4[] vertices, Vector3[] normals, Vector2[] texCoords) {
				float[] final = new float[vertices.Length * 4 + normals.Length * 3];
				for (int i = 0; i < vertices.Length * 4; i += 4) {
					Vector4 vertex = vertices[i / 3];
					final[i] = vertex.X;
					final[i + 1] = vertex.Y;
					final[i + 2] = vertex.Z;
					final[i + 3] = vertex.W;
				}
				for (int i = vertices.Length * 4; i < final.Length; i += 3) {
					Vector3 normal = normals[i];
					final[i] = normal.X;
					final[i + 1] = normal.Y;
					final[i + 2] = normal.Z;
				}
				return final;
			}
			public static float[] FloatArrayFromVerticesNormalsTexCoords(Vector4[] vertices, Vector3[] normals, Vector2[] texCoords) {
				float[] final = new float[vertices.Length * 4 + normals.Length * 3 + texCoords.Length * 2];
				for (int i = 0; i < vertices.Length * 4; i += 4) {
					Vector4 vertex = vertices[i / 3];
					final[i] = vertex.X;
					final[i + 1] = vertex.Y;
					final[i + 2] = vertex.Z;
					final[i + 3] = vertex.W;
				}
				for (int i = vertices.Length * 4; i < vertices.Length * 4 + normals.Length * 3; i += 3) {
					Vector3 normal = normals[i];
					final[i] = normal.X;
					final[i + 1] = normal.Y;
					final[i + 2] = normal.Z;
				}
				for (int i = vertices.Length * 4 + normals.Length * 3; i < final.Length; i += 2) {
					Vector2 texCoord = texCoords[i];
					final[i] = texCoord.X;
					final[i + 1] = texCoord.Y;
				}
				return final;
			}

			public static void LoadModel(string path, out Vector4[] verticesOut, out Vector3[] normalsOut, out Vector2[] tCoordsOut, out int[] indicesOut) {
				LoadModel(path, out verticesOut, out normalsOut, out tCoordsOut, out indicesOut, true);
			}
			public static void LoadModel(string path, out Vector4[] verticesOut, out Vector3[] normalsOut, out Vector2[] tCoordsOut, out int[] indicesOut, bool optimize) {
				using (Stream str = File.OpenRead(path)) {
					LoadModel(str, out verticesOut, out normalsOut, out tCoordsOut, out indicesOut, optimize);
				}
			}
			public static void LoadModel(Stream file, out Vector4[] verticesOut, out Vector3[] normalsOut, out Vector2[] tCoordsOut, out int[] indicesOut) {
				LoadModel(file, out verticesOut, out normalsOut, out tCoordsOut, out indicesOut, true);
			}
			public static void LoadModel<T>(string path, out int[] indicesOutArr, out T[] outArr, TArrayFromRetrievedData<T> func) {
				using (Stream str = File.OpenRead(path)) {
					LoadModel<T>(str, out indicesOutArr, out outArr, func, true);
				}
			}
			public static void LoadModel<T>(string path, out int[] indicesOutArr, out T[] outArr, TArrayFromRetrievedData<T> func, bool optimize) {
				using (Stream str = File.OpenRead(path)) {
					LoadModel<T>(str, out indicesOutArr, out outArr, func, optimize);
				}
			}
			public static void LoadModel<T>(Stream file, out int[] indicesOutArr, out T[] outArr, TArrayFromRetrievedData<T> func) {
				LoadModel<T>(file, out indicesOutArr, out outArr, func, true);
			}
			public static void LoadModel<T>(Stream file, out int[] indicesOutArr, out T[] outArr, TArrayFromRetrievedData<T> func, bool optimize) {
				Vector4[] vertices;
				Vector3[] normals;
				Vector2[] texCoords;
				Gl.Utils.LoadModel(file, out vertices, out normals, out texCoords, out indicesOutArr, optimize);
				outArr = func(vertices, normals, texCoords);
			}
			public static void LoadModel(Stream file, out Vector4[] verticesOutArr, out Vector3[] normalsOutArr, out Vector2[] tCoordsOutArr, out int[] indicesOutArr, bool optimize) {
				List<Vector4> vertices = new List<Vector4>(1024);
				List<Vector3> normals = new List<Vector3>(1024);
				List<Vector2> tCoords = new List<Vector2>(1024);

				List<Vector4> verticesOut;
				List<Vector3> normalsOut;
				List<Vector2> tCoordsOut;
				List<int> indicesOut;

				using (StreamReader sread = new StreamReader(file)) {
					List<Face> faces = new List<Face>(1024);

#if DEBUG
					Stopwatch sw = new Stopwatch();
					sw.Start();
#endif
					string line;
					while ((line = sread.ReadLine()) != null) {
						ParseObjLine(line, vertices, normals, tCoords, faces);
					}
#if DEBUG
					sw.Stop();
					Console.WriteLine("Parsing model took: {0} milliseconds", sw.ElapsedMilliseconds);

					sw.Reset();
					sw.Start();
#endif
					List<VertexIndices> vIndices = VIndicesFromFaces(faces);
					SortOutVIndices(vertices, out verticesOut, normals, out normalsOut, tCoords, out tCoordsOut, out indicesOut, vIndices, optimize);
#if DEBUG
					sw.Stop();
					Console.WriteLine("Optimizing/expanding model vertices took: {0} milliseconds", sw.ElapsedMilliseconds);
#endif
				}

#if DEBUG
				Stopwatch swatch = new Stopwatch();
				swatch.Start();
#endif
				verticesOutArr = verticesOut.ToArray();
				normalsOutArr = normalsOut.ToArray();
				tCoordsOutArr = tCoordsOut.ToArray();
				indicesOutArr = indicesOut.ToArray();
#if DEBUG
				swatch.Stop();
				Console.WriteLine("Converting model lists to arrays took: {0} milliseconds", swatch.ElapsedMilliseconds);
#endif
			}

			#pragma warning disable 0661
			#pragma warning disable 0659

			internal struct VertexIndices {
				public int Vertex;
				public int? TexCoord;
				public int? Normal;
				public int FinalIndex;

				public VertexIndices(VertexIndices previous, int finalIndex) {
					Vertex = previous.Vertex;
					TexCoord = previous.TexCoord;
					Normal = previous.Normal;
					FinalIndex = finalIndex;
				}

				public VertexIndices(int vertex, int? texCoord, int? normal) {
					Vertex = vertex;
					TexCoord = texCoord;
					Normal = normal;
					FinalIndex = -1;
				}

				public override bool Equals(object obj) {
					return (this == (VertexIndices)obj);
				}

				public static bool operator ==(VertexIndices @this, VertexIndices other) {
					return (@this.Normal == other.Normal && @this.TexCoord == other.TexCoord && @this.Vertex == other.Vertex);
				}

				public static bool operator !=(VertexIndices @this, VertexIndices other) {
					return !(@this == other);
				}
			}

			#pragma warning restore 0661
			#pragma warning restore 0659

			internal struct Face {
				public List<VertexIndices> Vertices;

				public Face(List<VertexIndices> vertices) {
					Vertices = vertices;
				}
			}

			private static List<VertexIndices> VIndicesFromFaces(List<Face> faces) {
				List<VertexIndices> result = new List<VertexIndices>(faces.Count * 3);
				for (int i = 0; i < faces.Count; ++i) {
					Face face = faces[i];
					for (int j = 0; j < face.Vertices.Count; ++j) {
						result.Add(face.Vertices[j]);
					}
				}
				return result;
			}

			private static int GetFirstFinalIndexOfDuplicate(List<VertexIndices> vIndices, int currentIndex, bool optimize) {
				if (!optimize) {
					return -1;
				}

				VertexIndices vertex = vIndices[currentIndex];
				for (int i = 0; i < currentIndex; ++i) {
					VertexIndices other = vIndices[i];
					if (vertex == other) {
						return other.FinalIndex;
					}
				}
			}

			private static void SortOutVIndices(
				List<Vector4> verticesIn, 
				out List<Vector4> verticesOut, 
				List<Vector3> normalsIn, 
				out List<Vector3> normalsOut, 
				List<Vector2> tCoordsIn,
				out List<Vector2> tCoordsOut,
				out List<int> indicesOut,
				List<VertexIndices> vIndices,
				bool optimize) {

				verticesOut = new List<Vector4>(verticesIn.Count);
				normalsOut = new List<Vector3>(normalsIn.Count);
				tCoordsOut = new List<Vector2>(tCoordsIn.Count);
				indicesOut = new List<int>(verticesIn.Count);

				for (int i = 0; i < vIndices.Count; ++i) {
					VertexIndices vertex = vIndices[i];

					int firstFinalIndex = GetFirstFinalIndexOfDuplicate(vIndices, i, optimize);

					if (firstFinalIndex == -1) {
						vIndices[i] = new VertexIndices(vertex, verticesOut.Count);

						indicesOut.Add(verticesOut.Count);
						verticesOut.Add(verticesIn[vertex.Vertex - 1]);

						if (vertex.TexCoord.HasValue) {
							tCoordsOut.Add(tCoordsIn[vertex.TexCoord.Value - 1]);
						}
						if (vertex.Normal.HasValue) {
							normalsOut.Add(normalsIn[vertex.Normal.Value - 1]);
						}
					} else {
						indicesOut.Add(firstFinalIndex);
					}
				}
			}


			private static void ParseVElement(string line, List<Vector4> vertices) {
				string verticesString = line.Substring(2);
				string[] elements = verticesString.Split(' ');
				switch (elements.Length) {
				case 3:
					vertices.Add(new Vector4(float.Parse(elements[0]), float.Parse(elements[1]), float.Parse(elements[2]), 1f));
					break;
				case 4:
					vertices.Add(new Vector4(float.Parse(elements[0]), float.Parse(elements[1]), float.Parse(elements[2]), float.Parse(elements[3])));
					break;
				default:
					throw new AssetLoadException("model", "vertices can only have 3 or 4 elements");
				}
			}
			private static void ParseVNElement(string line, List<Vector3> normals) {
				Vector3 result = Vector3.Zero;

				string elementsString = line.Substring(3);
				string[] elements = elementsString.Split(' ');
				if (elements.Length != 3) {
					throw new AssetLoadException("model", "normals must define 3 elements");
				}

				result = Vector3.Normalize(new Vector3(float.Parse(elements[0]), float.Parse(elements[1]), float.Parse(elements[2])));
				normals.Add(result);
			}
			private static void ParseVTElement(string line, List<Vector2> tCoords) {
				Vector2 result = Vector2.Zero;

				string elementsString = line.Substring(3);
				string[] elements = elementsString.Split(' ');
				if (elements.Length == 3) {
					Console.WriteLine("WARNING: Object file specifies third texture coordinate, ignored");
				} else if (elements.Length != 2) {
					throw new AssetLoadException("model", "texture coordinates must define either 3 or 4 elements");
				}

				result = new Vector2(float.Parse(elements[0]), float.Parse(elements[1]));
				tCoords.Add(result);
			}
			private static void ParseFElement(string line, List<Face> faces) {
				Face result = new Face();

				string elementsString = line.Substring(2);
				string[] elements = elementsString.Split(' ');
				List<VertexIndices> vIndices = new List<VertexIndices>(elements.Length);
				foreach (string element in elements) {
					vIndices.Add(ParseVertexIndices(element));
				}

				result.Vertices = vIndices;
				faces.Add(result);
			}
			private static VertexIndices ParseVertexIndices(string element) {
				int count = 0;
				foreach (char ch in element) {
					if (ch == '/') {
						++count;
					}
				}
				VertexIndices result = new VertexIndices();

				if (element.Contains("//")) {
					string[] vertexNormal = element.Split(new [] { "//" }, StringSplitOptions.None);
					result.Vertex = int.Parse(vertexNormal[0]);
					result.Normal = int.Parse(vertexNormal[1]);
				} else if (count == 1) {
					string[] vertexTCoord = element.Split('/');
					result.Vertex = int.Parse(vertexTCoord[0]);
					result.TexCoord = int.Parse(vertexTCoord[1]);
				} else if (count == 2) {
					string[] vertexTCoordNormal = element.Split('/');
					result.Vertex = int.Parse(vertexTCoordNormal[0]);
					result.TexCoord = int.Parse(vertexTCoordNormal[1]);
					result.Normal = int.Parse(vertexTCoordNormal[2]);
				} else {
					throw new AssetLoadException("model", "texture face element declaration incorrect");
				}

				return result;
			}
			private static void ParseObjLine(string line, List<Vector4> vertices, List<Vector3> normals, List<Vector2> tCoords, List<Face> faces) {
				if (line.StartsWith("v ")) {
					ParseVElement(line, vertices);
				} else if (line.StartsWith("vn ")) {
					ParseVNElement(line, normals);
				} else if (line.StartsWith("vt ")) {
					ParseVTElement(line, tCoords);
				} else if (line.StartsWith("f ")) {
					ParseFElement(line, faces);
				} else if (!line.StartsWith("#")) {
					
				}
			}
#endregion
		}
	}
}

