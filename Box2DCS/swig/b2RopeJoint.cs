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

public class b2RopeJoint : b2Joint {
  private HandleRef swigCPtr;

  internal b2RopeJoint(IntPtr cPtr, bool cMemoryOwn) : base(Box2DPINVOKE.b2RopeJoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2RopeJoint obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2RopeJoint() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2RopeJoint(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override b2Vec2 GetAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2RopeJoint_GetAnchorA(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2RopeJoint_GetAnchorB(swigCPtr), true);
    return ret;
  }

  public override b2Vec2 GetReactionForce(float inv_dt) {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2RopeJoint_GetReactionForce(swigCPtr, inv_dt), true);
    return ret;
  }

  public override float GetReactionTorque(float inv_dt) {
    float ret = Box2DPINVOKE.b2RopeJoint_GetReactionTorque(swigCPtr, inv_dt);
    return ret;
  }

  public b2Vec2 GetLocalAnchorA() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2RopeJoint_GetLocalAnchorA(swigCPtr), false);
    return ret;
  }

  public b2Vec2 GetLocalAnchorB() {
    b2Vec2 ret = new b2Vec2(Box2DPINVOKE.b2RopeJoint_GetLocalAnchorB(swigCPtr), false);
    return ret;
  }

  public void SetMaxLength(float length) {
    Box2DPINVOKE.b2RopeJoint_SetMaxLength(swigCPtr, length);
  }

  public float GetMaxLength() {
    float ret = Box2DPINVOKE.b2RopeJoint_GetMaxLength(swigCPtr);
    return ret;
  }

  public b2LimitState GetLimitState() {
    b2LimitState ret = (b2LimitState)Box2DPINVOKE.b2RopeJoint_GetLimitState(swigCPtr);
    return ret;
  }

  public override void Dump() {
    Box2DPINVOKE.b2RopeJoint_Dump(swigCPtr);
  }

}

}
