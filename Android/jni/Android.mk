LOCAL_PATH := $(call my-dir)
include $(CLEAR_VARS)
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/*.cpp)
BOX2D_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Collision/*.cpp)
COLLISION_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Collision/Shapes/*.cpp)
SHAPES_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Common/*.cpp)
COMMON_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Dynamics/*.cpp)
DYNAMICS_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Dynamics/Contacts/*.cpp)
CONTACTS_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Dynamics/Joints/*.cpp)
JOINTS_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
SOURCE_BUFFER	:= $(wildcard $(LOCAL_PATH)/Box2D/Rope/*.cpp)
ROPE_SRC	:= $(subst jni/, , $(SOURCE_BUFFER))
LOCAL_MODULE			:= box2d
LOCAL_LDLIBS			  := -lstdc++ -lm -landroid
LOCAL_C_INCLUDES		:=	$(LOCAL_PATH)Box2D \
					$(LOCAL_PATH)Box2D/Collision \
					$(LOCAL_PATH)Box2D/Collision/Shapes \
					$(LOCAL_PATH)Box2D/Common \
					$(LOCAL_PATH)Box2D/Dynamics \
					$(LOCAL_PATH)Box2D/Dynamics/Contacts \
					$(LOCAL_PATH)Box2D/Dynamics/Joints \
					$(LOCAL_PATH)Box2D/Rope
LOCAL_SRC_FILES			  :=	$(BOX2D_SRC) \
					$(COLLISION_SRC) \
					$(SHAPES_SRC) \
					$(COMMON_SRC) \
					$(DYNAMICS_SRC) \
					$(CONTACTS_SRC) \
					$(JOINTS_SRC) \
					$(ROPE_SRC)
include $(BUILD_STATIC_LIBRARY)
include $(CLEAR_VARS)
LOCAL_MODULE           := box2dshared
LOCAL_STATIC_LIBRARIES := box2d
include $(BUILD_SHARED_LIBRARY)