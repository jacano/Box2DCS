Box2DCS
=======

Box2D for C#

Requirements:
- Visual Studio 2012
- swig 2.0.9
- box2d 2.2.1

Steps to build:

1. Create box2d.i file

2. Generate cs files and .cxx file

  swig.exe -csharp -c++ -includeall -ignoremissing -namespace Box2DCS -outdir SWIG box2d.i

3. Build Box2D.dll from VC++

4. Build Box2DCS.dll from step 2

Notes:
Comment SWIGEXPORT void SWIGSTDCALL CSharp_b2WheelJoint_GetDefinition(void * jarg1, void * jarg2) in .cxx file to ignore error linking when run step 3.
