# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class ONCFNGIBLHO(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsONCFNGIBLHO(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = ONCFNGIBLHO()
        x.Init(buf, n + offset)
        return x

    # ONCFNGIBLHO
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # ONCFNGIBLHO
    def KDGCIEMFIIM(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .INFGGLDJAIF import INFGGLDJAIF
            obj = INFGGLDJAIF()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # ONCFNGIBLHO
    def KDGCIEMFIIMLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def ONCFNGIBLHOStart(builder): builder.StartObject(1)
def ONCFNGIBLHOAddKDGCIEMFIIM(builder, KDGCIEMFIIM): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(KDGCIEMFIIM), 0)
def ONCFNGIBLHOStartKDGCIEMFIIMVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def ONCFNGIBLHOEnd(builder): return builder.EndObject()
