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

public class b2Color : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Color(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Color obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Color() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Color(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2Color() : this(Box2DPINVOKE.new_b2Color__SWIG_0(), true) {
  }

  public b2Color(float r, float g, float b) : this(Box2DPINVOKE.new_b2Color__SWIG_1(r, g, b), true) {
  }

  public void Set(float ri, float gi, float bi) {
    Box2DPINVOKE.b2Color_Set(swigCPtr, ri, gi, bi);
  }

  public float r {
    set {
      Box2DPINVOKE.b2Color_r_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Color_r_get(swigCPtr);
      return ret;
    } 
  }

  public float g {
    set {
      Box2DPINVOKE.b2Color_g_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Color_g_get(swigCPtr);
      return ret;
    } 
  }

  public float b {
    set {
      Box2DPINVOKE.b2Color_b_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Color_b_get(swigCPtr);
      return ret;
    } 
  }

}

}
