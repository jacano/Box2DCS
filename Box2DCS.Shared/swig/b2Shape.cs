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

public class b2Shape : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2Shape(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2Shape obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2Shape() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2Shape(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual b2Shape Clone(b2BlockAllocator allocator) {
    IntPtr cPtr = Box2DPINVOKE.b2Shape_Clone(swigCPtr, b2BlockAllocator.getCPtr(allocator));
    b2Shape ret = (cPtr == IntPtr.Zero) ? null : new b2Shape(cPtr, false);
    return ret;
  }

  public b2Shape.Type GetType() {
    b2Shape.Type ret = (b2Shape.Type)Box2DPINVOKE.b2Shape_GetType(swigCPtr);
    return ret;
  }

  public virtual int GetChildCount() {
    int ret = Box2DPINVOKE.b2Shape_GetChildCount(swigCPtr);
    return ret;
  }

  public virtual bool TestPoint(b2Transform xf, b2Vec2 p) {
    bool ret = Box2DPINVOKE.b2Shape_TestPoint(swigCPtr, b2Transform.getCPtr(xf), b2Vec2.getCPtr(p));
    
    return ret;
  }

  public virtual bool RayCast(b2RayCastOutput output, b2RayCastInput input, b2Transform transform, int childIndex) {
    bool ret = Box2DPINVOKE.b2Shape_RayCast(swigCPtr, b2RayCastOutput.getCPtr(output), b2RayCastInput.getCPtr(input), b2Transform.getCPtr(transform), childIndex);
    
    return ret;
  }

  public virtual void ComputeAABB(b2AABB aabb, b2Transform xf, int childIndex) {
    Box2DPINVOKE.b2Shape_ComputeAABB(swigCPtr, b2AABB.getCPtr(aabb), b2Transform.getCPtr(xf), childIndex);
    
  }

  public virtual void ComputeMass(b2MassData massData, float density) {
    Box2DPINVOKE.b2Shape_ComputeMass(swigCPtr, b2MassData.getCPtr(massData), density);
  }

  public b2Shape.Type m_type {
    set {
      Box2DPINVOKE.b2Shape_m_type_set(swigCPtr, (int)value);
    } 
    get {
      b2Shape.Type ret = (b2Shape.Type)Box2DPINVOKE.b2Shape_m_type_get(swigCPtr);
      return ret;
    } 
  }

  public float m_radius {
    set {
      Box2DPINVOKE.b2Shape_m_radius_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2Shape_m_radius_get(swigCPtr);
      return ret;
    } 
  }

  public enum Type {
    e_circle = 0,
    e_edge = 1,
    e_polygon = 2,
    e_chain = 3,
    e_typeCount = 4
  }

}

}
