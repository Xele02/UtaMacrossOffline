# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class APIFHKKHODH(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsAPIFHKKHODH(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = APIFHKKHODH()
        x.Init(buf, n + offset)
        return x

    # APIFHKKHODH
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # APIFHKKHODH
    def DLPCOLDNAKE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # APIFHKKHODH
    def GDLJMMPFINH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # APIFHKKHODH
    def LBMKEILIGBG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # APIFHKKHODH
    def ADCLAGBHDBC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # APIFHKKHODH
    def CBPNNKIHKNG(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # APIFHKKHODH
    def PMNEOKOIHPD(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # APIFHKKHODH
    def PMNEOKOIHPDLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def APIFHKKHODHStart(builder): builder.StartObject(6)
def APIFHKKHODHAddDLPCOLDNAKE(builder, DLPCOLDNAKE): builder.PrependUint32Slot(0, DLPCOLDNAKE, 0)
def APIFHKKHODHAddGDLJMMPFINH(builder, GDLJMMPFINH): builder.PrependUint32Slot(1, GDLJMMPFINH, 0)
def APIFHKKHODHAddLBMKEILIGBG(builder, LBMKEILIGBG): builder.PrependUint32Slot(2, LBMKEILIGBG, 0)
def APIFHKKHODHAddADCLAGBHDBC(builder, ADCLAGBHDBC): builder.PrependUint32Slot(3, ADCLAGBHDBC, 0)
def APIFHKKHODHAddCBPNNKIHKNG(builder, CBPNNKIHKNG): builder.PrependUint32Slot(4, CBPNNKIHKNG, 0)
def APIFHKKHODHAddPMNEOKOIHPD(builder, PMNEOKOIHPD): builder.PrependUOffsetTRelativeSlot(5, flatbuffers.number_types.UOffsetTFlags.py_type(PMNEOKOIHPD), 0)
def APIFHKKHODHStartPMNEOKOIHPDVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def APIFHKKHODHEnd(builder): return builder.EndObject()
