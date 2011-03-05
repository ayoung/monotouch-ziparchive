//
//  MonoTouch bindings for ziparchive iOS SDK 
//  use with libziparchive.a
//
//  MIT X11 licensed
//
// Copyright 2010 Andrew Young (http://twitter.com/andrewdyoung)

using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;

namespace LibZipArchive
{

	[BaseType (typeof (NSObject))]
	interface ZipArchive {
    //-(BOOL) CreateZipFile2:(NSString*) zipFile;
    [Export("CreateZipFile2:")]
    bool CreateZipFile2(string zipFile);
    
    //-(BOOL) CreateZipFile2:(NSString*) zipFile Password:(NSString*) password;
    [Export("CreateZipFile2:Password:")]
    bool CreateZipFile2(string zipFile, string password);
    
    //-(BOOL) addFileToZip:(NSString*) file newname:(NSString*) newname;
    [Export("addFileToZip:newname:")]
    bool AddFile(string file, string newName);
    
    //-(BOOL) CloseZipFile2;
    [Export("CloseZipFile2")]
    bool CloseZipFile2();
    
    //-(BOOL) UnzipOpenFile:(NSString*) zipFile;
    [Export("UnzipOpenFile:")]
    bool UnzipOpenFile(string file);
  
    //-(BOOL) UnzipOpenFile:(NSString*) zipFile Password:(NSString*) password;
    [Export("UnzipOpenFile:Password:")]
    bool UnzipOpenFile(string file, string password);
  
    //-(BOOL) UnzipFileTo:(NSString*) path overWrite:(BOOL) overwrite;
    [Export("UnzipFileTo:overWrite:")]
    bool UnzipFileTo(string path, bool overwrite);
  
    //-(BOOL) UnzipCloseFile;
    [Export("UnzipCloseFile")]
    bool UnzipCloseFile();
	}
}