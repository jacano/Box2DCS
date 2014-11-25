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

public class b2WorldManifold : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2WorldManifold(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2WorldManifold obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2WorldManifold() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2WorldManifold(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public void Initialize(b2Manifold manifold, b2Transform xfA, float radiusA, b2Transform xfB, float radiusB) {
    Box2DPINVOKE.b2WorldManifold_Initialize(swigCPtr, b2Manifold.getCPtr(manifold), b2Transform.getCPtr(xfA), radiusA, b2Transform.getCPtr(xfB), radiusB);
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Vec2 normal {
    set {
      Box2DPINVOKE.b2WorldManifold_normal_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2WorldManifold_normal_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 points {
    set {
      Box2DPINVOKE.b2WorldManifold_points_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2WorldManifold_points_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2WorldManifold() : this(Box2DPINVOKE.new_b2WorldManifold(), true) {
  }

}

}