# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class JJKEIOGAGKI(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsJJKEIOGAGKI(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = JJKEIOGAGKI()
        x.Init(buf, n + offset)
        return x

    # JJKEIOGAGKI
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # JJKEIOGAGKI
    def BBJIABHHCNN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .AGFBIPOFDKC import AGFBIPOFDKC
            obj = AGFBIPOFDKC()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # JJKEIOGAGKI
    def BBJIABHHCNNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # JJKEIOGAGKI
    def GMFHOALFGJC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .PMEKDNKBNBI import PMEKDNKBNBI
            obj = PMEKDNKBNBI()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # JJKEIOGAGKI
    def GMFHOALFGJCLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # JJKEIOGAGKI
    def FLKKDMDCNDN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .FGEACEDNLAC import FGEACEDNLAC
            obj = FGEACEDNLAC()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # JJKEIOGAGKI
    def FLKKDMDCNDNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # JJKEIOGAGKI
    def NJJINHMIOHN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .BOOHINDELKH import BOOHINDELKH
            obj = BOOHINDELKH()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # JJKEIOGAGKI
    def NJJINHMIOHNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # JJKEIOGAGKI
    def NPFBHGKLIOM(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .EAJOKHIMIMD import EAJOKHIMIMD
            obj = EAJOKHIMIMD()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # JJKEIOGAGKI
    def NPFBHGKLIOMLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def JJKEIOGAGKIStart(builder): builder.StartObject(5)
def JJKEIOGAGKIAddBBJIABHHCNN(builder, BBJIABHHCNN): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(BBJIABHHCNN), 0)
def JJKEIOGAGKIStartBBJIABHHCNNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def JJKEIOGAGKIAddGMFHOALFGJC(builder, GMFHOALFGJC): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(GMFHOALFGJC), 0)
def JJKEIOGAGKIStartGMFHOALFGJCVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def JJKEIOGAGKIAddFLKKDMDCNDN(builder, FLKKDMDCNDN): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(FLKKDMDCNDN), 0)
def JJKEIOGAGKIStartFLKKDMDCNDNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def JJKEIOGAGKIAddNJJINHMIOHN(builder, NJJINHMIOHN): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(NJJINHMIOHN), 0)
def JJKEIOGAGKIStartNJJINHMIOHNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def JJKEIOGAGKIAddNPFBHGKLIOM(builder, NPFBHGKLIOM): builder.PrependUOffsetTRelativeSlot(4, flatbuffers.number_types.UOffsetTFlags.py_type(NPFBHGKLIOM), 0)
def JJKEIOGAGKIStartNPFBHGKLIOMVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def JJKEIOGAGKIEnd(builder): return builder.EndObject()
