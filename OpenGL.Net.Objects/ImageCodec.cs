
  // Copyright (C) 2009-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System.IO;

namespace OpenGL.Objects
{
	/// <summary>
	/// Image coder/decoder.
	/// </summary>
	public sealed class ImageCodec : MediaCodec<IImageCodecPlugin, Image, ImageInfo, ImageCodecCriteria>
	{
		#region Constructors

		/// <summary>
		/// The only instance of ImageCodec.
		/// </summary>
		public static readonly ImageCodec Instance = new ImageCodec();

		/// <summary>
		/// This type is a singleton.
		/// </summary>
		private ImageCodec() :
			base(PluginFactoryType, "GLO_IMAGE_CODEC_DIR")
		{
			// Common media description
			ExtractDescriptions(typeof(ImageFormat));
			// Core plugin always registered
			RegisterPlugin(new CoreImagingImageCodecPlugin());
			// RegisterPlugin(new GdalImageCodecPlugin());
		}

		/// <summary>
		/// The type which following plugin factory conventions.
		/// </summary>
		private const string PluginFactoryType = "OpenGL.ImageCodecFactory";
		
		#endregion

		#region MediaCodec<IImageCodecPlugin, Image, ImageInfo> Overrides

		/// <summary>
		/// Load media from stream.
		/// </summary>
		/// <param name="stream">
		/// A <see cref="Stream"/> where the media data is stored.
		/// </param>
		/// <param name="format">
		/// The <see cref="String"/> which defines the format of the stream data.
		/// </param>
		/// <param name="criteria">
		/// A <see cref="MediaCodecCriteria"/> that specify parameters for loading an media stream.
		/// </param>
		/// <returns>
		/// An <typeparamref name="TMedia"/> holding the media data.
		/// </returns>
		/// <exception cref="ArgumentNullException">
		/// Exception thrown if <paramref name="stream"/> or <paramref name="criteria"/> is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Exception thrown if <paramref name="stream"/> is not readable or seekable.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if no plugin is available for <paramref name="format"/> (filtered by
		/// <paramref name="criteria"/>) or all plugins are not able to load media from
		/// <paramref name="stream"/>.
		/// </exception>
		/// <exception cref="NotSupportedException">
		/// Exception thrown if <paramref name="format"/> is not supported by any loaded plugin.
		/// </exception>
		public override Image Load(Stream stream, string format, ImageCodecCriteria criteria)
		{
			// Base implementation
			Image image = base.Load(stream, format, criteria);
			// Fix container format in MediaInformation
			image.MediaInformation.ContainerFormat = format;

			return (image);
		}

		/// <summary>
		/// Creates the default media codec criteria.
		/// </summary>
		/// <returns>
		/// The default media codec criteria.
		/// </returns>
		protected override ImageCodecCriteria CreateDefaultMediaCodecCriteria()
		{
			return (new ImageCodecCriteria());
		}

		#endregion
	}
}
