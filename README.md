Monotouch bindings for ZipArchive
=================================

This library allows you to easily compress files to an archive (.zip file) using MonoTouch. Other libraries are available but this is one of the simplest solutions.

You can get the ZipArchive code from their [google code page](http://code.google.com/p/ziparchive/).

Adding this lib to your project
-------------------------------

- Copy libziparchive.a and monotouch-ziparchive.dll to the root of your proj. You can copy it to another relative location but you'll have to modify the gcc_flags specified down below to match the paths.
- In your MonoTouch project options > iPhone Build
    - Set Linker behavior to "Link SDK assemblies only"
    - Set the Extra arguments in all iPhone Build configurations to:

          -v -gcc_flags "-L${ProjectDir} -lziparchive -lz.1.2.3 -framework Foundation -force_load ${ProjectDir}/libziparchive.a"
      
      This includes build configs for Debug and Release versions of iPhone and iPhoneSimulator configs.

Usage
=====

To zip files:

      var zipFile = new LibZipArchive.ZipArchive();
      zipFile.CreateZipFile2("/path/to/archive/file.zip");
      zipFile.AddFile("/path/of/file/to/compress.txt", "somefile.txt");
      // add more files as needed
      zipFile.CloseZipFile2();

To unzip files:

      var zipFile = new LibZipArchive.ZipArchive();
      zipFile.UnzipOpenFile("/path/to/archive/file.zip");
      zipFile.UnzipFileTo("/location/to/unarchive", true);
      zipFile.UnzipCloseFile();
