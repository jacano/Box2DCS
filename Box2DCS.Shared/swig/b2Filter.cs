/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Box2DCS {

using System;
using System.Runtime.InteropServices;

public class b2Filter : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Filter(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Filter obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Filter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Filter(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2Filter() : this(Box2DPINVOKE.new_b2Filter(), true) {
  }

  public ushort categoryBits {
    set {
      Box2DPINVOKE.b2Filter_categoryBits_set(swigCPtr, value);
    } 
    get {
      ushort ret = Box2DPINVOKE.b2Filter_categoryBits_get(swigCPtr);
      return ret;
    } 
  }

  public ushort maskBits {
    set {
      Box2DPINVOKE.b2Filter_maskBits_set(swigCPtr, value);
    } 
    get {
      ushort ret = Box2DPINVOKE.b2Filter_maskBits_get(swigCPtr);
      return ret;
    } 
  }

  public short groupIndex {
    set {
      Box2DPINVOKE.b2Filter_groupIndex_set(swigCPtr, value);
    } 
    get {
      short ret = Box2DPINVOKE.b2Filter_groupIndex_get(swigCPtr);
      return ret;
    } 
  }

}

}
