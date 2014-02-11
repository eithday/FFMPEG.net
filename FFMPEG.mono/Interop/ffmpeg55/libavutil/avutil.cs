/*
 * copyright (c) 2013 Crazyender
 *
 * This file is part of FFmpeg.mono
 *
 * FFmpeg.mono is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * FFmpeg.mono is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with FFmpeg; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */


using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;
namespace SharpFFmpeg
{
    public partial class NativeMethods55 
{
public const string AVUTIL = "avutil-52.dll";


public static readonly uint FF_LAMBDA_SHIFT = 7;
public static readonly uint FF_LAMBDA_SCALE = 128;
public static readonly uint FF_QP2LAMBDA = 118;
public static readonly uint FF_LAMBDA_MAX = (256*128-1);
public static readonly uint FF_QUALITY_SCALE = FF_LAMBDA_SCALE;
public static readonly ulong AV_NOPTS_VALUE = (0x8000000000000000);
public static readonly uint AV_TIME_BASE = 1000000;
//public static readonly uint AV_TIME_BASE_Q = (AVRational){1, AV_TIME_BASE};
public enum AVMediaType
{
	AVMEDIA_TYPE_UNKNOWN = -1,
	AVMEDIA_TYPE_VIDEO = 0,
	AVMEDIA_TYPE_AUDIO = 1,
	AVMEDIA_TYPE_DATA = 2,
	AVMEDIA_TYPE_SUBTITLE = 3,
	AVMEDIA_TYPE_ATTACHMENT = 4,
	AVMEDIA_TYPE_NB = 5,
}

public enum AVPictureType
{
	AV_PICTURE_TYPE_NONE = 0,
	AV_PICTURE_TYPE_I = 1,
	AV_PICTURE_TYPE_P = 2,
	AV_PICTURE_TYPE_B = 3,
	AV_PICTURE_TYPE_S = 4,
	AV_PICTURE_TYPE_SI = 5,
	AV_PICTURE_TYPE_SP = 6,
	AV_PICTURE_TYPE_BI = 7,
}

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern System.UInt32 avutil_version(
);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern string avutil_configuration(
);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern string avutil_license(
);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern string av_get_media_type_string(
	AVMediaType media_type);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern System.Char av_get_picture_type_char(
	AVPictureType pict_type);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern IntPtr/* void*  */ av_x_if_null(
	IntPtr/* void*  */ p, 
	IntPtr/* void*  */ x);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern System.UInt32 av_int_list_length_for_size(
	[MarshalAs(UnmanagedType.I4)]
	System.UInt32 elsize, 
	IntPtr/* void*  */ list, 
	[MarshalAs(UnmanagedType.I8)]
	System.UInt64 term);

[DllImport(AVUTIL), SuppressUnmanagedCodeSecurity]
public static extern IntPtr/* _iobuf*  */ av_fopen_utf8(
	[MarshalAs(UnmanagedType.LPStr)]
	string path, 
	[MarshalAs(UnmanagedType.LPStr)]
	string mode);

}
}

