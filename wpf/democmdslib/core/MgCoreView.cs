/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace democmds.core {

using System;
using System.Runtime.InteropServices;

public class MgCoreView : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgCoreView(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCoreView obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCoreView() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          democmdsPINVOKE.delete_MgCoreView(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static MgCoreView fromHandle(int h) {
    IntPtr cPtr = democmdsPINVOKE.MgCoreView_fromHandle(h);
    MgCoreView ret = (cPtr == IntPtr.Zero) ? null : new MgCoreView(cPtr, false);
    return ret;
  }

  public int toHandle() {
    int ret = democmdsPINVOKE.MgCoreView_toHandle(swigCPtr);
    return ret;
  }

  public virtual int viewAdapterHandle() {
    int ret = democmdsPINVOKE.MgCoreView_viewAdapterHandle(swigCPtr);
    return ret;
  }

  public virtual int backDoc() {
    int ret = democmdsPINVOKE.MgCoreView_backDoc(swigCPtr);
    return ret;
  }

  public virtual int backShapes() {
    int ret = democmdsPINVOKE.MgCoreView_backShapes(swigCPtr);
    return ret;
  }

  public virtual int acquireFrontDoc() {
    int ret = democmdsPINVOKE.MgCoreView_acquireFrontDoc(swigCPtr);
    return ret;
  }

  public virtual void releaseDoc(int hDoc) {
    democmdsPINVOKE.MgCoreView_releaseDoc(swigCPtr, hDoc);
  }

  public virtual int acquireDynamicShapes() {
    int ret = democmdsPINVOKE.MgCoreView_acquireDynamicShapes(swigCPtr);
    return ret;
  }

  public virtual void releaseShapes(int hShapes) {
    democmdsPINVOKE.MgCoreView_releaseShapes(swigCPtr, hShapes);
  }

  public virtual bool loadDynamicShapes(SWIGTYPE_p_MgStorage s) {
    bool ret = democmdsPINVOKE.MgCoreView_loadDynamicShapes(swigCPtr, SWIGTYPE_p_MgStorage.getCPtr(s));
    return ret;
  }

  public virtual void applyDynamicShapes() {
    democmdsPINVOKE.MgCoreView_applyDynamicShapes(swigCPtr);
  }

  public virtual bool isPressDragging() {
    bool ret = democmdsPINVOKE.MgCoreView_isPressDragging(swigCPtr);
    return ret;
  }

  public virtual string getCommand() {
    string ret = democmdsPINVOKE.MgCoreView_getCommand(swigCPtr);
    return ret;
  }

  public virtual bool setCommand(string name, string arg1) {
    bool ret = democmdsPINVOKE.MgCoreView_setCommand__SWIG_0(swigCPtr, name, arg1);
    return ret;
  }

  public virtual bool setCommand(string name) {
    bool ret = democmdsPINVOKE.MgCoreView_setCommand__SWIG_1(swigCPtr, name);
    return ret;
  }

  public virtual bool doContextAction(int action) {
    bool ret = democmdsPINVOKE.MgCoreView_doContextAction(swigCPtr, action);
    return ret;
  }

  public virtual void clearCachedData() {
    democmdsPINVOKE.MgCoreView_clearCachedData(swigCPtr);
  }

  public virtual int addShapesForTest() {
    int ret = democmdsPINVOKE.MgCoreView_addShapesForTest(swigCPtr);
    return ret;
  }

  public virtual int getShapeCount() {
    int ret = democmdsPINVOKE.MgCoreView_getShapeCount(swigCPtr);
    return ret;
  }

  public virtual int getChangeCount() {
    int ret = democmdsPINVOKE.MgCoreView_getChangeCount(swigCPtr);
    return ret;
  }

  public virtual int getDrawCount() {
    int ret = democmdsPINVOKE.MgCoreView_getDrawCount(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeCount() {
    int ret = democmdsPINVOKE.MgCoreView_getSelectedShapeCount(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeType() {
    int ret = democmdsPINVOKE.MgCoreView_getSelectedShapeType(swigCPtr);
    return ret;
  }

  public virtual int getSelectedShapeID() {
    int ret = democmdsPINVOKE.MgCoreView_getSelectedShapeID(swigCPtr);
    return ret;
  }

  public virtual void clear() {
    democmdsPINVOKE.MgCoreView_clear(swigCPtr);
  }

  public virtual bool loadFromFile(string vgfile, bool readOnly) {
    bool ret = democmdsPINVOKE.MgCoreView_loadFromFile__SWIG_0(swigCPtr, vgfile, readOnly);
    return ret;
  }

  public virtual bool loadFromFile(string vgfile) {
    bool ret = democmdsPINVOKE.MgCoreView_loadFromFile__SWIG_1(swigCPtr, vgfile);
    return ret;
  }

  public virtual bool saveToFile(int hDoc, string vgfile, bool pretty) {
    bool ret = democmdsPINVOKE.MgCoreView_saveToFile__SWIG_0(swigCPtr, hDoc, vgfile, pretty);
    return ret;
  }

  public virtual bool saveToFile(int hDoc, string vgfile) {
    bool ret = democmdsPINVOKE.MgCoreView_saveToFile__SWIG_1(swigCPtr, hDoc, vgfile);
    return ret;
  }

  public bool saveToFile(string vgfile, bool pretty) {
    bool ret = democmdsPINVOKE.MgCoreView_saveToFile__SWIG_2(swigCPtr, vgfile, pretty);
    return ret;
  }

  public bool saveToFile(string vgfile) {
    bool ret = democmdsPINVOKE.MgCoreView_saveToFile__SWIG_3(swigCPtr, vgfile);
    return ret;
  }

  public virtual bool loadShapes(SWIGTYPE_p_MgStorage s, bool readOnly) {
    bool ret = democmdsPINVOKE.MgCoreView_loadShapes__SWIG_0(swigCPtr, SWIGTYPE_p_MgStorage.getCPtr(s), readOnly);
    return ret;
  }

  public virtual bool loadShapes(SWIGTYPE_p_MgStorage s) {
    bool ret = democmdsPINVOKE.MgCoreView_loadShapes__SWIG_1(swigCPtr, SWIGTYPE_p_MgStorage.getCPtr(s));
    return ret;
  }

  public virtual bool saveShapes(int hDoc, SWIGTYPE_p_MgStorage s) {
    bool ret = democmdsPINVOKE.MgCoreView_saveShapes__SWIG_0(swigCPtr, hDoc, SWIGTYPE_p_MgStorage.getCPtr(s));
    return ret;
  }

  public bool saveShapes(SWIGTYPE_p_MgStorage s) {
    bool ret = democmdsPINVOKE.MgCoreView_saveShapes__SWIG_1(swigCPtr, SWIGTYPE_p_MgStorage.getCPtr(s));
    return ret;
  }

  public virtual string getContent(int hDoc) {
    string ret = democmdsPINVOKE.MgCoreView_getContent__SWIG_0(swigCPtr, hDoc);
    return ret;
  }

  public virtual void freeContent() {
    democmdsPINVOKE.MgCoreView_freeContent(swigCPtr);
  }

  public virtual bool setContent(string content) {
    bool ret = democmdsPINVOKE.MgCoreView_setContent(swigCPtr, content);
    return ret;
  }

  public string getContent() {
    string ret = democmdsPINVOKE.MgCoreView_getContent__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual bool zoomToExtent() {
    bool ret = democmdsPINVOKE.MgCoreView_zoomToExtent(swigCPtr);
    return ret;
  }

  public virtual bool zoomToModel(float x, float y, float w, float h) {
    bool ret = democmdsPINVOKE.MgCoreView_zoomToModel(swigCPtr, x, y, w, h);
    return ret;
  }

  public virtual SWIGTYPE_p_GiContext getContext(bool forChange) {
    SWIGTYPE_p_GiContext ret = new SWIGTYPE_p_GiContext(democmdsPINVOKE.MgCoreView_getContext(swigCPtr, forChange), false);
    return ret;
  }

  public virtual void setContext(int mask) {
    democmdsPINVOKE.MgCoreView_setContext__SWIG_0(swigCPtr, mask);
  }

  public virtual void setContext(SWIGTYPE_p_GiContext ctx, int mask, int apply) {
    democmdsPINVOKE.MgCoreView_setContext__SWIG_1(swigCPtr, SWIGTYPE_p_GiContext.getCPtr(ctx), mask, apply);
    if (democmdsPINVOKE.SWIGPendingException.Pending) throw democmdsPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setContextEditing(bool editing) {
    democmdsPINVOKE.MgCoreView_setContextEditing(swigCPtr, editing);
  }

  public virtual int addImageShape(string name, float width, float height) {
    int ret = democmdsPINVOKE.MgCoreView_addImageShape__SWIG_0(swigCPtr, name, width, height);
    return ret;
  }

  public virtual int addImageShape(string name, float xc, float yc, float w, float h) {
    int ret = democmdsPINVOKE.MgCoreView_addImageShape__SWIG_1(swigCPtr, name, xc, yc, w, h);
    return ret;
  }

  public virtual bool getBoundingBox(Floats box) {
    bool ret = democmdsPINVOKE.MgCoreView_getBoundingBox__SWIG_0(swigCPtr, Floats.getCPtr(box));
    if (democmdsPINVOKE.SWIGPendingException.Pending) throw democmdsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool getBoundingBox(Floats box, int shapeId) {
    bool ret = democmdsPINVOKE.MgCoreView_getBoundingBox__SWIG_1(swigCPtr, Floats.getCPtr(box), shapeId);
    if (democmdsPINVOKE.SWIGPendingException.Pending) throw democmdsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
