#-------------------------------------------------
#
# Project created by QtCreator 2016-06-03T04:59:49
#
#-------------------------------------------------

QT       += core

QT       -= gui

TARGET = Server
CONFIG   += console
CONFIG   -= app_bundle

TEMPLATE = app

QMAKE_CXXFLAGS += -pthread -std=c++11
QMAKE_LFLAGS += -pthread -std=c++11

INCLUDEPATH +=usr/local/lib/include
LIBS += /usr/local/lib/libprotobuf.so

SOURCES += src/main.cpp src/ProjectServer.cpp src/somerequests.pb.cc
HEADERS += headers/somerequests.pb.h headers/ProjectServer.h
