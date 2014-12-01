/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Box2D {
 
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

public class b2DestructionListener : global::System.IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IntPtr Handle { get { return swigCPtr.Handle; } }

  internal b2DestructionListener(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2DestructionListener obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2DestructionListener() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2DestructionListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void SayGoodbye(Joint joint) {
    Box2DPINVOKE.b2DestructionListener_SayGoodbye__SWIG_0(swigCPtr, Joint.getCPtr(joint));
  }

  public virtual void SayGoodbye(Fixture fixture) {
    Box2DPINVOKE.b2DestructionListener_SayGoodbye__SWIG_1(swigCPtr, Fixture.getCPtr(fixture));
  }

}

}
