# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HAPBICPAMDF(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHAPBICPAMDF(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HAPBICPAMDF()
        x.Init(buf, n + offset)
        return x

    # HAPBICPAMDF
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HAPBICPAMDF
    def AGOIMGHMGOH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.String(o + self._tab.Pos)
        return ""

    # HAPBICPAMDF
    def KJFEBMBHKOC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HAPBICPAMDFStart(builder): builder.StartObject(2)
def HAPBICPAMDFAddAGOIMGHMGOH(builder, AGOIMGHMGOH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(AGOIMGHMGOH), 0)
def HAPBICPAMDFAddKJFEBMBHKOC(builder, KJFEBMBHKOC): builder.PrependInt32Slot(1, KJFEBMBHKOC, 0)
def HAPBICPAMDFEnd(builder): return builder.EndObject()
