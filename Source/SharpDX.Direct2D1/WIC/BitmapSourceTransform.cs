// Copyright (c) 2010-2011 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace SharpDX.WIC
{
    public partial class BitmapSourceTransform
    {
        /// <summary>
        /// Copies pixel data using the supplied input parameters.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="stride">The stride.</param>
        /// <param name="output">The output.</param>
        /// <returns></returns>
        /// <unmanaged>HRESULT IWICBitmapSourceTransform::CopyPixels([In, Optional] const WICRect* prc,[In] unsigned int uiWidth,[In] unsigned int uiHeight,[In, Optional] GUID* pguidDstFormat,[In] WICBitmapTransformOptions dstTransform,[In] unsigned int nStride,[In] unsigned int cbBufferSize,[In] void* pbBuffer)</unmanaged>
        public SharpDX.Result CopyPixels(int width, int height, int stride, DataStream output)
        {
            return CopyPixels(null, width, height, null, BitmapTransformOptions.Rotate0, stride, (int)output.Length,
                       output.DataPointer);
        }

        /// <summary>
        /// Copies pixel data using the supplied input parameters.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="dstTransform">The DST transform.</param>
        /// <param name="stride">The stride.</param>
        /// <param name="output">The output.</param>
        /// <returns></returns>
        /// <unmanaged>HRESULT IWICBitmapSourceTransform::CopyPixels([In, Optional] const WICRect* prc,[In] unsigned int uiWidth,[In] unsigned int uiHeight,[In, Optional] GUID* pguidDstFormat,[In] WICBitmapTransformOptions dstTransform,[In] unsigned int nStride,[In] unsigned int cbBufferSize,[In] void* pbBuffer)</unmanaged>
        public SharpDX.Result CopyPixels(int width, int height, SharpDX.WIC.BitmapTransformOptions dstTransform, int stride, DataStream output)
        {
            return CopyPixels(null, width, height, null, dstTransform, stride, (int)output.Length,
                       output.DataPointer);
        }

        /// <summary>
        /// Copies pixel data using the supplied input parameters.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="guidDstFormat">The GUID DST format.</param>
        /// <param name="dstTransform">The DST transform.</param>
        /// <param name="stride">The stride.</param>
        /// <param name="output">The output.</param>
        /// <returns></returns>
        /// <unmanaged>HRESULT IWICBitmapSourceTransform::CopyPixels([In, Optional] const WICRect* prc,[In] unsigned int uiWidth,[In] unsigned int uiHeight,[In, Optional] GUID* pguidDstFormat,[In] WICBitmapTransformOptions dstTransform,[In] unsigned int nStride,[In] unsigned int cbBufferSize,[In] void* pbBuffer)</unmanaged>
        public SharpDX.Result CopyPixels(int width, int height, System.Guid guidDstFormat, SharpDX.WIC.BitmapTransformOptions dstTransform, int stride, DataStream output)
        {
            return CopyPixels(null, width, height, guidDstFormat, dstTransform, stride, (int)output.Length,
                       output.DataPointer);
        }

        /// <summary>
        /// Copies pixel data using the supplied input parameters.
        /// </summary>
        /// <param name="rectangle">The rectangle.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="guidDstFormat">The GUID DST format.</param>
        /// <param name="dstTransform">The DST transform.</param>
        /// <param name="stride">The stride.</param>
        /// <param name="output">The output.</param>
        /// <returns></returns>
        /// <unmanaged>HRESULT IWICBitmapSourceTransform::CopyPixels([In, Optional] const WICRect* prc,[In] unsigned int uiWidth,[In] unsigned int uiHeight,[In, Optional] GUID* pguidDstFormat,[In] WICBitmapTransformOptions dstTransform,[In] unsigned int nStride,[In] unsigned int cbBufferSize,[In] void* pbBuffer)</unmanaged>
        public SharpDX.Result CopyPixels(System.Drawing.Rectangle rectangle, int width, int height, System.Guid guidDstFormat, SharpDX.WIC.BitmapTransformOptions dstTransform, int stride, DataStream output)
        {
            return CopyPixels(rectangle, width, height, guidDstFormat, dstTransform, stride, (int) output.Length,
                       output.DataPointer);
        }

        /// <summary>
        /// Returns the closest dimensions the implementation can natively scale to given the desired dimensions.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        /// <unmanaged>HRESULT IWICBitmapSourceTransform::GetClosestSize([InOut] unsigned int* puiWidth,[InOut] unsigned int* puiHeight)</unmanaged>
        public SharpDX.Result GetClosestSize(ref System.Drawing.Size size)
        {
            int width = size.Width;
            int height = size.Height;
            var result = GetClosestSize(ref width, ref height);
            size.Width = width;
            size.Height = height;
            return result;
        }
    }
}