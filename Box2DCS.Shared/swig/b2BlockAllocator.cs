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

public class b2BlockAllocator : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2BlockAllocator(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2BlockAllocator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2BlockAllocator() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2BlockAllocator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2BlockAllocator() : this(Box2DPINVOKE.new_b2BlockAllocator(), true) {
  }

  public SWIGTYPE_p_void Allocate(int size) {
    IntPtr cPtr = Box2DPINVOKE.b2BlockAllocator_Allocate(swigCPtr, size);
    SWIGTYPE_p_void ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public void Free(SWIGTYPE_p_void p, int size) {
    Box2DPINVOKE.b2BlockAllocator_Free(swigCPtr, SWIGTYPE_p_void.getCPtr(p), size);
  }

  public void Clear() {
    Box2DPINVOKE.b2BlockAllocator_Clear(swigCPtr);
  }

}

}