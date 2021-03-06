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

public class b2TOIOutput : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal b2TOIOutput(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(b2TOIOutput obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~b2TOIOutput() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Box2DPINVOKE.delete_b2TOIOutput(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public b2TOIOutput.State state {
    set {
      Box2DPINVOKE.b2TOIOutput_state_set(swigCPtr, (int)value);
    } 
    get {
      b2TOIOutput.State ret = (b2TOIOutput.State)Box2DPINVOKE.b2TOIOutput_state_get(swigCPtr);
      return ret;
    } 
  }

  public float t {
    set {
      Box2DPINVOKE.b2TOIOutput_t_set(swigCPtr, value);
    } 
    get {
      float ret = Box2DPINVOKE.b2TOIOutput_t_get(swigCPtr);
      return ret;
    } 
  }

  public b2TOIOutput() : this(Box2DPINVOKE.new_b2TOIOutput(), true) {
  }

  public enum State {
    e_unknown,
    e_failed,
    e_overlapped,
    e_touching,
    e_separated
  }

}

}
