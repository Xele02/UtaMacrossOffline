# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class CBOPKMNJJIA(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsCBOPKMNJJIA(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = CBOPKMNJJIA()
        x.Init(buf, n + offset)
        return x

    # CBOPKMNJJIA
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # CBOPKMNJJIA
    def HBPDIEOICJP(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .CECBEDHLMBM import CECBEDHLMBM
            obj = CECBEDHLMBM()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # CBOPKMNJJIA
    def HBPDIEOICJPLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def CBOPKMNJJIAStart(builder): builder.StartObject(1)
def CBOPKMNJJIAAddHBPDIEOICJP(builder, HBPDIEOICJP): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(HBPDIEOICJP), 0)
def CBOPKMNJJIAStartHBPDIEOICJPVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def CBOPKMNJJIAEnd(builder): return builder.EndObject()
