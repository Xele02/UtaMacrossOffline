# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class CHFNKBBHDGM(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsCHFNKBBHDGM(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = CHFNKBBHDGM()
        x.Init(buf, n + offset)
        return x

    # CHFNKBBHDGM
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # CHFNKBBHDGM
    def EMGBLHGBJND(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .CJBICDDNGHH import CJBICDDNGHH
            obj = CJBICDDNGHH()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # CHFNKBBHDGM
    def EMGBLHGBJNDLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def CHFNKBBHDGMStart(builder): builder.StartObject(1)
def CHFNKBBHDGMAddEMGBLHGBJND(builder, EMGBLHGBJND): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(EMGBLHGBJND), 0)
def CHFNKBBHDGMStartEMGBLHGBJNDVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def CHFNKBBHDGMEnd(builder): return builder.EndObject()
