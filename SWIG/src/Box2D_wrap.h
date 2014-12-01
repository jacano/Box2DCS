/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_Box2D_WRAP_H_
#define SWIG_Box2D_WRAP_H_

class SwigDirector_Shape : public b2Shape, public Swig::Director {

public:
    SwigDirector_Shape();
    virtual ~SwigDirector_Shape();
    virtual b2Shape *Clone(b2BlockAllocator *allocator) const;
    virtual int32 GetChildCount() const;
    virtual bool TestPoint(b2Transform const &xf, b2Vec2 const &p) const;
    virtual bool RayCast(b2RayCastOutput *output, b2RayCastInput const &input, b2Transform const &transform, int32 childIndex) const;
    virtual void ComputeAABB(b2AABB *aabb, b2Transform const &xf, int32 childIndex) const;
    virtual void ComputeMass(b2MassData *massData, float32 density) const;
    void swig_connect_director();
    void swig_init_callbacks();
};

class SwigDirector_ContactListener : public b2ContactListener, public Swig::Director {

public:
    SwigDirector_ContactListener();
    virtual ~SwigDirector_ContactListener();
    virtual void BeginContact(b2Contact *contact);
    virtual void EndContact(b2Contact *contact);
    virtual void PreSolve(b2Contact *contact, b2Manifold const *oldManifold);
    virtual void PostSolve(b2Contact *contact, b2ContactImpulse const *impulse);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)(void*);
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(void*);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(void*, void *);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(void*, void *);
    void swig_connect_director(SWIG_Callback0_t callbackBeginContact, SWIG_Callback1_t callbackEndContact, SWIG_Callback2_t callbackPreSolve, SWIG_Callback3_t callbackPostSolve);

private:
    SWIG_Callback0_t swig_callbackBeginContact;
    SWIG_Callback1_t swig_callbackEndContact;
    SWIG_Callback2_t swig_callbackPreSolve;
    SWIG_Callback3_t swig_callbackPostSolve;
    void swig_init_callbacks();
};


#endif