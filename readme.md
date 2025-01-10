There are no dll's for Linux for the at least these 3:
avl_api.so
avl_types_api.so
avdll_api.so
  
------------------

# Windows 11:

DemoApp.exe

```
Hello, World!
Characters decoded: 7
```

----------

# Linux OL9.0

```
dotnet build -c Release -r linux-x64
```

```
[ks@vbox publish]$ ./DemoApp
Hello, World!
Unhandled exception. System.DllNotFoundException: Unable to load shared library                                                                                                                                                              'avl_types_api' or one of its dependencies. In order to help diagnose loading pr                                                                                                                                                             oblems, consider using a tool like strace. If you're using glibc, consider setti                                                                                                                                                             ng the LD_DEBUG environment variable:
/home/ks/demo/publish/avl_types_api.so: cannot open shared object file: No such                                                                                                                                                              file or directory
/home/ks/demo/publish/libavl_types_api.so: cannot open shared object file: No su                                                                                                                                                             ch file or directory
/home/ks/demo/publish/avl_types_api: cannot open shared object file: No such fil                                                                                                                                                             e or directory
/home/ks/demo/publish/libavl_types_api: cannot open shared object file: No such                                                                                                                                                              file or directory

   at Avl.ReadCharactersModelId.AAPI_ReadCharactersModelId_Create_ZatloTastr_ocr                                                                                                                                                             pretrainedmodel_atloTdevicekind_iE(NullableDto modelDirectory_, OcrPretrainedMod                                                                                                                                                             el pretrainedModel_, NullableDto deviceType_, Int32 deviceIndex_, BlobDto& _outR                                                                                                                                                             eadCharactersModelId, NullableDto& _outErrorMessage)
   at Avl.ReadCharactersModelId.Create(Optional`1 modelDirectory_, OcrPretrained                                                                                                                                                             Model pretrainedModel_, Optional`1 deviceType_, Int32 deviceIndex_)
   at Avl.ReadCharactersModelId..ctor(Optional`1 modelDirectory_, OcrPretrainedM                                                                                                                                                             odel pretrainedModel_, Optional`1 deviceType_, Int32 deviceIndex_)
   at DemoApp.AuroraFunctions.ReadOCR(Single x, Single y, Single w, Single h, In                                                                                                                                                             t32 chrHeight) in C:\Users\210043782\git\Aurora\Example\DemoApp\DemoApp\AuroraFu                                                                                                                                                             nctions.cs:line 12
   at DemoApp.Program.Main(String[] args) in C:\Users\210043782\git\Aurora\Examp                                                                                                                                                             le\DemoApp\DemoApp\Program.cs:line 8
Aborted (core dumped)
```
