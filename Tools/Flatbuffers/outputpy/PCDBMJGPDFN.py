# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class PCDBMJGPDFN(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsPCDBMJGPDFN(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = PCDBMJGPDFN()
        x.Init(buf, n + offset)
        return x

    # PCDBMJGPDFN
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # PCDBMJGPDFN
    def LNHODOPAJIL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PCDBMJGPDFN
    def LHMHAFHMNFF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PCDBMJGPDFN
    def CLEEFGNMCEL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # PCDBMJGPDFN
    def CIJLLHJEANC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def PCDBMJGPDFNStart(builder): builder.StartObject(4)
def PCDBMJGPDFNAddLNHODOPAJIL(builder, LNHODOPAJIL): builder.PrependUint32Slot(0, LNHODOPAJIL, 0)
def PCDBMJGPDFNAddLHMHAFHMNFF(builder, LHMHAFHMNFF): builder.PrependUint32Slot(1, LHMHAFHMNFF, 0)
def PCDBMJGPDFNAddCLEEFGNMCEL(builder, CLEEFGNMCEL): builder.PrependUint32Slot(2, CLEEFGNMCEL, 0)
def PCDBMJGPDFNAddCIJLLHJEANC(builder, CIJLLHJEANC): builder.PrependUint32Slot(3, CIJLLHJEANC, 0)
def PCDBMJGPDFNEnd(builder): return builder.EndObject()
