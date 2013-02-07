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

public class b2StackEntry : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2StackEntry(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2StackEntry obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2StackEntry() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2StackEntry(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public string data {
    set {
      Box2DPINVOKE.b2StackEntry_data_set(swigCPtr, value);
    } 
    get {
      string ret = Box2DPINVOKE.b2StackEntry_data_get(swigCPtr);
      return ret;
    } 
  }

  public int size {
    set {
      Box2DPINVOKE.b2StackEntry_size_set(swigCPtr, value);
    } 
    get {
      int ret = Box2DPINVOKE.b2StackEntry_size_get(swigCPtr);
      return ret;
    } 
  }

  public bool usedMalloc {
    set {
      Box2DPINVOKE.b2StackEntry_usedMalloc_set(swigCPtr, value);
    } 
    get {
      bool ret = Box2DPINVOKE.b2StackEntry_usedMalloc_get(swigCPtr);
      return ret;
    } 
  }

  public b2StackEntry() : this(Box2DPINVOKE.new_b2StackEntry(), true) {
  }

}

}
