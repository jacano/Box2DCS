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

public class b2Profile : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Profile(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Profile obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Profile() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Profile(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public float step {
    set {
      Box2DPINVOKE.b2Profile_step_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_step_get(swigCPtr);
      return ret;
    } 
  }

  public float collide {
    set {
      Box2DPINVOKE.b2Profile_collide_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_collide_get(swigCPtr);
      return ret;
    } 
  }

  public float solve {
    set {
      Box2DPINVOKE.b2Profile_solve_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_solve_get(swigCPtr);
      return ret;
    } 
  }

  public float solveInit {
    set {
      Box2DPINVOKE.b2Profile_solveInit_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_solveInit_get(swigCPtr);
      return ret;
    } 
  }

  public float solveVelocity {
    set {
      Box2DPINVOKE.b2Profile_solveVelocity_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_solveVelocity_get(swigCPtr);
      return ret;
    } 
  }

  public float solvePosition {
    set {
      Box2DPINVOKE.b2Profile_solvePosition_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_solvePosition_get(swigCPtr);
      return ret;
    } 
  }

  public float broadphase {
    set {
      Box2DPINVOKE.b2Profile_broadphase_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_broadphase_get(swigCPtr);
      return ret;
    } 
  }

  public float solveTOI {
    set {
      Box2DPINVOKE.b2Profile_solveTOI_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Profile_solveTOI_get(swigCPtr);
      return ret;
    } 
  }

  public b2Profile() : this(Box2DPINVOKE.new_b2Profile(), true) {
  }

}

}
