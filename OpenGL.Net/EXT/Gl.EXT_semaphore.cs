
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

// ReSharper disable RedundantUsingDirective
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

// ReSharper disable InconsistentNaming
// ReSharper disable JoinDeclarationAndInitializer

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_NUM_DEVICE_UUIDS_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int NUM_DEVICE_UUIDS_EXT = 0x9596;

		/// <summary>
		/// [GL] Value of GL_DEVICE_UUID_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int DEVICE_UUID_EXT = 0x9597;

		/// <summary>
		/// [GL] Value of GL_DRIVER_UUID_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int DRIVER_UUID_EXT = 0x9598;

		/// <summary>
		/// [GL] Value of GL_UUID_SIZE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int UUID_SIZE_EXT = 16;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_GENERAL_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_GENERAL_EXT = 0x958D;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_COLOR_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_COLOR_ATTACHMENT_EXT = 0x958E;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT = 0x958F;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT = 0x9590;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_SHADER_READ_ONLY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_SHADER_READ_ONLY_EXT = 0x9591;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_TRANSFER_SRC_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_TRANSFER_SRC_EXT = 0x9592;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_TRANSFER_DST_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_TRANSFER_DST_EXT = 0x9593;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT = 0x9530;

		/// <summary>
		/// [GL] Value of GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public const int LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT = 0x9531;

		/// <summary>
		/// [GL] glGetUnsignedBytevEXT: Binding for glGetUnsignedBytevEXT.
		/// </summary>
		/// <param name="pname">
		/// A <see cref="T:GetPName"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GetUnsignedBytevEXT(GetPName pname, [Out] byte[] data)
		{
			unsafe {
				fixed (byte* p_data = data)
				{
					Debug.Assert(Delegates.pglGetUnsignedBytevEXT != null, "pglGetUnsignedBytevEXT not implemented");
					Delegates.pglGetUnsignedBytevEXT((int)pname, p_data);
					LogCommand("glGetUnsignedBytevEXT", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetUnsignedBytei_vEXT: Binding for glGetUnsignedBytei_vEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="data">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GetUnsignedBytei_vEXT(int target, uint index, [Out] byte[] data)
		{
			unsafe {
				fixed (byte* p_data = data)
				{
					Debug.Assert(Delegates.pglGetUnsignedBytei_vEXT != null, "pglGetUnsignedBytei_vEXT not implemented");
					Delegates.pglGetUnsignedBytei_vEXT(target, index, p_data);
					LogCommand("glGetUnsignedBytei_vEXT", null, target, index, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenSemaphoresEXT: Binding for glGenSemaphoresEXT.
		/// </summary>
		/// <param name="semaphores">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GenSemaphoreEXT(uint[] semaphores)
		{
			unsafe {
				fixed (uint* p_semaphores = semaphores)
				{
					Debug.Assert(Delegates.pglGenSemaphoresEXT != null, "pglGenSemaphoresEXT not implemented");
					Delegates.pglGenSemaphoresEXT(semaphores.Length, p_semaphores);
					LogCommand("glGenSemaphoresEXT", null, semaphores.Length, semaphores					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGenSemaphoresEXT: Binding for glGenSemaphoresEXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static uint GenSemaphoreEXT()
		{
			uint retValue;
			unsafe {
				Delegates.pglGenSemaphoresEXT(1, &retValue);
				LogCommand("glGenSemaphoresEXT", null, 1, "{ " + retValue + " }"				);
			}
			DebugCheckErrors(null);
			return (retValue);
		}

		/// <summary>
		/// [GL] glDeleteSemaphoresEXT: Binding for glDeleteSemaphoresEXT.
		/// </summary>
		/// <param name="semaphores">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void DeleteSemaphoreEXT(uint[] semaphores)
		{
			unsafe {
				fixed (uint* p_semaphores = semaphores)
				{
					Debug.Assert(Delegates.pglDeleteSemaphoresEXT != null, "pglDeleteSemaphoresEXT not implemented");
					Delegates.pglDeleteSemaphoresEXT(semaphores.Length, p_semaphores);
					LogCommand("glDeleteSemaphoresEXT", null, semaphores.Length, semaphores					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glIsSemaphoreEXT: Binding for glIsSemaphoreEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:uint"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static bool IsSemaphoreEXT(uint semaphore)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsSemaphoreEXT != null, "pglIsSemaphoreEXT not implemented");
			retValue = Delegates.pglIsSemaphoreEXT(semaphore);
			LogCommand("glIsSemaphoreEXT", retValue, semaphore			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// [GL] glSemaphoreParameterui64vEXT: Binding for glSemaphoreParameterui64vEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:SemaphoreParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void SemaphoreParameterEXT(uint semaphore, SemaphoreParameterName pname, ulong[] @params)
		{
			unsafe {
				fixed (ulong* p_params = @params)
				{
					Debug.Assert(Delegates.pglSemaphoreParameterui64vEXT != null, "pglSemaphoreParameterui64vEXT not implemented");
					Delegates.pglSemaphoreParameterui64vEXT(semaphore, (int)pname, p_params);
					LogCommand("glSemaphoreParameterui64vEXT", null, semaphore, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetSemaphoreParameterui64vEXT: Binding for glGetSemaphoreParameterui64vEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:SemaphoreParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:ulong[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void GetSemaphoreParameterEXT(uint semaphore, SemaphoreParameterName pname, [Out] ulong[] @params)
		{
			unsafe {
				fixed (ulong* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetSemaphoreParameterui64vEXT != null, "pglGetSemaphoreParameterui64vEXT not implemented");
					Delegates.pglGetSemaphoreParameterui64vEXT(semaphore, (int)pname, p_params);
					LogCommand("glGetSemaphoreParameterui64vEXT", null, semaphore, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glWaitSemaphoreEXT: Binding for glWaitSemaphoreEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numBufferBarriers">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="numTextureBarriers">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="srcLayouts">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void WaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint[] buffers, uint numTextureBarriers, uint[] textures, int[] srcLayouts)
		{
			unsafe {
				fixed (uint* p_buffers = buffers)
				fixed (uint* p_textures = textures)
				fixed (int* p_srcLayouts = srcLayouts)
				{
					Debug.Assert(Delegates.pglWaitSemaphoreEXT != null, "pglWaitSemaphoreEXT not implemented");
					Delegates.pglWaitSemaphoreEXT(semaphore, numBufferBarriers, p_buffers, numTextureBarriers, p_textures, p_srcLayouts);
					LogCommand("glWaitSemaphoreEXT", null, semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, srcLayouts					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glSignalSemaphoreEXT: Binding for glSignalSemaphoreEXT.
		/// </summary>
		/// <param name="semaphore">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="numBufferBarriers">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="buffers">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="numTextureBarriers">
		/// A <see cref="T:uint"/>.
		/// </param>
		/// <param name="textures">
		/// A <see cref="T:uint[]"/>.
		/// </param>
		/// <param name="dstLayouts">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		public static void SignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint[] buffers, uint numTextureBarriers, uint[] textures, int[] dstLayouts)
		{
			unsafe {
				fixed (uint* p_buffers = buffers)
				fixed (uint* p_textures = textures)
				fixed (int* p_dstLayouts = dstLayouts)
				{
					Debug.Assert(Delegates.pglSignalSemaphoreEXT != null, "pglSignalSemaphoreEXT not implemented");
					Delegates.pglSignalSemaphoreEXT(semaphore, numBufferBarriers, p_buffers, numTextureBarriers, p_textures, p_dstLayouts);
					LogCommand("glSignalSemaphoreEXT", null, semaphore, numBufferBarriers, buffers, numTextureBarriers, textures, dstLayouts					);
				}
			}
			DebugCheckErrors(null);
		}

		internal static unsafe partial class Delegates
		{
			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetUnsignedBytevEXT(int pname, byte* data);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetUnsignedBytevEXT pglGetUnsignedBytevEXT;

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetUnsignedBytei_vEXT(int target, uint index, byte* data);

			[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetUnsignedBytei_vEXT pglGetUnsignedBytei_vEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGenSemaphoresEXT(int n, uint* semaphores);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGenSemaphoresEXT pglGenSemaphoresEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glDeleteSemaphoresEXT(int n, uint* semaphores);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glDeleteSemaphoresEXT pglDeleteSemaphoresEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			[return: MarshalAs(UnmanagedType.I1)]
			internal delegate bool glIsSemaphoreEXT(uint semaphore);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glIsSemaphoreEXT pglIsSemaphoreEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glSemaphoreParameterui64vEXT(uint semaphore, int pname, ulong* @params);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glSemaphoreParameterui64vEXT pglSemaphoreParameterui64vEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glGetSemaphoreParameterui64vEXT(uint semaphore, int pname, ulong* @params);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glGetSemaphoreParameterui64vEXT pglGetSemaphoreParameterui64vEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glWaitSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, int* srcLayouts);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glWaitSemaphoreEXT pglWaitSemaphoreEXT;

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[SuppressUnmanagedCodeSecurity]
			internal delegate void glSignalSemaphoreEXT(uint semaphore, uint numBufferBarriers, uint* buffers, uint numTextureBarriers, uint* textures, int* dstLayouts);

			[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
			[ThreadStatic]
			internal static glSignalSemaphoreEXT pglSignalSemaphoreEXT;

		}
	}

}
