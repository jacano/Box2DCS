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

public class b2FrictionJointDef : b2JointDef {
  private HandleRef swigCPtr;

  internal b2FrictionJointDef(IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2FrictionJointDef_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2FrictionJointDef obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2FrictionJointDef() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2FrictionJointDef(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public b2FrictionJointDef() : this(Box2DPINVOKE.new_b2FrictionJointDef(), true) {
  }

  public void Initialize(b2Body bodyA, b2Body bodyB, b2Vec2 anchor) {
    Box2DPINVOKE.b2FrictionJointDef_Initialize(swigCPtr, b2Body.getCPtr(bodyA), b2Body.getCPtr(bodyB), b2Vec2.getCPtr(anchor));
    if (Box2DPINVOKE.SWIGPendingException.Pending) throw Box2DPINVOKE.SWIGPendingException.Retrieve();
  }

  public b2Vec2 localAnchorA {
    set {
      Box2DPINVOKE.b2FrictionJointDef_localAnchorA_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2FrictionJointDef_localAnchorA_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public b2Vec2 localAnchorB {
    set {
      Box2DPINVOKE.b2FrictionJointDef_localAnchorB_set(swigCPtr, b2Vec2.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Box2DPINVOKE.b2FrictionJointDef_localAnchorB_get(swigCPtr);
      b2Vec2 ret = (cPtr == IntPtr.Zero) ? null : new b2Vec2(cPtr, false);
      return ret;
    } 
  }

  public float maxForce {
    set {
      Box2DPINVOKE.b2FrictionJointDef_maxForce_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2FrictionJointDef_maxForce_get(swigCPtr);
      return ret;
    } 
  }

  public float maxTorque {
    set {
      Box2DPINVOKE.b2FrictionJointDef_maxTorque_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2FrictionJointDef_maxTorque_get(swigCPtr);
      return ret;
    } 
  }

}

}