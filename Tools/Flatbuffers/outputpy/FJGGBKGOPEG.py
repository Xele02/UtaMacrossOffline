# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class FJGGBKGOPEG(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsFJGGBKGOPEG(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = FJGGBKGOPEG()
        x.Init(buf, n + offset)
        return x

    # FJGGBKGOPEG
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # FJGGBKGOPEG
    def HCAJMDDNOAN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .LDJGKHHLNKN import LDJGKHHLNKN
            obj = LDJGKHHLNKN()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # FJGGBKGOPEG
    def HCAJMDDNOANLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def FJGGBKGOPEGStart(builder): builder.StartObject(1)
def FJGGBKGOPEGAddHCAJMDDNOAN(builder, HCAJMDDNOAN): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(HCAJMDDNOAN), 0)
def FJGGBKGOPEGStartHCAJMDDNOANVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def FJGGBKGOPEGEnd(builder): return builder.EndObject()
